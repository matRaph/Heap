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
            public int key { get; set; }
            public Element(object value, int priority)
            {
                this.value = value;
                this.key = priority;
            }

            public override string ToString(){
                return this.value.ToString() + ": " + this.key.ToString();
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
            return this.size == this.array.Length - 1;
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
            this.array[this.size + 1] = new Element(value, priority);
            this.size++;
            UpHeap();
        }

        public object RemoveMin()
        {
            if (IsEmpty())
            {
                throw new Empty_Heap_Exception("O heap está vazio");
            }
            object min = this.array[1].value;
            this.array[1] = this.array[this.size];
            this.array[this.size] = null;
            this.size--;
            DownHeap();
            return min;
        }
        public object Min()
        {
            return this.array[1];
        }

        private void UpHeap()
        {
            int i = this.size;
            while (i > 1 && this.array[i / 2].key > this.array[i].key)
            {
                Element aux = this.array[i / 2];
                this.array[i / 2] = this.array[i];
                this.array[i] = aux;
                i = i / 2;
            }
        }
        private void DownHeap()
        {
            int i = 1;
            while (2 * i <= this.size)
            {
                int j = 2 * i;
                if (j < this.size && this.array[j].key > this.array[j + 1].key)
                {
                    j++;
                }
                if (this.array[i].key > this.array[j].key)
                {
                    Element aux = this.array[i];
                    this.array[i] = this.array[j];
                    this.array[j] = aux;
                    i = j;
                }
                else
                {
                    break;
                }
            }
        }
        
        public void PrintArray()
        {
            for (int i = 1; i <= this.size; i++)
            {
                if (this.array[i] == null)
                {
                    Console.WriteLine("null");
                }
                else
                {
                    Console.WriteLine(this.array[i].value);
                }

            }
        }

    }
}
