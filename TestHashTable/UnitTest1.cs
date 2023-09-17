using data_structures_and_algorithms;

namespace TestHashTable

{
    public class UnitTest1
    {
        

        [Fact]
        public void TestHas()
        {
            // Arrange
            var hashtable = new Hashtable<string, int>(10);

            // Act
            hashtable.Set("Alice", 25);

            // Assert
            Assert.True(hashtable.Has("Alice"));
            Assert.False(hashtable.Has("Bob"));
        }

        [Fact]
        public void TestKeys()
        {
            // Arrange
            var hashtable = new Hashtable<string, int>(10);

            // Act
            hashtable.Set("Alice", 25);
            hashtable.Set("Bob", 30);

            // Assert
            var keys = hashtable.Keys();
            Assert.Contains("Alice", keys);
            Assert.Contains("Bob", keys);
            Assert.DoesNotContain("Eve", keys);
        }

        [Fact]
        public void TestHash()
        {
            // Arrange
            var hashtable = new Hashtable<string, int>(10);

            // Act
            int hash = hashtable.Hash("Alice");

            // Assert
            Assert.InRange(hash, 0, 9);
        }

        [Fact]
        public void Set_ShouldSetKeyAndValue()
        {
            var Hashtable = new Hashtable<string, int>(100);
            Hashtable.Set("Key1", 42);

            Assert.True(Hashtable.ContainsKey("Key1"));
            Assert.True(Hashtable.TryGetValue("Key1", out int value));
            Assert.Equal(42, value);
        }

        [Fact]
        public void Set_ShouldUpdateExistingKey()
        {
            var Hashtable = new Hashtable<string, int>(100);
            Hashtable.Set("Key1", 42);

            Hashtable.Set("Key1", 24);

            Assert.True(Hashtable.ContainsKey("Key1"));
            Assert.True(Hashtable.TryGetValue("Key1", out int value));
            Assert.Equal(24, value);
        }

        [Fact]
        public void GetHash_ShouldReturnNonNegativeHash()
        {
            var Hashtable = new Hashtable<string, int>(100);
            int hash = Hashtable.GetHash("TestKey");

            Assert.True(hash >= 0);
        }

        [Fact]
        public void TryGetValue_ShouldReturnTrueAndCorrectValueForExistingKey()
        {
            var Hashtable = new Hashtable<string, int>(100);
            Hashtable.Set("Key1", 42);

            bool result = Hashtable.TryGetValue("Key1", out int value);

            Assert.True(result);
            Assert.Equal(42, value);
        }

        [Fact]
        public void TryGetValue_ShouldReturnFalseForNonExistingKey()
        {
            var Hashtable = new Hashtable<string, int>(100);

            bool result = Hashtable.TryGetValue("NonExistentKey", out int value);

            Assert.False(result);
        }

        [Fact]
        public void ContainsKey_ShouldReturnTrueForExistingKey()
        {
            var Hashtable = new Hashtable<string, int>(100);
            Hashtable.Set("Key1", 42);

            bool result = Hashtable.ContainsKey("Key1");

            Assert.True(result);
        }

        [Fact]
        public void ContainsKey_ShouldReturnFalseForNonExistingKey()
        {
            var Hashtable = new Hashtable<string, int>(100);

            bool result = Hashtable.ContainsKey("NonExistentKey");

            Assert.False(result);
        }

        [Fact]
        public void FindFirstRepeatedWord_ShouldReturnFirstRepeatedWord()
        {
            var Hashtable = new Hashtable<string, int>(100);
            string input = "This is a test. This is only a test.";

            string repeatedWord = Hashtable.FindFirstRepeatedWord(input);

            Assert.Equal("This", repeatedWord);
        }

        [Fact]
        public void FindFirstRepeatedWord_ShouldReturnNullForNoRepeatedWords()
        {
            var Hashtable = new Hashtable<string, int>(100);
            string input = "No repeated words in this sentence.";

            string repeatedWord = Hashtable.FindFirstRepeatedWord(input);

            Assert.Null(repeatedWord);
        }

        [Fact]
        public void Keys_ShouldReturnAllKeys()
        {
            var Hashtable = new Hashtable<string, int>(100);
            Hashtable.Set("Key1", 42);
            Hashtable.Set("Key2", 24);

            var keys = Hashtable.Keys();

            Assert.Contains("Key1", keys);
            Assert.Contains("Key2", keys);
        }
    }
}