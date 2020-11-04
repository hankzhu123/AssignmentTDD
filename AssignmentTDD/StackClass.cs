using System;
using System.Collections;

namespace AssignmentTDD
{
    public class StackClass
    {
        private int[] m_stack;

        private StackClass() { }


        // missing constructor here
        public StackClass(int[] stack)
        {
            m_stack = stack;
        }


        public int[] Stack
        {
            get { return m_stack; }
        }

        // missing a push fucntion here

        public void Pop()
        {
            if (m_stack.Length == 0)
            {
                throw new ArgumentOutOfRangeException("This is an empty stack");
            }

            int[] newS = new int[m_stack.Length - 1];

            for (int i = 0; i < m_stack.Length-1; i++)
            {
                newS[i] = m_stack[i];
            }

            m_stack = newS;

        }

        public void Peek()
        {
            if (m_stack.Length == 0)
            {
                throw new ArgumentOutOfRangeException("This is an empty stack");
            }

            Console.WriteLine("Top of the Stack is: ", m_stack[m_stack.Length]);

        }


        public static void Main()
        {
            int[] newStack = { 1, 2, 3, 4 };
            StackClass sc = new StackClass(newStack);

            sc.Pop();
            //sc.Push(100);

            foreach (int i in sc.Stack)
            {
                Console.WriteLine(i);
            }
        }
    }
}
