using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heap
{
    internal class Heap
    {
        internal class Element
        {
            public object value { get; set; }
            public int priority { get; set; }
            public Element(object value, int priority)
            {
                this.value = value;
                this.priority = priority;
            }

            public override string ToString(){
                return this.value.ToString() + ":" + this.priority.ToString();
            }
        }
        
        private Element[] array { get; set; }
        public int size { get; set; }
        private int lastElement { get; set; }
        public Heap(int lenght)
        {
            this.size = 0;
            this.array = new Element[lenght];
        }

        public bool IsEmpty()
        {
            return this.size == 0;
        }
        private bool IsFull()
        {
            return this.size == this.array.Length;
        }
        private void DoubleArray()
        {
            Element[] newArray = new Element[this.array.Length * 2];
            Array.Copy(this.array, newArray, this.array.Length);
            this.array = newArray;
        }
        public void Insert(object value, int priority)
        {
            if (IsFull())
            {
                DoubleArray();
            }
            this.size++;
            this.array[this.size] = new Element(value, priority);
            //UpHeap();
        }

        public object RemoveMin()
        {
            return 0;
        }
        public object Min()
        {
            return this.array[0];
        }

        private void UpHeap(int priority)
        {

        }
        private void DownHeap(int priority)
        {

        }
        private void Swap(int priority, int parent)
        {
            Element temp = this.array[priority];
            this.array[priority] = this.array[parent];
            this.array[parent] = temp;
        }
        
        public void Print()
        {
            for (int i = 0; i < this.size; i++)
            {
                Console.WriteLine(this.array[i].value);
            }
        }
    }
}
