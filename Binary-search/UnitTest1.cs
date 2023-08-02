using data_structures_and_algorithms;

namespace Binary_search
{
    public class UnitTest1
    {
        [Fact]
        public void CanInstantiateEmptyTree()
        {
              
            BinarySearchTree<int> binarySearchTree = new BinarySearchTree<int>();
            Assert.Null(binarySearchTree.Root);
        }

        [Fact]
        public void CanInstantiateTreeWithSingleRootNode()
        {
              
            BinarySearchTree<int> binarySearchTree = new BinarySearchTree<int>();
            int rootValue = 50;

            
            binarySearchTree.Add(rootValue);

           
            Assert.NotNull(binarySearchTree.Root);
            Assert.Equal(rootValue, binarySearchTree.Root.Value);
            Assert.Null(binarySearchTree.Root.Left);
            Assert.Null(binarySearchTree.Root.Right);
        }

        [Fact]
        public void CanAddLeftAndRightChildToNode()
        {
              
            BinarySearchTree<int> binarySearchTree = new BinarySearchTree<int>();
            int rootValue = 50;
            int leftChildValue = 30;
            int rightChildValue = 70;

            
            binarySearchTree.Add(rootValue);
            binarySearchTree.Add(leftChildValue);
            binarySearchTree.Add(rightChildValue);

           
            Assert.NotNull(binarySearchTree.Root.Left);
            Assert.NotNull(binarySearchTree.Root.Right);
            Assert.Equal(leftChildValue, binarySearchTree.Root.Left.Value);
            Assert.Equal(rightChildValue, binarySearchTree.Root.Right.Value);
        }

        [Fact]
        public void CanReturnCollectionFromPreOrderTraversal()
        {
              
            BinarySearchTree<int> binarySearchTree = new BinarySearchTree<int>();
            binarySearchTree.Add(50);
            binarySearchTree.Add(30);
            binarySearchTree.Add(70);
            binarySearchTree.Add(20);
            binarySearchTree.Add(40);
            binarySearchTree.Add(60);
            binarySearchTree.Add(80);

           
            var result = binarySearchTree.PreOrderTravarsel();

            
            int[] expected = new int[] { 50, 30, 20, 40, 70, 60, 80 };
            Assert.Equal(expected, result);
        }

        [Fact]
        public void CanReturnCollectionFromInOrderTraversal()
        {
              
            BinarySearchTree<int> binarySearchTree = new BinarySearchTree<int>();
            binarySearchTree.Add(50);
            binarySearchTree.Add(30);
            binarySearchTree.Add(70);
            binarySearchTree.Add(20);
            binarySearchTree.Add(40);
            binarySearchTree.Add(60);
            binarySearchTree.Add(80);

           
            var result = binarySearchTree.InorderTraversal();

            
            int[] expected = new int[] { 20, 30, 40, 50, 60, 70, 80 };
            Assert.Equal(expected, result);
        }

        [Fact]
        public void CanReturnCollectionFromPostOrderTraversal()
        {
              
            BinarySearchTree<int> binarySearchTree = new BinarySearchTree<int>();
            binarySearchTree.Add(50);
            binarySearchTree.Add(30);
            binarySearchTree.Add(70);
            binarySearchTree.Add(20);
            binarySearchTree.Add(40);
            binarySearchTree.Add(60);
            binarySearchTree.Add(80);

            
            var result = binarySearchTree.PostorderTraversal();

          
            int[] expected = new int[] { 20, 40, 30, 60, 80, 70, 50 };
            Assert.Equal(expected, result);
        }

        [Fact]
        public void ContainsReturnsTrueForExistingNodeValue()
        {
              
            BinarySearchTree<int> binarySearchTree = new BinarySearchTree<int>();
            binarySearchTree.Add(50);
            binarySearchTree.Add(30);
            binarySearchTree.Add(70);
            binarySearchTree.Add(20);
            binarySearchTree.Add(40);
            binarySearchTree.Add(60);
            binarySearchTree.Add(80);

            
            bool result = binarySearchTree.Contains(40);

       
            Assert.True(result);
        }

        [Fact]
        public void ContainsReturnsFalseForNonExistingNodeValue()
        {
              
            BinarySearchTree<int> binarySearchTree = new BinarySearchTree<int>();
            binarySearchTree.Add(50);
            binarySearchTree.Add(30);
            binarySearchTree.Add(70);
            binarySearchTree.Add(20);
            binarySearchTree.Add(40);
            binarySearchTree.Add(60);
            binarySearchTree.Add(80);

            
            bool result = binarySearchTree.Contains(90);

            
            Assert.False(result);
        }
        [Fact]
        public void MaximumValue()
        {
            // Arrange
            BinarySearchTree<int> binarySeartchTree = new BinarySearchTree<int>();

            binarySeartchTree.Add(20);
            binarySeartchTree.Add(30);
            binarySeartchTree.Add(50);
            binarySeartchTree.Add(25);
            binarySeartchTree.Add(40);
            binarySeartchTree.Add(60);
            binarySeartchTree.Add(80);

            // Act
            var result = binarySeartchTree.FindMaximumValue();

            // Assert
            Assert.Equal(80, result);
        }


    }
}