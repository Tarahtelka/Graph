using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using GraphApp.Models;
using GraphApp.Presenters.Interfaces;
using GraphApp.Views.Implementations.Helpers;
using GraphApp.Views.Interfaces;

namespace GraphApp.Views.Implementations
{
    public partial class MainForm : Form, IMainView
    {
        private readonly IMainPresenter mainPresenter;
        private Graph graph;

        public MainForm(IMainPresenter mainPresenter)
        {
            this.InitializeComponent();

            this.mainPresenter = mainPresenter;
            this.mainPresenter.View = this;

            this.InitializePictureBox();

            this.mainPresenter.CreateGraph();
        }

        public void Draw()
        {
            if (!this.AssertGraph())
            {
                return;
            }

            using (var g = Graphics.FromImage(this.pictureBox.Image))
            {
                g.Clear(Color.White);

                var angle = (Math.PI * 2) / this.graph.Vertices.Count;

                var index = 0;

                foreach (var vertex in this.graph.Vertices)
                {
                    this.SetCoords(vertex, angle, index);

                    this.DrawVertex(g, vertex, DrawObjects.Pen, Constants.Font);

                    index++;
                }

                foreach (var edge in this.graph.Edges)
                {
                    this.DrawEdge(g, edge, DrawObjects.Pen, Constants.Font);
                }
            }

            this.pictureBox.Invalidate();
        }

        public void SetGraph(Graph graph)
        {
            this.graph = graph;
        }

        #region DrawingMethods
        private void SetCoords(Vertex vertex, double angle, int index)
        {
            var alpha = angle * index;
            var sin = Math.Sin(alpha);
            var cos = Math.Cos(alpha);

            vertex.Location.X = (int)(Constants.Multiplier * sin) + (this.pictureBox.Width / 2);
            vertex.Location.Y = (int)(Constants.Multiplier * cos) + (this.pictureBox.Height / 2);
        }

        private void DrawVertex(Graphics g, Vertex vertex, Pen pen, Font font)
        {
            g.DrawEllipse(
                DrawObjects.Pen,
                vertex.Location.X - (Constants.CircleRadius / 2),
                vertex.Location.Y - (Constants.CircleRadius / 2),
                Constants.CircleRadius,
                Constants.CircleRadius);

            var sf = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            

            g.DrawString(vertex.Number.ToString(), font, DrawObjects.Brush, new PointF(vertex.Location.X, vertex.Location.Y), sf);
        }

        private void DrawEdge(Graphics g, WeightedEdge weightedEdge, Pen pen, Font font)
        {
            var vertexOne = this.graph.Vertices.FirstOrDefault(x => x.Number == weightedEdge.VertexOne.Number);
            var vertexTwo = this.graph.Vertices.FirstOrDefault(x => x.Number == weightedEdge.VertexTwo.Number);

            var vx1 = vertexOne.Location.X;
            var vx2 = vertexTwo.Location.X;
            var vy1 = vertexOne.Location.Y;
            var vy2 = vertexTwo.Location.Y;
            float r = Constants.CircleRadius;

            var fullLength = (int)(Math.Sqrt(Math.Pow(vx2 - vx1, 2) + Math.Pow(vy2 - vy1, 2)));
            var diff = (r / 2 / fullLength);

            var x1 = (vx1 + diff * vx2) / (1 + diff);
            var x2 = (vx2 + diff * vx1) / (1 + diff);
            var y1 = (vy1 + diff * vy2) / (1 + diff);
            var y2 = (vy2 + diff * vy1) / (1 + diff);

            g.DrawLine(pen, x1, y1, x2, y2);

            var offsetX = (x1 >= x2) ? -6 : 6 + Constants.PenSize;
            var offsetY = (y1 >= y2) ? 6 : -6 + Constants.PenSize;

            var sf = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            g.DrawString(
                weightedEdge.Weight.ToString(),
                font,
                DrawObjects.Brush,
                new PointF()
                {
                    X = (vertexOne.Location.X + vertexTwo.Location.X) / 2 + offsetX,
                    Y = (vertexOne.Location.Y + vertexTwo.Location.Y) / 2 + offsetY
                },
                sf);
        } 
        #endregion

