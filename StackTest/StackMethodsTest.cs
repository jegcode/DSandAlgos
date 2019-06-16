using ImplementStack;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace StackTest
{
    public class StackMethodsTest
    {
        [Fact]
        public void ShouldReturnAnegativeWhenStackIsEmpty()
        {
            //Arrange
            Stack testStack = new Stack(5);
           
            //Act
            var result = testStack.Peek();

            //Assert
            Assert.Equal(-1, result);
        }

        [Fact]
        public void ShouldReturnTheItemAtTop()
        {
            //Arrange
            Stack testStack = new Stack(5);
            for (int i = 0; i < 5; i++)
            {
                testStack.Push(i);
            }

            //Act
            var result = testStack.Peek();

            //Assert
            Assert.Equal(4, result);
        }

        [Fact]
        public void ShouldRemoveTheItemAtTop()
        {
            //Arrange
            Stack testStack = new Stack(5);
            for(int i = 0; i < 5; i++)
            {
                testStack.Push(i);
            }

            //Act
            var result = testStack.Pop();

            //Assert
            Assert.Equal(4, result);
        }

        [Fact]
        public void ShouldReturnTrueWhenStackIsEmpty()
        {
            //Arrange 
            Stack testStack = new Stack(5);
            var result = testStack.IsEmpty();
            Assert.True(result);
        }

        [Fact]
        public void ShouldReturnFalseWhenStackIsNotEmpty()
        {
            Stack testStack = new Stack(3);
            for(int i = 0; i < 3; i++)
            {
                testStack.Push(i);
            }

            var result = testStack.IsEmpty();
            Assert.False(result);
        }
    }
}
