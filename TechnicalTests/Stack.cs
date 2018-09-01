using System;

namespace TechnicalTests
{
    /// <summary>
    /// Represents a basic (LIFO) implementation,  last-in-first-out. Current implementation is not thread safe.
    /// For performance the stack will be generic
    /// </summary>
    public class Stack<T>
    {
        /// <summary>
        /// Array for the stack
        /// </summary>
        private T[] _currentArray;

        /// <summary>
        /// Current stack size
        /// </summary>
        private int _currentSize;

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:TechnicalTests.Stack" /> class.
        /// </summary>
        public Stack() : this(defaultCapacity: 10) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="Stack"/> class.
        /// </summary>
        /// <param name="defaultCapacity">The initial capacity.</param>
        /// <exception cref="System.ArgumentOutOfRangeException">initialCapacity</exception>
        public Stack(int defaultCapacity)
        {
            if (defaultCapacity < 0)//Array can not be less than 0
            {
                throw new ArgumentOutOfRangeException(nameof(defaultCapacity));
            }

            _currentArray = new T[defaultCapacity];//Initialize array with the initialCapacity
            _currentSize = 0;//Initialize size to zero as there is not elements yet
        }

        /// <summary>
        /// Returns the top element leaving it in place.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="System.InvalidOperationException">Empty stack</exception>
        public T Peek()
        {
            if (_currentSize == 0)
            {
                throw new InvalidOperationException("Empty stack");
            }

            return _currentArray[_currentSize - 1];
        }

        /// <summary>
        /// Returns and removes the top element.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="System.InvalidOperationException">Empty stack</exception>
        public T Pop()
        {
            if (_currentSize == 0)
            {
                throw new InvalidOperationException("Empty stack");
            }

            T item = _currentArray[--_currentSize];
            _currentArray[_currentSize] = default(T);
            return item;
        }

        /// <summary>
        /// Puts a new element on to the top of the stack.
        /// </summary>
        /// <param name="item">The item.</param>
        public void Push(T item)
        {
            if (_currentSize == _currentArray.Length)
            {   /*if stack has reached its maximum capacity, will double the  size
                 by multiplying the current size by two
                */
                T[] newArray = new T[2 * _currentArray.Length];
                const int sourceIndex = 0, destinationIndex = 0;
                Array.Copy(_currentArray, sourceIndex, newArray, destinationIndex, _currentSize);
                _currentArray = newArray;
            }
            _currentArray[_currentSize++] = item;
        }

        /// <summary>
        /// Current stack size.
        /// </summary>
        /// <returns>stack size</returns>
        public int CurrentSize() => _currentSize;

        /// <summary>
        ///  Clears the stack of all elements.
        /// </summary>
        public void Clear()
        {
            Array.Clear((Array)_currentArray, 0, _currentSize);
            _currentSize = 0;
        }
    }
}