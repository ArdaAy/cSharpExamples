using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_StackExample
{
    class Stack
    {
        private List<object> _stack;

        public Stack()
        {
            _stack = new List<object>();
        }

        public void PrintStack()
        {
            if(_stack.Count == 0)
            {
                //throw new InvalidOperationException();
                Console.WriteLine("Stack is empty");
                return;
            }
            Console.WriteLine("\nStack Printing");
            for(var i = _stack.Count - 1;i >= 0; i--)
            {
                Console.WriteLine(_stack[i]);
            }
        }

        public void Clear()
        {
            _stack.Clear();
        }

        public void Push(object obj)
        {
            if (obj == null)
                throw new InvalidOperationException();

            _stack.Add(obj);
        }

        public void Pop()
        {
            Console.WriteLine(_stack[_stack.Count - 1]);
            _stack.RemoveAt(_stack.Count - 1);
        }
    }
}
