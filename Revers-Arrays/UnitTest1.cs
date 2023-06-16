using data_structures_and_algorithms;

namespace Revers_Arrays
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int[] array = { 1, 2, 3 };
            int[] arrayNew= { 3,2,1 };
            int[] result = Program.Reverse(array);

            Assert.Equal(result, arrayNew);

        }
    }
}