namespace WiredBrainCoffee.StackApp
{
    public class SimpleStack<T> // Always use T or start the generic type with T: TItem, TThing, etc. Read as "SimpleStack of T"
    {
        private readonly T[] _items; // Private read-only field
        private int _currentIndex = -1;
        public SimpleStack() => _items = new T[10];

        public int Count => _currentIndex + 1;

        public void Push(T item) => _items[++_currentIndex] = item; // Increments *BEFORE* the push, avoiding -1 error

        public T Pop() => _items[_currentIndex--]; // Decrements *AFTER* the pop
    }
}