        #region MessageBoxHelpers
        private void ErrorMessageBox(string message)
            => MessageBox.Show(message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

        private void WarningMessageBox(string message)
            => MessageBox.Show(message, "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        private void InfoMessageBox(string message)
            => MessageBox.Show(message, "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information); 
        #endregion

        #region Events
        private void addVertexButton_Click(object sender, EventArgs e)
        {
            if (!this.AssertGraph())
            {
                return;
            }

            try
            {
                this.mainPresenter.AddVertex(this.graph);
            }
            catch (Exception ex)
            {
                this.ErrorMessageBox(ex.Message);
            }

            this.UpdateVertexLabel();
        }

        private void createGraphToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.mainPresenter.CreateGraph();

            this.UpdateVertexLabel();
        }

        private void removeVertexButton_Click(object sender, EventArgs e)
        {
            var vertexNumber = this.removableVertexTextBox.TryGetInt32(
                () => this.InfoMessageBox("Введите номер вершины"),
                () => this.WarningMessageBox("Некорректный номер вершины"));

            if (vertexNumber == null)
            {
                return;
            }

            try
            {
                this.mainPresenter.RemoveVertex(this.graph, vertexNumber.Value);

                this.UpdateVertexLabel();
            }
            catch (Exception ex)
            {
                this.ErrorMessageBox(ex.Message);
            }
        }

        private void loadFromAdjacentMatrixToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    this.mainPresenter.LoadGraphFromAdjacentMatrix(this.openFileDialog.FileName);

                    this.UpdateVertexLabel();
                    this.UpdateEdgeLabel();
                }
            }
            catch (Exception ex)
            {
                this.ErrorMessageBox(ex.Message);
            }
        }

        private void loadFromEdgeListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    this.mainPresenter.LoadGraphFromEdgeList(this.openFileDialog.FileName);

