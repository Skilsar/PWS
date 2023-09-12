using System.Collections.Generic;

namespace Lab1
{
    public class VsaSession
    {
        private Stack<int> stack ;

        public VsaSession() {
            stack = new Stack<int>();
        }

        public void Push(int value) {
            stack.Push(value);
        }

        public int Pop()
        {
            return stack.Count != 0 ? stack.Pop() : -1;
        }

        public int Peek(){
            return stack.Count != 0 ? stack.Peek():0;
        }
}
}