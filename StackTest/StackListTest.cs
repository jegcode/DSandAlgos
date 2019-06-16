using ImplementStack;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit; 

namespace StackTest
{
    public class StackListTest
    {
        [Fact] 
        public void ShouldPushAnElementToTheStack()
        {
            StackList testStackList = new StackList();
            testStackList.Push(3);
            Assert.Equal("3 pushed to the stack", testStackList.message);        
        }

        [Fact]
        public void ShouldReturnIntMinValueIfStackIsEmpty()
        {
            StackList testStackList = new StackList();
            var result = testStackList.Pop();
            Assert.Equal(int.MinValue, result);
        }

        [Fact]
        public void ShouldReturnTheTopItem()
        {
            StackList testStackList = new StackList();
            testStackList.Push(2);
            testStackList.Push(3);
            var result = testStackList.Peek();
            Assert.Equal(3, result);
        }

        [Fact]
        public void ShouldReturnTrueIfStackIsEmpty()
        {
            StackList testStackList = new StackList();
            var result = testStackList.IsEmpty();
            Assert.True(result);
        }

        [Fact]
        public void ShouldReturnFalseIfStackIsEmpty()
        {
            StackList testStackList = new StackList();
            testStackList.Push(5);
            var result = testStackList.IsEmpty();
            Assert.False(result);
        }

    }
}