                    this.UpdateVertexLabel();
                    this.UpdateEdgeLabel();
                }
            }
            catch (Exception ex)
            {
                this.ErrorMessageBox(ex.Message);
            }
        }

        private void saveToAdjacentMatrixToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!this.AssertGraph())
            {
                return;
            }

            try
            {
                if (this.saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    this.mainPresenter.SaveGraphToAdjacentMatrix(this.saveFileDialog.FileName, this.graph);
                }
            }
            catch (Exception ex)
            {
                this.ErrorMessageBox(ex.Message);
            }
        }

        private void saveToEdgeListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!this.AssertGraph())
            {
                return;
            }

            try
            {
                if (this.saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    this.mainPresenter.SaveGraphToEdgeList(this.saveFileDialog.FileName, this.graph);
                }
            }
            catch (Exception ex)
            {
                this.ErrorMessageBox(ex.Message);
            }
        }

        private void addEdgeButton_Click(object sender, EventArgs e)
        {
            var vertexOneNumber = this.firstVertexNumber.TryGetInt32(
                () => this.InfoMessageBox("Введите номер первой вершины"),
                () => this.WarningMessageBox("Некорректный номер первой вершины"));

            var vertexTwoNumber = this.secondVertexNumber.TryGetInt32(
                () => this.InfoMessageBox("Введите номер второй вершины"),
                () => this.WarningMessageBox("Некорректный номер второй вершины"));

            var edgeWeight = this.weightTextBox.TryGetFloat(
                () => this.InfoMessageBox("Введите вес ребра"),
                () => this.WarningMessageBox("Некорректный вес ребра"));

            if (vertexOneNumber == null || vertexTwoNumber == null || edgeWeight == null)
            {
                return;
            }

            try
            {
                this.mainPresenter.AddWeightedEdge(this.graph, vertexOneNumber.Value, vertexTwoNumber.Value, edgeWeight.Value);

                this.UpdateEdgeLabel();
            }
            catch (Exception ex)
            {
                this.ErrorMessageBox(ex.Message);
            }
        }

        private void removeEdgeButton_Click(object sender, EventArgs e)
        {
            var vertexOneNumber = this.firstVertexNumber.TryGetInt32(
                () => this.InfoMessageBox("Введите номер первой вершины"),
                () => this.WarningMessageBox("Некорректный номер первой вершины"));

            var vertexTwoNumber = this.secondVertexNumber.TryGetInt32(
                () => this.InfoMessageBox("Введите номер второй вершины"),
                () => this.WarningMessageBox("Некорректный номер второй вершины"));

            if (vertexOneNumber == null || vertexTwoNumber == null)
            {
                return;
            }

            try
            {
                this.mainPresenter.RemoveWeightedEdge(this.graph, vertexOneNumber.Value, vertexTwoNumber.Value);

                this.UpdateEdgeLabel();
            }
            catch (Exception ex)
            {
                this.ErrorMessageBox(ex.Message);
            }
        }

        private void verticesAdjacentButton_Click(object sender, EventArgs e)
        {
            var vertexOneNumber = this.firstVertexNumber.TryGetInt32(
                () => this.InfoMessageBox("Введите номер первой вершины"),
                () => this.WarningMessageBox("Некорректный номер первой вершины"));

            var vertexTwoNumber = this.secondVertexNumber.TryGetInt32(
                () => this.InfoMessageBox("Введите номер второй вершины"),
                () => this.WarningMessageBox("Некорректный номер второй вершины"));

            if (vertexOneNumber == null || vertexTwoNumber == null)
            {
                return;
            }

            try
            {
                var result = this.mainPresenter.AreVerticesAdjacent(this.graph, vertexOneNumber.Value, vertexTwoNumber.Value);

                var resultText = result ? "Да" : "Нет";

                MessageBox.Show(resultText, "Смежность вершин", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                this.ErrorMessageBox(ex.Message);
            }
        }

        private void getWeightButton_Click(object sender, EventArgs e)
        {
            var vertexOneNumber = this.firstVertexNumber.TryGetInt32(
                () => this.InfoMessageBox("Введите номер первой вершины"),
                () => this.WarningMessageBox("Некорректный номер первой вершины"));

            var vertexTwoNumber = this.secondVertexNumber.TryGetInt32(
                () => this.InfoMessageBox("Введите номер второй вершины"),
                () => this.WarningMessageBox("Некорректный номер второй вершины"));

            if (vertexOneNumber == null || vertexTwoNumber == null)
            {
                return;
            }

            try
            {
                var result = this.mainPresenter.GetWeightOfEdge(this.graph, vertexOneNumber.Value, vertexTwoNumber.Value);

                MessageBox.Show(result.ToString(), "Вес ребра", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                this.ErrorMessageBox(ex.Message);
            }
        }
        #endregion

        #region OtherHelpers
        private void InitializePictureBox()
        {
            var map = new Bitmap(this.pictureBox.Width, this.pictureBox.Height);

            using (var g = Graphics.FromImage(map))
            {
                g.Clear(Color.White);
            }

            this.pictureBox.Image = map;
        }

        private void UpdateVertexLabel()
        {
            this.vertexCountLabel.Text = $"Количество вершин: {this.graph.Vertices.Count}";
        }

        private void UpdateEdgeLabel()
        {
            this.edgesCountLabel.Text = $"Количество ребер: {this.graph.Edges.Count}";
        }

        private bool AssertGraph()
        {
            if (this.graph == null)
            {
                this.WarningMessageBox("Создайте или загрузите");

                return false;
            }
            
            return true;
        }
        #endregion

        private void СompletenessGraff_Click(object sender, EventArgs e)
        {
            try
            {
                var result = this.mainPresenter.СompletenessGraff(this.graph);

                var resultText = result ? "Граф Полный" : "Граф Неполный";

                MessageBox.Show(resultText, "Полнота графа", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                this.ErrorMessageBox(ex.Message);
            }
        }
    }
}