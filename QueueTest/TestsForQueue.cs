using System;
using System.Collections.Generic;
using System.Text;
using ImplementQueue;
using Xunit;

namespace QueueTest
{
    public class TestsForQueue
    {
        [Fact]
        public void ShouldReturnTheFrontData()
        {
            Queue testQueue = new Queue();
            testQueue.Enqueue(4);
            testQueue.Enqueue(5);
            testQueue.Enqueue(6);

            var result = testQueue.Front();

            Assert.Equal(4, result);

        }

        [Fact]
        public void ShouldReturnTheRearData()
        {
            Queue testQueue = new Queue();
            testQueue.Enqueue(4);
            testQueue.Enqueue(5);
            testQueue.Enqueue(6);

            var result = testQueue.Rear();
            Assert.Equal(6, result);
        }


        
    }
}
