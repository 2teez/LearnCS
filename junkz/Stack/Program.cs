
using System;

namespace Stack
{
    internal class Program
    {
        public static void Main()
        {
            Console.WriteLine("Start Here!");
            var numbers = new MyStack<int>(4);
            //numbers.Pop();
            numbers.Push(2);
            numbers.Push(5);
            numbers.Push(21);
            numbers.Push(15);
            numbers.Say();
            numbers.Pop();
            numbers.Say();
            MyStack<string> names = new(3);
            //names.Peek(1);
            names.Push("Perl");
            names.Push(".Net");
            names.Peek(2);
            Console.WriteLine(names.Pop());
            names.Push("Elixir");
            names.Say();
        }
    }


    public class MyStack<T>(int size = 10)
    {
        private readonly T[] _array = new T[size];
        private int idx = default;
        public bool Push(T value)
        {
            if (idx == _array.Length)
                return false;
            _array[idx] = value;
            idx += 1;
            return true;
        }

        public T Pop()
        {
            if (idx == 0)
                throw new InvalidOperationException("Can't remove item from an empty stack");
            idx--;
            return _array[idx];
        }

        public void Peek(int index = 1)
        {
            if (index > idx || index < 0)
            {
                throw new InvalidOperationException("can't check item in non-existence index.");
            }
            Console.WriteLine(_array[index - 1]);
        }
        public void Say()
        {
            Console.WriteLine(idx <= 1 ? string.Join(string.Empty, _array) :
                string.Join(", ", _array[..idx]));
        }
    }

}
