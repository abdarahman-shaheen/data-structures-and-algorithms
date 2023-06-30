
using data_structures_and_algorithms;

namespace LinkedList
{
    public class UnitTest1
    {
        [Fact]
        public void CheckEmptyLinkedList()
        {
            Linked_List linkedList = new Linked_List();
            Assert.Null(linkedList.Head);
            Assert.Null(linkedList.tail);

        }

        [Fact]
        public void InsertNodeToFirstLinkedList()
        { 
            Linked_List linkedList = new Linked_List();
            linkedList.InsertFirst(10);
            Assert.NotNull(linkedList.Head);
            Assert.NotNull(linkedList.tail);
            Assert.Equal(10, linkedList.Head.Item);
            Assert.Equal(10, linkedList.tail.Item);

        }
        [Fact]
        public void InsertNodeToHeadinLinkedList()
        {
            Linked_List linkedList = new Linked_List();
            linkedList.InsertFirst(10);
            linkedList.InsertFirst(20);
            linkedList.InsertFirst(30);
            Assert.Equal(30, linkedList.Head.Item);

        }
        [Fact]
        public void InsertMultiNodeinLinkedList()
        {
            Linked_List linkedList = new Linked_List();
            linkedList.InsertFirst(10);
            linkedList.InsertLast(20);
            linkedList.InsertPosition(1, 15);

            Assert.Equal(10, linkedList.Head.Item);
            Assert.Equal(15, linkedList.Head.Next.Item);
            Assert.Equal(20, linkedList.tail.Item);
        }
        [Fact]
        public void InsertlastNodeinLinkedList()
        {
            Linked_List linkedList = new Linked_List();
            linkedList.InsertFirst(10);
            linkedList.InsertLast(20);
            linkedList.InsertLast(30);
            Assert.Equal(10, linkedList.Head.Item);
            Assert.Equal(20, linkedList.Head.Next.Item);
            Assert.Equal(30, linkedList.tail.Item);
        }
        [Fact]
        public void InsertNodeinPostionInLinkedList()
        {
            Linked_List linkedList = new Linked_List();
            linkedList.InsertFirst(10);
            linkedList.InsertLast(20);
            linkedList.InsertLast(30);
            linkedList.InsertPosition(1, 50);
            Assert.Equal(10, linkedList.Head.Item);
            Assert.Equal(50, linkedList.Head.Next.Item);
            Assert.Equal(30, linkedList.tail.Item);
        }
        [Fact]
        public void SearcNodeinLinkedList()
        {
            Linked_List linkedList = new Linked_List();
            linkedList.InsertFirst(10);
            linkedList.InsertLast(20);
            linkedList.InsertPosition(1, 15);

            Assert.True(linkedList.SerchNode(15));

        }
        [Fact]
        public void SearchNodeValueDoesNotExist()
        {
            Linked_List linkedList = new Linked_List();
            linkedList.InsertFirst(10);
            linkedList.InsertLast(20);
            linkedList.InsertPosition(1, 15);

            Assert.False(linkedList.SerchNode(25));
        }
        [Fact]
        public void allValueInLinkedList()
        {
            Linked_List linkedList = new Linked_List();
            linkedList.InsertFirst(10);
            linkedList.InsertLast(20);
            linkedList.InsertPosition(1, 15);

            string expected = "Linked List :{10}=>{15}=>{20}=>NUll";
            Assert.Equal(expected, linkedList.PrintList());
        }




    }
}