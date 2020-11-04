using AssignmentTDD;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace StackClassTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Push_Integer()
        {
            // Arrange
            int[] startingStack = { 1, 2, 3, 4};
            int theInteger = 111;
            int[] expected = { 1, 2, 3, 4, 111};
            StackClass sc = new StackClass(startingStack);

            // Act
            //sc.Push(theInteger);

            // actual 1 2 3 111
            // expect 1 2 3 4   111

            // Assert
            int[] actual = sc.Stack;
            for (int i=0; i<expected.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i], "The stack is not pushed correctly");
            }
        }
    }
}
