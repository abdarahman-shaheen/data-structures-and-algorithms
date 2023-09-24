namespace HashTable_LeftJoin
{
    public class UnitTest1
    {
        [Fact]
        public void LeftJoin_WithValidInput_ReturnsCorrectResult()
        {
            // Arrange
            Dictionary<string, string> synonymsHashTable = new Dictionary<string, string>
        {
            { "diligent", "employed" },
            { "fond", "enamored" },
            { "guide", "usher" },
            { "outfit", "garb" },
            { "wrath", "anger" }
        };

            Dictionary<string, string> antonymsHashTable = new Dictionary<string, string>
        {
            { "diligent", "idle" },
            { "fond", "averse" },
            { "guide", "follow" },
            { "flow", "jam" },
            { "wrath", "delight" }
        };

            List<List<string>> expected = new List<List<string>>
        {
            new List<string> { "diligent", "employed", "idle" },
            new List<string> { "fond", "enamored", "averse" },
            new List<string> { "guide", "usher", "follow" },
            new List<string> { "outfit", "garb", null },
            new List<string> { "wrath", "anger", "delight" }
        };

            // Act
            List<List<string>> result = LeftJoin(synonymsHashTable, antonymsHashTable);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void LeftJoin_WithEmptyInput_ReturnsEmptyResult()
        {
            // Arrange
            Dictionary<string, string> synonymsHashTable = new Dictionary<string, string>();
            Dictionary<string, string> antonymsHashTable = new Dictionary<string, string>();

            List<List<string>> expected = new List<List<string>>();

            // Act
            List<List<string>> result = LeftJoin(synonymsHashTable, antonymsHashTable);

            // Assert
            Assert.Equal(expected, result);
        }

        public List<List<string>> LeftJoin(Dictionary<string, string> synonyms, Dictionary<string, string> antonyms)
        {
            List<List<string>> result = new List<List<string>>();

            foreach (var key in synonyms.Keys)
            {
                string synonymValue = synonyms[key];
                string antonymValue = antonyms.ContainsKey(key) ? antonyms[key] : null;

                List<string> row = new List<string> { key, synonymValue, antonymValue };
                result.Add(row);
            }

            return result;
        }
    }
}
