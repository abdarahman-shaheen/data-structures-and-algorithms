using data_structures_and_algorithms;
using static data_structures_and_algorithms.TreeHashMap;

namespace HashMapTree
{
    public class UnitTest1
    {
        [Fact]
        public void FindCommonUsingHashMap_ShouldFindCommonNodes()
        {


            NodeHash root1 = null;
            root1 = TreeHashMap.insert(root1, 5);
            root1 = TreeHashMap.insert(root1, 1);
            root1 = TreeHashMap.insert(root1, 10);
            root1 = TreeHashMap.insert(root1, 0);
            root1 = TreeHashMap.insert(root1, 4);
            root1 = TreeHashMap.insert(root1, 7);
            root1 = TreeHashMap.insert(root1, 9);

            NodeHash root2 = null;
            root2 = TreeHashMap.insert(root2, 10);
            root2 = TreeHashMap.insert(root2, 7);
            root2 = TreeHashMap.insert(root2, 20);
            root2 = TreeHashMap.insert(root2, 4);
            root2 = TreeHashMap.insert(root2, 9);


            List<int> expectedCommonNodes = new List<int> { 10, 7, 4, 9 };


            List<int> actualCommonNodes = FindCommonUsingHashMap(root1, root2);

            Assert.Equal(expectedCommonNodes, actualCommonNodes);
        }

        [Fact]
        public void Insert_ShouldInsertNodeCorrectly()
        {

            NodeHash root = null;
            root = insert(root, 5);

            NodeHash newNode = insert(root, 3);

            Assert.Equal(5, newNode.key);
            Assert.NotNull(newNode.left);
            Assert.Null(newNode.right);
        }



        [Fact]
        public void FindCommonUsingHashMap_EmptyTrees_ShouldReturnEmptyList()
        {

            NodeHash root1 = null;
            NodeHash root2 = null;



            List<int> actualCommonNodes = FindCommonUsingHashMap(root1, root2);

            Assert.Empty(actualCommonNodes);
        }
    }
}
