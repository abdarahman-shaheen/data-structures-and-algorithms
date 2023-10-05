using data_structures_and_algorithms;

namespace Graph_Test
{
    public class UnitTest1
    {
        [Fact]
        public void VertexCanBeSuccessfullyAdded()
        {
            // Arrange
            Graph<string> graph = new Graph<string>();

            // Act
            Vertex<string> vertex = graph.AddVertex("TestVertex");

            // Assert
            Assert.NotNull(vertex);
            Assert.Equal("TestVertex", vertex.Value);
        }

        [Fact]
        public void EdgeCanBeSuccessfullyAdded()
        {
            // Arrange
            Graph<string> graph = new Graph<string>();
            Vertex<string> vertexA = graph.AddVertex("A");
            Vertex<string> vertexB = graph.AddVertex("B");

            // Act
            graph.AddEdge(vertexA, vertexB, 5);

            // Assert
            // Add assertions as needed to ensure the edge is properly added.
        }
        [Fact]
        public void AllVerticesCanBeRetrieved()
        {
            // Arrange
            Graph<string> graph = new Graph<string>();
            graph.AddVertex("A");
            graph.AddVertex("B");
            graph.AddVertex("C");

            // Act
            var vertices = graph.GetVertices();

            // Assert
            Assert.Collection(vertices,
                v => Assert.Equal("A", v.Value),
                v => Assert.Equal("B", v.Value),
                v => Assert.Equal("C", v.Value));
        }
        [Fact]
        public void NeighborsCanBeRetrieved()
        {
            // Arrange
            Graph<string> graph = new Graph<string>();
            Vertex<string> vertexA = graph.AddVertex("A");
            Vertex<string> vertexB = graph.AddVertex("B");
            graph.AddEdge(vertexA, vertexB, 3);

            // Act
            var neighbors = graph.GetNeighbors(vertexA);

            // Assert
            // Add assertions as needed to ensure the neighbors are properly retrieved.
        }
        [Fact]
        public void NeighborsIncludeWeights()
        {
            // Arrange
            Graph<string> graph = new Graph<string>();
            Vertex<string> vertexA = graph.AddVertex("A");
            Vertex<string> vertexB = graph.AddVertex("B");
            graph.AddEdge(vertexA, vertexB, 3);

            // Act
            var neighbors = graph.GetNeighbors(vertexA);

            // Assert
            // Add assertions to ensure that the neighbors' weights are included.
        }
        [Fact]
        public void ProperSizeIsReturned()
        {
            // Arrange
            Graph<string> graph = new Graph<string>();
            graph.AddVertex("A");
            graph.AddVertex("B");
            graph.AddVertex("C");

            // Act
            int size = graph.Size();

            // Assert
            Assert.Equal(3, size);
        }
        [Fact]
        public void GraphWithOneVertexAndEdge()
        {
            // Arrange
            Graph<string> graph = new Graph<string>();
            Vertex<string> vertexA = graph.AddVertex("A");
            Vertex<string> vertexB = graph.AddVertex("B");
            graph.AddEdge(vertexA, vertexB, 5);

            // Act
            // Perform assertions to ensure the graph structure is as expected.
        }
        [Fact]
        public void AddEdge_ShouldAddEdgeBetweenVertices()
        {
            var graph = new Graph<string>();
            var vertex1 = graph.AddVertex("A");
            var vertex2 = graph.AddVertex("B");

            graph.AddEdge(vertex1, vertex2);

            var neighborsOfVertex1 = graph.GetNeighbors(vertex1);
            var neighborsOfVertex2 = graph.GetNeighbors(vertex2);

            Assert.Single(neighborsOfVertex1);
            Assert.Single(neighborsOfVertex2);
            Assert.Equal(vertex2.Value, neighborsOfVertex1.First().Vertex.Value);
            Assert.Equal(vertex1.Value, neighborsOfVertex2.First().Vertex.Value);
        }

        [Fact]
        public void GetVertices_ShouldReturnAllVerticesInGraph()
        {
            var graph = new Graph<char>();
            var vertex1 = graph.AddVertex('A');
            var vertex2 = graph.AddVertex('B');
            var vertex3 = graph.AddVertex('C');

            var vertices = graph.GetVertices();

            Assert.Equal(3, vertices.Count);
            Assert.Contains(vertex1, vertices);
            Assert.Contains(vertex2, vertices);
            Assert.Contains(vertex3, vertices);
        }

        [Fact]
        public void GetNeighbors_ShouldReturnNeighborsOfVertex()
        {
            var graph = new Graph<int>();
            var vertex1 = graph.AddVertex(1);
            var vertex2 = graph.AddVertex(2);
            var vertex3 = graph.AddVertex(3);
            graph.AddEdge(vertex1, vertex2, 10);
            graph.AddEdge(vertex1, vertex3, 20);

            var neighborsOfVertex1 = graph.GetNeighbors(vertex1);

            Assert.Equal(2, neighborsOfVertex1.Count);
            Assert.Contains(neighborsOfVertex1, edge => edge.Vertex.Value == vertex2.Value && edge.Weight == 10);
            Assert.Contains(neighborsOfVertex1, edge => edge.Vertex.Value == vertex3.Value && edge.Weight == 20);
        }

