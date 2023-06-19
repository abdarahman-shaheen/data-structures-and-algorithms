using data_structures_and_algorithms;

namespace TestBinarySearch
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int[] arr = { -131, -82, 0, 27, 42, 68, 179 };
            int key = 42;
            int result=Program.BinarySearch(arr,key);
            Assert.Equal(4,result);
        }
        [Fact]
        public void Test2()
        {
            int[] arr = { 4, 8, 15, 16, 23, 42 };
            int key = 15;
            int result = Program.BinarySearch(arr, key);
            Assert.Equal(2, result);
        }

    }
}