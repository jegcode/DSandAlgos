using LinkedListProject;
using System;
using System.Text;
using Xunit;
using Xunit.Abstractions;


namespace LinkedListTest
{
    public class LinkedListTest
    {
        private readonly ITestOutputHelper output;

        public LinkedListTest(ITestOutputHelper output)
        {
            this.output = output;
        }

        [Fact]
        public void ShouldCreateANode() {

            //Arrange
            int data = 3;

            //Act 
            Node n = new Node(data);
            
            //Assert
            Assert.IsType<Node>(n);
            Assert.Equal(3, n.data);
            Assert.Null(n.next);
        }

        [Fact]
        public void ShouldPrintListIsEmpty()
        {
            //Arrange
            LinkedList llist = new LinkedList();

            //Act
            llist.ListItems();

            //Assert
           Assert.Equal("The list is empty", llist.message);

        }

       

    }
}
