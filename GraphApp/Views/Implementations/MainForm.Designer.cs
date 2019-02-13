namespace GraphApp.Views.Implementations
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.addVertexButton = new System.Windows.Forms.Button();
            this.vertexCountLabel = new System.Windows.Forms.Label();
            this.removableVertexTextBox = new System.Windows.Forms.TextBox();
            this.removableVertexLabel = new System.Windows.Forms.Label();
            this.removeVertexButton = new System.Windows.Forms.Button();
            this.secondVertexNumber = new System.Windows.Forms.TextBox();
            this.firstVertexNumber = new System.Windows.Forms.TextBox();
            this.firstVertexNumberLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addEdgeButton = new System.Windows.Forms.Button();
            this.removeEdgeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.verticesAdjacentButton = new System.Windows.Forms.Button();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createGraphToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFromAdjacentMatrixToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFromEdgeListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToAdjacentMatrixToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToEdgeListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileAcitonsMenuStrip = new System.Windows.Forms.MenuStrip();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.edgesCountLabel = new System.Windows.Forms.Label();
            this.getWeightButton = new System.Windows.Forms.Button();
            this.СompletenessGraff = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.fileAcitonsMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(12, 27);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(425, 425);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // addVertexButton
            // 
            this.addVertexButton.Location = new System.Drawing.Point(446, 43);
            this.addVertexButton.Name = "addVertexButton";
            this.addVertexButton.Size = new System.Drawing.Size(178, 23);
            this.addVertexButton.TabIndex = 2;
            this.addVertexButton.Text = "Добавить вернишу";
            this.addVertexButton.UseVisualStyleBackColor = true;
            this.addVertexButton.Click += new System.EventHandler(this.addVertexButton_Click);
            // 
            // vertexCountLabel
            // 
            this.vertexCountLabel.AutoSize = true;
            this.vertexCountLabel.Location = new System.Drawing.Point(443, 27);
            this.vertexCountLabel.Name = "vertexCountLabel";
            this.vertexCountLabel.Size = new System.Drawing.Size(119, 13);
            this.vertexCountLabel.TabIndex = 3;
            this.vertexCountLabel.Text = "Количество вершин: 0";
            // 
            // removableVertexTextBox
            // 
            this.removableVertexTextBox.Location = new System.Drawing.Point(597, 89);
            this.removableVertexTextBox.Name = "removableVertexTextBox";
            this.removableVertexTextBox.Size = new System.Drawing.Size(27, 20);
            this.removableVertexTextBox.TabIndex = 4;
            // 
            // removableVertexLabel
            // 
            this.removableVertexLabel.AutoSize = true;
            this.removableVertexLabel.Location = new System.Drawing.Point(443, 92);
            this.removableVertexLabel.Name = "removableVertexLabel";
            this.removableVertexLabel.Size = new System.Drawing.Size(151, 13);
            this.removableVertexLabel.TabIndex = 5;
            this.removableVertexLabel.Text = "Номер удаляемой вершины:";
            // 
            // removeVertexButton
            // 
            this.removeVertexButton.Location = new System.Drawing.Point(446, 115);
            this.removeVertexButton.Name = "removeVertexButton";
            this.removeVertexButton.Size = new System.Drawing.Size(178, 23);
            this.removeVertexButton.TabIndex = 6;
            this.removeVertexButton.Text = "Удалить вершину";
            this.removeVertexButton.UseVisualStyleBackColor = true;
            this.removeVertexButton.Click += new System.EventHandler(this.removeVertexButton_Click);
            // 
            // secondVertexNumber
            // 
            this.secondVertexNumber.Location = new System.Drawing.Point(583, 202);
            this.secondVertexNumber.Name = "secondVertexNumber";
            this.secondVertexNumber.Size = new System.Drawing.Size(41, 20);
            this.secondVertexNumber.TabIndex = 8;
            // 
            // firstVertexNumber
            // 
            this.firstVertexNumber.Location = new System.Drawing.Point(583, 177);
            this.firstVertexNumber.Name = "firstVertexNumber";
            this.firstVertexNumber.Size = new System.Drawing.Size(41, 20);
            this.firstVertexNumber.TabIndex = 9;
            // 
            // firstVertexNumberLabel
            // 
            this.firstVertexNumberLabel.AutoSize = true;
            this.firstVertexNumberLabel.Location = new System.Drawing.Point(443, 180);
            this.firstVertexNumberLabel.Name = "firstVertexNumberLabel";
            this.firstVertexNumberLabel.Size = new System.Drawing.Size(132, 13);
            this.firstVertexNumberLabel.TabIndex = 10;
            this.firstVertexNumberLabel.Text = "Номер первой вершины:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(443, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Номер второй вершины:";
            // 
            // addEdgeButton
            // 
            this.addEdgeButton.Location = new System.Drawing.Point(446, 254);
            this.addEdgeButton.Name = "addEdgeButton";
            this.addEdgeButton.Size = new System.Drawing.Size(178, 23);
            this.addEdgeButton.TabIndex = 12;
            this.addEdgeButton.Text = "Добавить ребро";
            this.addEdgeButton.UseVisualStyleBackColor = true;
            this.addEdgeButton.Click += new System.EventHandler(this.addEdgeButton_Click);
            // 
            // removeEdgeButton
            // 
            this.removeEdgeButton.Location = new System.Drawing.Point(446, 283);
            this.removeEdgeButton.Name = "removeEdgeButton";
            this.removeEdgeButton.Size = new System.Drawing.Size(178, 23);
            this.removeEdgeButton.TabIndex = 13;
            this.removeEdgeButton.Text = "Удалить ребро";
            this.removeEdgeButton.UseVisualStyleBackColor = true;
            this.removeEdgeButton.Click += new System.EventHandler(this.removeEdgeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(443, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Вес:";
            // 
            // weightTextBox
            // 
            this.weightTextBox.Location = new System.Drawing.Point(583, 228);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(41, 20);
            this.weightTextBox.TabIndex = 15;
            // 
            // verticesAdjacentButton
            // 
            this.verticesAdjacentButton.Location = new System.Drawing.Point(446, 312);
            this.verticesAdjacentButton.Name = "verticesAdjacentButton";
            this.verticesAdjacentButton.Size = new System.Drawing.Size(178, 35);
            this.verticesAdjacentButton.TabIndex = 16;
            this.verticesAdjacentButton.Text = "Смежны ли вершины ?";
            this.verticesAdjacentButton.UseVisualStyleBackColor = true;
            this.verticesAdjacentButton.Click += new System.EventHandler(this.verticesAdjacentButton_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createGraphToolStripMenuItem,
            this.loadFromAdjacentMatrixToolStripMenuItem,
            this.loadFromEdgeListToolStripMenuItem,
            this.saveToAdjacentMatrixToolStripMenuItem,
            this.saveToEdgeListToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // createGraphToolStripMenuItem
            // 
            this.createGraphToolStripMenuItem.Name = "createGraphToolStripMenuItem";
            this.createGraphToolStripMenuItem.Size = new System.Drawing.Size(268, 22);
            this.createGraphToolStripMenuItem.Text = "Создать граф";
            this.createGraphToolStripMenuItem.Click += new System.EventHandler(this.createGraphToolStripMenuItem_Click);
            // 
            // loadFromAdjacentMatrixToolStripMenuItem
            // 
            this.loadFromAdjacentMatrixToolStripMenuItem.Name = "loadFromAdjacentMatrixToolStripMenuItem";
            this.loadFromAdjacentMatrixToolStripMenuItem.Size = new System.Drawing.Size(268, 22);
            this.loadFromAdjacentMatrixToolStripMenuItem.Text = "Загрузить из матрицы смежности";
            this.loadFromAdjacentMatrixToolStripMenuItem.Click += new System.EventHandler(this.loadFromAdjacentMatrixToolStripMenuItem_Click);
            // 
            // loadFromEdgeListToolStripMenuItem
            // 
            this.loadFromEdgeListToolStripMenuItem.Name = "loadFromEdgeListToolStripMenuItem";
            this.loadFromEdgeListToolStripMenuItem.Size = new System.Drawing.Size(268, 22);
            this.loadFromEdgeListToolStripMenuItem.Text = "Загрузить из списка ребер";
            this.loadFromEdgeListToolStripMenuItem.Click += new System.EventHandler(this.loadFromEdgeListToolStripMenuItem_Click);
            // 
            // saveToAdjacentMatrixToolStripMenuItem
            // 
            this.saveToAdjacentMatrixToolStripMenuItem.Name = "saveToAdjacentMatrixToolStripMenuItem";
            this.saveToAdjacentMatrixToolStripMenuItem.Size = new System.Drawing.Size(268, 22);
            this.saveToAdjacentMatrixToolStripMenuItem.Text = "Сохранить как матрицу смежности";
            this.saveToAdjacentMatrixToolStripMenuItem.Click += new System.EventHandler(this.saveToAdjacentMatrixToolStripMenuItem_Click);
            // 
            // saveToEdgeListToolStripMenuItem
            // 
            this.saveToEdgeListToolStripMenuItem.Name = "saveToEdgeListToolStripMenuItem";
            this.saveToEdgeListToolStripMenuItem.Size = new System.Drawing.Size(268, 22);
            this.saveToEdgeListToolStripMenuItem.Text = "Сохранить как список ребер";
            this.saveToEdgeListToolStripMenuItem.Click += new System.EventHandler(this.saveToEdgeListToolStripMenuItem_Click);
            // 
            // fileAcitonsMenuStrip
            // 
            this.fileAcitonsMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.fileAcitonsMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.fileAcitonsMenuStrip.Name = "fileAcitonsMenuStrip";
            this.fileAcitonsMenuStrip.Size = new System.Drawing.Size(634, 24);
            this.fileAcitonsMenuStrip.TabIndex = 22;
            this.fileAcitonsMenuStrip.Text = "menuStrip1";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "*.txt";
            this.saveFileDialog.FileName = "graph";
            this.saveFileDialog.Filter = "Text File (*.txt)|*.txt";
            // 
            // edgesCountLabel
            // 
            this.edgesCountLabel.AutoSize = true;
            this.edgesCountLabel.Location = new System.Drawing.Point(443, 158);
            this.edgesCountLabel.Name = "edgesCountLabel";
            this.edgesCountLabel.Size = new System.Drawing.Size(111, 13);
            this.edgesCountLabel.TabIndex = 23;
            this.edgesCountLabel.Text = "Количество ребер: 0";
            // 
            // getWeightButton
            // 
            this.getWeightButton.Location = new System.Drawing.Point(446, 354);
            this.getWeightButton.Name = "getWeightButton";
            this.getWeightButton.Size = new System.Drawing.Size(178, 23);
            this.getWeightButton.TabIndex = 24;
            this.getWeightButton.Text = "Получить вес ребра";
            this.getWeightButton.UseVisualStyleBackColor = true;
            this.getWeightButton.Click += new System.EventHandler(this.getWeightButton_Click);
            // 
            // СompletenessGraff
            // 
            this.СompletenessGraff.Location = new System.Drawing.Point(446, 383);
            this.СompletenessGraff.Name = "СompletenessGraff";
            this.СompletenessGraff.Size = new System.Drawing.Size(178, 45);
            this.СompletenessGraff.TabIndex = 25;
            this.СompletenessGraff.Text = "Проверить полноту граффа";
            this.СompletenessGraff.UseVisualStyleBackColor = true;
            this.СompletenessGraff.Click += new System.EventHandler(this.СompletenessGraff_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(634, 461);
            this.Controls.Add(this.СompletenessGraff);
            this.Controls.Add(this.getWeightButton);
            this.Controls.Add(this.edgesCountLabel);
            this.Controls.Add(this.removeVertexButton);
            this.Controls.Add(this.verticesAdjacentButton);
            this.Controls.Add(this.weightTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.removeEdgeButton);
            this.Controls.Add(this.addEdgeButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.firstVertexNumberLabel);
            this.Controls.Add(this.firstVertexNumber);
            this.Controls.Add(this.secondVertexNumber);
            this.Controls.Add(this.removableVertexLabel);
            this.Controls.Add(this.removableVertexTextBox);
            this.Controls.Add(this.vertexCountLabel);
            this.Controls.Add(this.addVertexButton);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.fileAcitonsMenuStrip);
            this.MainMenuStrip = this.fileAcitonsMenuStrip;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Приложение для работы с графом";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.fileAcitonsMenuStrip.ResumeLayout(false);
            this.fileAcitonsMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button addVertexButton;
        private System.Windows.Forms.Label vertexCountLabel;
        private System.Windows.Forms.TextBox removableVertexTextBox;
        private System.Windows.Forms.Label removableVertexLabel;
        private System.Windows.Forms.Button removeVertexButton;
        private System.Windows.Forms.TextBox secondVertexNumber;
        private System.Windows.Forms.TextBox firstVertexNumber;
        private System.Windows.Forms.Label firstVertexNumberLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addEdgeButton;
        private System.Windows.Forms.Button removeEdgeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.Button verticesAdjacentButton;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createGraphToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadFromAdjacentMatrixToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadFromEdgeListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToAdjacentMatrixToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToEdgeListToolStripMenuItem;
        private System.Windows.Forms.MenuStrip fileAcitonsMenuStrip;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Label edgesCountLabel;
        private System.Windows.Forms.Button getWeightButton;
        private System.Windows.Forms.Button СompletenessGraff;
    }
}