using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5
{
    class Circular_Queue
    {
        #region Data Fields
        int[] arr;
        int tos;
        int pointerEnqueue;
        int pointerDequeue;
        int size;
        #endregion

        #region Ctor
        public Circular_Queue()
        {
            this.size = 10;
            tos = 0;
            pointerEnqueue = -1;
            pointerDequeue = 0;
            arr = new int[size];
        }
        public Circular_Queue(int _size)
        {
            size = _size;
            tos = 0;
            pointerEnqueue = -1;
            pointerDequeue = 0;
            arr = new int[size];
        }

        #endregion

        #region Circular Queue Functions
        public void Enqueue(int val)
        {
            if (IsFull())
            {
                pointerEnqueue = (pointerEnqueue + 1) % size;
                arr[pointerEnqueue] = val;
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

                tmp = arr[pointerDequeue];
                pointerDequeue = (pointerDequeue + 1) % size;
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