        [Fact]
        public void BreadthFirstTraversalShouldTraverseInCorrectOrder()
        {
            var graph = new Graph<string>();
            var vertexA = graph.AddVertex("Pandora");
            var vertexB = graph.AddVertex("Arendelle");
            var vertexC = graph.AddVertex("Metroville");
            var vertexD = graph.AddVertex("Monstroplolis");
            var vertexE = graph.AddVertex("Narnia");
            var vertexF = graph.AddVertex("Naboo");

            graph.AddEdge(vertexA, vertexB);
            graph.AddEdge(vertexB, vertexC);
            graph.AddEdge(vertexC, vertexD);
            graph.AddEdge(vertexD, vertexE);
            graph.AddEdge(vertexE, vertexF);

            var result = graph.BreadthFirstTraversal(vertexA);

            Assert.Collection(result,
                vertex => Assert.Equal("Pandora", vertex.Value),
                vertex => Assert.Equal("Arendelle", vertex.Value),
                vertex => Assert.Equal("Metroville", vertex.Value),
                vertex => Assert.Equal("Monstroplolis", vertex.Value),
                vertex => Assert.Equal("Narnia", vertex.Value),
                vertex => Assert.Equal("Naboo", vertex.Value)
            );
        }

        [Fact]
        public void BreadthFirstTraversalInvalidStartVertexShouldThrowException()
        {
            var graph = new Graph<string>();
            var invalidVertex = new Vertex<string>("InvalidVertex");

            var exception = Assert.Throws<InvalidOperationException>(() => graph.BreadthFirstTraversal(invalidVertex));
            Assert.Equal("Start vertex is not in the graph.", exception.Message);
        }
        [Fact]
        public void BusinessTrip_ShouldReturnCorrectCost_WhenValidInput()
        {
            Graph<string> graph = new Graph<string>();

            Vertex<string> pandora = graph.AddVertex("Pandora");
            Vertex<string> arendelle = graph.AddVertex("Arendelle");
            Vertex<string> metroville = graph.AddVertex("Metroville");
            Vertex<string> monstropolis = graph.AddVertex("New Monstropolis");
            Vertex<string> naboo = graph.AddVertex("Naboo");
            Vertex<string> narnia = graph.AddVertex("Narnia");

            graph.AddEdge(pandora, arendelle, 150);
            graph.AddEdge(pandora, metroville, 82);
            graph.AddEdge(arendelle, metroville, 99);
            graph.AddEdge(arendelle, monstropolis, 42);
            graph.AddEdge(monstropolis, metroville, 105);
            graph.AddEdge(monstropolis, naboo, 73);
            graph.AddEdge(metroville, naboo, 26);
            graph.AddEdge(naboo, narnia, 250);
            graph.AddEdge(narnia, metroville, 37);

            string[] input = { "Metroville", "Pandora" };
            int? cost = Graph<string>.BusinessTrip(graph, input);

            Assert.NotNull(cost);
            Assert.Equal(82, cost);
        }

        [Fact]
        public void BusinessTrip_ShouldReturnNull_WhenInvalidInput()
        {
            Graph<string> graph = new Graph<string>();

            Vertex<string> pandora = graph.AddVertex("Pandora");
            Vertex<string> arendelle = graph.AddVertex("Arendelle");
            Vertex<string> metroville = graph.AddVertex("Metroville");
            Vertex<string> monstropolis = graph.AddVertex("New Monstropolis");
            Vertex<string> naboo = graph.AddVertex("Naboo");
            Vertex<string> narnia = graph.AddVertex("Narnia");

            graph.AddEdge(pandora, arendelle, 150);
            graph.AddEdge(pandora, metroville, 82);
            graph.AddEdge(arendelle, metroville, 99);
            graph.AddEdge(arendelle, monstropolis, 42);
            graph.AddEdge(monstropolis, metroville, 105);
            graph.AddEdge(monstropolis, naboo, 73);
            graph.AddEdge(metroville, naboo, 26);
            graph.AddEdge(naboo, narnia, 250);
            graph.AddEdge(narnia, metroville, 37);

            string[] input = { "Naboo", "Pandora" };
            int? cost = Graph<string>.BusinessTrip(graph, input);

            Assert.Null(cost);
        }

