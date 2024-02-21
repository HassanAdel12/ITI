using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5
{
    class Queue
    {
        #region Data Fields
        int[] arr;
        int tos;
        int size;
        #endregion

        #region Ctor
        public Queue()
        {
            this.size = 10;
            tos = 0;
            arr = new int[size];
        }
        public Queue(int _size)
        {
            size = _size;
            tos = 0;
            arr = new int[size];
        }

        #endregion

        #region queue Functions
        public void Enqueue(int val)
        {
            if (IsFull())
            {
                arr[tos] = val;
                tos++;
            }
            else
            {
                Console.WriteLine("Queue is FULL");
            }
        }

        public int Dequeue()
        {
            int tmp;
            if (IsEmpty())
            {
                
                tmp = arr[0];
                for (int i = 1; i < tos; i++)
                {
                    arr[i - 1] = arr[i];
                }
                tos--;
                return tmp;
            }
            else
            {
                Console.WriteLine("Queue is EMPTY");
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
