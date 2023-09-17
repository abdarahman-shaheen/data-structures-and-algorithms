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

    }
}