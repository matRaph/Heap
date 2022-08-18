using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heap
{
    internal class Empty_Heap_Exception : Exception
    {
        public Empty_Heap_Exception(string message) : base(message) { }
    }
}
