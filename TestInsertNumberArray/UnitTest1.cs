using data_structures_and_algorithms;

namespace TestInsertNumberArray
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int[] array = { 1, 2, 3 };
            int Num = 5;
            int[] NewArray = { 1, 5, 2, 3 };
            int[] result = Program.InsertShiftArray(array, Num);

            Assert.Equal(NewArray, result);
        }
    }
}