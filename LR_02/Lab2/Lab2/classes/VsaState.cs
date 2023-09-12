using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab2.classes
{
    public static class VsaState
    {
        private static Stack<int> stack;
        private static int result;

        static VsaState()
        {
            stack = new Stack<int>();
            result = 0;
        }

        public static ResultData GetResult() { 
        
            return new ResultData() { Result = result + Peek()};
        }

        public static void SetResult(int value)
        {
            result = value; 
        }

        public static void Push(int value)
        {
            stack.Push(value);
        }

        public static  int Pop()
        {
            return stack.Count != 0 ? stack.Pop() : -1;
        }

        public static int Peek()
        {
            return stack.Count != 0 ? stack.Peek() : 0;
        }
    }
}