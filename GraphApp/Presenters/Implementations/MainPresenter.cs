using System;
using System.Linq;
using GraphApp.LogicContracts;
using GraphApp.Models;
using GraphApp.Presenters.Interfaces;
using GraphApp.Views.Interfaces;

namespace GraphApp.Presenters.Implementations
{
    public class MainPresenter : BasePresenter<IMainView>, IMainPresenter
    {
        private readonly IMathGraph mathGraph;

        public MainPresenter(IMathGraph mathGraph)
        {
            this.mathGraph = mathGraph;
        }

        public void AddVertex(Graph graph)
        {
            try
            {
                this.mathGraph.AddVertex(graph);

                this.View.Draw();
            }
            catch
            {
                throw;
            }
        }

        public void AddWeightedEdge(Graph graph, int vertexOneNumber, int vertexTwoNumber, float weight)
        {
            try
            {
                this.mathGraph.AddWeightedEdge(
                    graph, 
                    GetWeightedEdge(vertexOneNumber, vertexTwoNumber, weight));

                this.View.Draw();
            }
            catch
            {
                throw;
            }
        }

        public bool СompletenessGraff(Graph graph)
        {
            try
            {
                return this.mathGraph.СompletenessGraff(graph);
            }
            catch
            {
                throw;
            }
        }

        public bool AreVerticesAdjacent(Graph graph, int vertexOneNumber, int vertexTwoNumber)
        {
            try
            {
                return this.mathGraph.AreVerticesAdjacent(graph, GetVertex(vertexOneNumber), GetVertex(vertexTwoNumber));
            }
            catch
            {
                throw;
            }
        }

        public void CreateGraph()
        {
            var graph = this.mathGraph.CreateEmptyGraph();

            this.View.SetGraph(graph);

            this.View.Draw();
        }

        public void LoadGraphFromAdjacentMatrix(string path)
        {
            try
            {
                var graph = this.mathGraph.LoadGraphFromAdjacencyMatrix(path);

                this.View.SetGraph(graph);

                this.View.Draw();
            }
            catch
            {
                throw;
            }
        }

        public void LoadGraphFromEdgeList(string path)
        {
            try
            {
                var graph = this.mathGraph.LoadGraphFromEdgeList(path);

                this.View.SetGraph(graph);

                this.View.Draw();
            }
            catch
            {
                throw;
            }
        }

        public void RemoveVertex(Graph graph, int vertexNumber)
        {
            try
            {
                this.mathGraph.RemoveVertex(graph, GetVertex(vertexNumber));

                this.View.Draw();
            }
            catch
            {
                throw;
            }
        }

        public void RemoveWeightedEdge(Graph graph, int vertexOneNumber, int vertexTwoNumber)
        {
            try
            {
                this.mathGraph.RemoveWeightedEdge(
                    graph,
                    GetWeightedEdge(vertexOneNumber, vertexTwoNumber));

                this.View.Draw();
            }
            catch
            {
                throw;
            }
        }

        public void SaveGraphToAdjacentMatrix(string path, Graph graph)
        {
            try
            {
                this.mathGraph.SaveGraphToAdjacencyMatrix(path, graph);
            }
            catch
            {
                throw;
            }
        }

        public void SaveGraphToEdgeList(string path, Graph graph)
        {
            try
            {
                this.mathGraph.SaveGraphToEdgeList(path, graph);
            }
            catch
            {
                throw;
            }
        }
        
        public float GetWeightOfEdge(Graph graph, int vertexOneNumber, int vertexTwoNumber)
        {
            var edge = graph.Edges.FirstOrDefault(x => x.VertexOne.Number == vertexOneNumber && x.VertexTwo.Number == vertexTwoNumber);

            if (edge == null)
            {
                throw new ArgumentException("Graph does not have this edge");
            }

            return edge.Weight;
        }

        private static Vertex GetVertex(int vertexNumber)
        {
            return new Vertex
            {
                Number = vertexNumber,
                Location = new Point()
            };
        }

        private static WeightedEdge GetWeightedEdge(int vertexOneNumber, int vertexTwoNumber, float weight = 0)
        {
            return new WeightedEdge
            {
                VertexOne = GetVertex(vertexOneNumber),
                VertexTwo = GetVertex(vertexTwoNumber),
                Weight = weight
            };
        }
    }
}