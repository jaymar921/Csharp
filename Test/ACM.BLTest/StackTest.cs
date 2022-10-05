using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL.Generics;
using ACM.BL;

namespace ACM.BLTest
{

    [TestClass]
    public class StackTest
    {
        public TestContext TestContext { get; set; }

       

        [TestMethod]
        public void CheckIncreaseSize()
        {
            var stack = new Stack<Customer>();

            for(int i = 0; i < 20; i++)
            {
                stack.Push(new Customer { LastName = "A", FirstName = "B" });
            }
            
            

            int expected = 20;
            int actual = stack.Count();
           

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckPeek()
        {
            var stack = new Stack<int>();

            for (int i = 0; i < 20; i++)
            {
                stack.Push(i);
            }



            int expected = 19;
            int actual = stack.Peek();


            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckPopPeek()
        {
            var stack = new Stack<int>();

            for (int i = 0; i < 20; i++)
            {
                stack.Push(i);
            }

            stack.Pop();
            stack.Pop();


            int expected = 17;
            int actual = stack.Peek();


            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckPushClearPeek()
        {
            var stack = new Stack<int>();

            for (int i = 0; i < 20; i++)
            {
                stack.Push(i);
            }
            TestContext.WriteLine($"Stack Items: {stack.Count()}");
            stack.Clear();
            TestContext.WriteLine($"Cleared Stack");
            TestContext.WriteLine($"Stack Items: {stack.Count()}");

            int expected = 0;
            int actual = stack.Peek();


            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckPushClearPeekPushPeek()
        {
            var stack = new Stack<int>();

            for (int i = 0; i < 20; i++)
            {
                stack.Push(i);
            }
            TestContext.WriteLine($"Stack Items: {stack.Count()}");
            stack.Clear();
            TestContext.WriteLine($"Cleared Stack");
            TestContext.WriteLine($"Stack Items: {stack.Count()}");

            for (int i = 100; i < 122; i++)
            {
                stack.Push(i);
            }

            TestContext.WriteLine($"Pushed Items to Stack");
            TestContext.WriteLine($"Stack Items: {stack.Count()}");

            int expected = 121;
            int actual = stack.Peek();


            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [Timeout(300)]
        public void CheckPush2MillionItems()
        {
            var stack = new Stack<int>();

            for (int i = 0; i < 2_000_000; i++)
            {
                stack.Push(i);
            }

            TestContext.WriteLine($"Stack Items: {stack.Count()}");

            int expected = 1_999_999;
            int actual = stack.Peek();


            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [Timeout(300)]
        public void CheckPush2MillionItemsClearPeek()
        {
            var stack = new Stack<int>();

            for (int i = 0; i < 2_000_000; i++)
            {
                stack.Push(i);
            }

            TestContext.WriteLine($"Stack Items: {stack.Count()}");
            stack.Clear();
            TestContext.WriteLine($"Cleared Stack");
            TestContext.WriteLine($"Stack Items: {stack.Count()}");

            int expected = 0;
            int actual = stack.Peek();


            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [Timeout(1000)]
        public void CheckPush5MillionItemsClearPeek()
        {
            var stack = new Stack<int>();

            for (int i = 0; i < 5_000_000; i++)
            {
                stack.Push(i);
            }

            TestContext.WriteLine($"Stack Items: {stack.Count()}");
            stack.Clear();
            TestContext.WriteLine($"Cleared Stack");
            TestContext.WriteLine($"Stack Items: {stack.Count()}");

            int expected = 0;
            int actual = stack.Peek();


            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [Timeout(5000)]
        public void CheckPush25MillionItemsClearPeek()
        {
            var stack = new Stack<int>();

            for (int i = 0; i < 25_000_000; i++)
            {
                stack.Push(i);
            }

            TestContext.WriteLine($"Stack Items: {stack.Count()}");
            stack.Clear();
            TestContext.WriteLine($"Cleared Stack");
            TestContext.WriteLine($"Stack Items: {stack.Count()}");

            int expected = 0;
            int actual = stack.Peek();


            Assert.AreEqual(expected, actual);
        }

    }
}
