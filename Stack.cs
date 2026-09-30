using System;
using System.Collections.Generic;
using System.Text;

namespace Week6Assignment6._2
{
    internal class TaskStack
    {
        private string[] task;
        private int top;
        public TaskStack(int size)
        {
            task = new string[size];
            top = -1;
        }
        public bool IsEmpty()
        {
            return top == -1;
        }
        public bool IsFull()
        {
            return top == task.Length - 1;
        }
        public void Push(string step)
        {
            if (IsFull())
            {
                Console.WriteLine("Stack Overflow");
                return;
            }
            top++;
            task[top] = step;
        }
        public string Pop()
        {
            if(IsEmpty())
            {
                Console.WriteLine("Stack Empty");
                return null;
            }
            string step = task[top];
            top--;
            return step;
        }
        public void Display()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack Empty");
                return;
            }
            for (int i = top; i >= 0; i--)
            {
                Console.WriteLine("* " +  task[i]);
            }
        }
    }
}
