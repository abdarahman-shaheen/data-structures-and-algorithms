using data_structures_and_algorithms;

namespace Sort_Array
{
    public class UnitTest1
    {
        [Fact]
        public void TestInsert()
        {
            int[] sorted = { 2, 4, 6, 8, 10 };
            int value = 5;

            Program.Insert(sorted, value);

            int[] expected = { 2, 4, 5, 6, 8 };
            Assert.Equal(expected, sorted);
        }

         [Fact]
    public void TestInsertionSort()
    {
        int[] input = { 8, 2, 5, 1 };
        int[] sorted = Program.InsertionSort(input);

        int[] expected = { 1, 2, 5, 8 };
        Assert.Equal(expected, sorted);
    }
    }
}