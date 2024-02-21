using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5
{
    class Stack
    {
        #region Data Fields
        int[] arr;
        int tos;
        int size;
        #endregion

        #region Ctor
        public Stack()
        {
            this.size = 10;
            tos = 0;
            arr = new int[size];
        }
        public Stack(int _size)
        {
            size = _size;
            tos = 0;
            arr = new int[size];
        }

        #endregion

        #region Stack Functions
        public void Push(int val)
        {
            if (IsFull())
            {
                arr[tos] = val;
                tos++;
            }
            else
            {
                Console.WriteLine("Stack is FULL");
            }
        }

        public int Pop()
        {
            int tmp;
            if (IsEmpty())
            {
                tos--;
                tmp = arr[tos];
                return tmp;
            }
            else
            {
                Console.WriteLine("Stack is EMPTY");
                return -123456;
             
            }
        }

        public bool IsFull()
        {
            return tos != size;
        }

        public bool IsEmpty()
        {
            return tos != 0;
        }
        #endregion
    }
}