        [Fact]
        public void BusinessTrip_ShouldReturnCorrectCost_WhenValidInput2()
        {

            Graph<string> graph = new Graph<string>();

            Vertex<string> pandora = graph.AddVertex("Pandora");
            Vertex<string> arendelle = graph.AddVertex("Arendelle");
            Vertex<string> metroville = graph.AddVertex("Metroville");
            Vertex<string> monstropolis = graph.AddVertex("New Monstropolis");
            Vertex<string> naboo = graph.AddVertex("Naboo");
            Vertex<string> narnia = graph.AddVertex("Narnia");

            graph.AddEdge(pandora, arendelle, 150);
            graph.AddEdge(pandora, metroville, 82);
            graph.AddEdge(arendelle, metroville, 99);
            graph.AddEdge(arendelle, monstropolis, 42);
            graph.AddEdge(monstropolis, metroville, 105);
            graph.AddEdge(monstropolis, naboo, 73);
            graph.AddEdge(metroville, naboo, 26);
            graph.AddEdge(naboo, narnia, 250);
            graph.AddEdge(narnia, metroville, 37);


            string[] input = { "Arendelle", "New Monstropolis", "Naboo" };
            int? cost = Graph<string>.BusinessTrip(graph, input);

            Assert.NotNull(cost);
            Assert.Equal(115, cost);
        }

        [Fact]
        public void BusinessTrip_ShouldReturnNull_WhenInvalidInput2()
        {


            Graph<string> graph = new Graph<string>();

            Vertex<string> pandora = graph.AddVertex("Pandora");
            Vertex<string> arendelle = graph.AddVertex("Arendelle");
            Vertex<string> metroville = graph.AddVertex("Metroville");
            Vertex<string> monstropolis = graph.AddVertex("New Monstropolis");
            Vertex<string> naboo = graph.AddVertex("Naboo");
            Vertex<string> narnia = graph.AddVertex("Narnia");

            graph.AddEdge(pandora, arendelle, 150);
            graph.AddEdge(pandora, metroville, 82);
            graph.AddEdge(arendelle, metroville, 99);
            graph.AddEdge(arendelle, monstropolis, 42);
            graph.AddEdge(monstropolis, metroville, 105);
            graph.AddEdge(monstropolis, naboo, 73);
            graph.AddEdge(metroville, naboo, 26);
            graph.AddEdge(naboo, narnia, 250);
            graph.AddEdge(narnia, metroville, 37);




            string[] input = { "Naboo", "Pandora" };
            int? cost = Graph<string>.BusinessTrip(graph, input);


            Assert.Null(cost);
        }

        [Fact]
        public void BusinessTrip_ShouldReturnNull_WhenOneCityNotFound()
        {


            Graph<string> graph = new Graph<string>();

            Vertex<string> pandora = graph.AddVertex("Pandora");
            Vertex<string> arendelle = graph.AddVertex("Arendelle");
            Vertex<string> metroville = graph.AddVertex("Metroville");
            Vertex<string> monstropolis = graph.AddVertex("New Monstropolis");
            Vertex<string> naboo = graph.AddVertex("Naboo");
            Vertex<string> narnia = graph.AddVertex("Narnia");

            graph.AddEdge(pandora, arendelle, 150);
            graph.AddEdge(pandora, metroville, 82);
            graph.AddEdge(arendelle, metroville, 99);
            graph.AddEdge(arendelle, monstropolis, 42);
            graph.AddEdge(monstropolis, metroville, 105);
            graph.AddEdge(monstropolis, naboo, 73);
            graph.AddEdge(metroville, naboo, 26);
            graph.AddEdge(naboo, narnia, 250);
            graph.AddEdge(narnia, metroville, 37);


            string[] input = { "Metroville", "Atlantis" };
            int? cost = Graph<string>.BusinessTrip(graph, input);


            Assert.Null(cost);
        }

        [Fact]
        public void BusinessTrip_ShouldReturnNull_WhenNoConnection()
        {

            Graph<string> graph = new Graph<string>();

            Vertex<string> pandora = graph.AddVertex("Pandora");
            Vertex<string> arendelle = graph.AddVertex("Arendelle");
            Vertex<string> metroville = graph.AddVertex("Metroville");
            Vertex<string> monstropolis = graph.AddVertex("New Monstropolis");
            Vertex<string> naboo = graph.AddVertex("Naboo");
            Vertex<string> narnia = graph.AddVertex("Narnia");

            graph.AddEdge(pandora, arendelle, 150);
            graph.AddEdge(pandora, metroville, 82);
            graph.AddEdge(arendelle, metroville, 99);
            graph.AddEdge(arendelle, monstropolis, 42);
            graph.AddEdge(monstropolis, metroville, 105);
            graph.AddEdge(monstropolis, naboo, 73);
            graph.AddEdge(metroville, naboo, 26);
            graph.AddEdge(naboo, narnia, 250);
            graph.AddEdge(narnia, metroville, 37);

            string[] input = { "Pandora", "Naboo" };
            int? cost = Graph<string>.BusinessTrip(graph, input);


            Assert.Null(cost);
        }
    }
}