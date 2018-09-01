using NUnit.Framework;
using TechnicalTests;

namespace UnitTests
{
    [TestFixture]
    public class StackTests
    {
        public Stack<int> Stack;

        [SetUp]
        public void Init()
        {
            Stack = new Stack<int>();
        }

        [TestCase(10, 10)]
        public void WhenPushMoreElementsThanInitialStackCapacityShouldResizeStack(int elementsToAdd, int currentSize)
        {
            while (elementsToAdd > 0)
            {
                Stack.Push(elementsToAdd);
                --elementsToAdd;
            }

            Assert.AreEqual(currentSize, Stack.CurrentSize());
        }

        [TestCase(10, 1)]
        public void WhenPopAnElementFromStackShouldReturnTheLastIn(int elementsToAdd, int lastIn)
        {
            while (elementsToAdd > 0)
            {
                Stack.Push(elementsToAdd);
                --elementsToAdd;
            }

            Assert.AreEqual(lastIn, Stack.Pop());
        }

        [TestCase(10, 1)]
        public void WhenPeekAnElementFromStackShouldReturnTheLastIn(int elementsToAdd, int lastIn)
        {
            while (elementsToAdd > 0)
            {
                Stack.Push(elementsToAdd);
                --elementsToAdd;
            }

            Assert.AreEqual(lastIn, Stack.Peek());
        }

        [TestCase(10, 0)]
        public void WhenClearStackCurrentSizeShouldBeZero(int elementsToAdd, int expected)
        {
            while (elementsToAdd > 0)
            {
                Stack.Push(elementsToAdd);
                --elementsToAdd;
            }
            Stack.Clear();
            Assert.AreEqual(expected, Stack.CurrentSize());
        }

        //TODO:HG Add more unit test to cover exception when invalid operation or argument out of range
    }
}