using System;
using System.Collections.Generic;
using System.Text;

namespace Stack_with_oop
{
    internal class Stiva
    { 
        private int stack_size_max;
        private int varf_stiva = -1;
        //This array needs a constructor for allocating memory, since the stack's dimension is not known 
        private int[] stack;

        public Stiva(int dimensiune)
        {
            stack_size_max = dimensiune;
            stack = new int[stack_size_max];
        }
        public void Push(int val) 
        {
            if (varf_stiva == stack_size_max - 1)
            {
                Console.WriteLine("Stack overflow");
            }
            else
            {
                varf_stiva++;
                stack[varf_stiva] = val;
            }
        }

        public void Pop()
        {
            if (varf_stiva == -1)
            {
                Console.WriteLine("Stiva e deja goala");
            }
            else
            {
                varf_stiva--;
            }
        }

        public void Peek()
        {
            if (varf_stiva == -1)
            {
                Console.WriteLine("Stiva e goala");
            }
            else
            {
                Console.WriteLine("Elementul din varful stivei este: " + stack[varf_stiva]);
            }
        }


    }
}
