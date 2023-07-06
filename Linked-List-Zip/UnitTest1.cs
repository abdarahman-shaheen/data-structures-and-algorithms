using data_structures_and_algorithms;
using System.Collections.Generic;

namespace Linked_List_Zip
{
    public class UnitTest1
    {
        [Fact]
        public void zipTest1()
        {

            Linked_List l1 = new Linked_List();
            l1.InsertLast(1);
            l1.InsertLast(2);
            l1.InsertLast(3);

            Linked_List l2 = new Linked_List();
            l2.InsertLast(4);
            l2.InsertLast(5);
            l2.InsertLast(6);
            

            Linked_List List3 = Linked_List.zipList(l1, l2);

            string expected = "Linked List :{1}=>{4}=>{2}=>{5}=>{3}=>{6}=>NUll";
            Assert.Equal(expected, List3.PrintList());
        }
        [Fact]
        public void zipTest2()
        {

            Linked_List l1 = new Linked_List();
            l1.InsertLast(1);
            l1.InsertLast(2);
            l1.InsertLast(3);

            Linked_List l2 = new Linked_List();
            l2.InsertLast(4);
            l2.InsertLast(5);
            l2.InsertLast(6);
            l2.InsertLast(7);
            l2.InsertLast(8);

            Linked_List List3 = Linked_List.zipList(l1, l2);

            string expected = "Linked List :{1}=>{4}=>{2}=>{5}=>{3}=>{6}=>{7}=>{8}=>NUll";
            Assert.Equal(expected, List3.PrintList());
        }
        [Fact]
        public void zipTest3()
        {

            Linked_List l1 = new Linked_List();
            Linked_List l2 = new Linked_List();
            l2.InsertLast(4);
            l2.InsertLast(5);
            l2.InsertLast(6);
            l2.InsertLast(7);
            l2.InsertLast(8);
            Linked_List List3 = Linked_List.zipList(l1, l2);

            string expected = "Linked List :{4}=>{5}=>{6}=>{7}=>{8}=>NUll";
            Assert.Equal(expected, List3.PrintList());
        }
    }
}
