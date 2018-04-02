using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class Stack
    {
        public Stack<object> StackSource = new Stack<object>();

        public void Push(object obj)
        {
            if (obj != null)
                StackSource.Push(obj);
        }

        public  object Pop()
        {
            var obj = StackSource.Pop();
            if (obj != null)
                return obj;
            else
                return "Nothing in stack";
        }

        public void Clear()
        {
            StackSource.Clear();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
        }
    }
}
