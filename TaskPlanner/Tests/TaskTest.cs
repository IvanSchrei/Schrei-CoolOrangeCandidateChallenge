using System;
using NUnit.Framework;

namespace coolOrange_Planner.Tests
{

    [TestFixture]
    public class TaskTest
    {
        [Test]
        public void Constructor_SetDefaultValues()
        {
            Task task = new Task("Testing");
            Assert.AreEqual("Testing", task.getName());
            Assert.AreEqual(5 , task.getPriority());
            Assert.AreEqual(0, task.getComplexity());

        }

        [Test]
        public void Sets_And_Gets_Correctly()
        {
            Task task = new Task("Testing");
            task.setPriority((int)Priority.MAX_PRIORITY);
            Assert.AreEqual((int)Priority.MAX_PRIORITY, task.getPriority());
            task.setComplexity(8);
            Assert.AreEqual(8, task.getComplexity());
        }

        [Test]
        public void CompareTo_Sorts_By_Priority()
        {
            Task highPriorityTask = new Task("High Priority");
            highPriorityTask.setPriority((int)Priority.MAX_PRIORITY);

            Task lowPriorityTask = new Task("Low Priority");
            lowPriorityTask.setPriority((int)Priority.MIN_PRIORITY);

            Assert.IsTrue(highPriorityTask.CompareTo(lowPriorityTask) < 0);
            Assert.IsTrue(lowPriorityTask.CompareTo(highPriorityTask) > 0);
        }

        [Test]
        public void ToString_Format()
        {
            Task task = new Task("Testing");
            task.setPriority((int)Priority.MED_PRIORITY);
            task.setComplexity(5);

            string expected = "Testing priority: 5 complexity: 5";
            Assert.AreEqual(expected, task.ToString());
        }

        [Test]
        public void Priority_Values_Are_Correct()
        {
            Assert.AreEqual(1, (int)Priority.MIN_PRIORITY);
            Assert.AreEqual(5, (int)Priority.MED_PRIORITY);
            Assert.AreEqual(10, (int)Priority.MAX_PRIORITY);
        }

        [Test]
        public void CompareTo_Handles_Null()
        {
            Task task = new Task("Testing");
            Assert.AreEqual(-1, task.CompareTo(null));
        }
    }
}