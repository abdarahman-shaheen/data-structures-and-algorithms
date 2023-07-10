using data_structures_and_algorithms;

namespace LinkedList_palindrome
{
    public class UnitTest1
    {
        [Fact]
        public void LinkedListPalindrom()
        {
            Linked_List l4 = new Linked_List();
            l4.InsertFirstString("m");
            l4.InsertFirstString("o");
            l4.InsertFirstString("k");
            l4.InsertFirstString("k");
            l4.InsertFirstString("o");
            l4.InsertFirstString("m");
            Console.WriteLine();
            Assert.True(Linked_List.LinkedPindromd(l4));
        }
        [Fact]
        public void LinkedListNotPalindrom()
        {
            Linked_List l4 = new Linked_List();
            l4.InsertFirstString("m");
            l4.InsertFirstString("o");
            l4.InsertFirstString("k");
            l4.InsertFirstString("k");
            l4.InsertFirstString("o");
            l4.InsertFirstString("v");
            Console.WriteLine();
            Assert.False(Linked_List.LinkedPindromd(l4));
        }
        [Fact]
        public void LinkedListNotPalindrom2()
        {
            Linked_List l4 = new Linked_List();
            l4.InsertFirstString("e");
            l4.InsertFirstString("s");
            l4.InsertFirstString("u");
            l4.InsertFirstString("o");
            l4.InsertFirstString("h");

            Console.WriteLine();
            Assert.False(Linked_List.LinkedPindromd(l4));
        }
    }
    
}
