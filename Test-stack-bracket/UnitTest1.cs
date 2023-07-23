using data_structures_and_algorithms;

namespace Test_stack_bracket
{
    public class UnitTest1
    {
        [Fact]
        public void TestValidBrackets()
        {
             
            string input = "{}()[]";

            
            bool isValid = Program.ValidatorBracket(input);

            
            Assert.True(isValid);
        }

        [Fact]
        public void TestInvalidBrackets()
        {
             
            string input = "{([)]}";

              
            bool isValid = Program.ValidatorBracket(input);

             
            Assert.False(isValid);
        }

        [Fact]
        public void TestEmptyInput()
        {
             
            string input = "";

              
            bool isValid = Program.ValidatorBracket(input);

             
            Assert.True(isValid); 
        }

        [Fact]
        public void TestSingleOpeningBracket()
        {
             
            string input = "[";

              
            bool isValid = Program.ValidatorBracket(input);

             
            Assert.False(isValid); 
        }

        [Fact]
        public void TestSingleClosingBracket()
        {
             
            string input = ")";

              
            bool isValid = Program.ValidatorBracket(input);

             
            Assert.False(isValid); 
        }

        [Fact]
        public void TestNestedBrackets()
        {
             
            string input = "{[()]}";

              
            bool isValid = Program.ValidatorBracket(input);

             
            Assert.True(isValid); 
        }

        [Fact]
        public void TestUnbalancedBrackets()
        {
             
            string input = "{[()]";

              
            bool isValid = Program.ValidatorBracket(input);

             
            Assert.False(isValid); 
        }
    }
}