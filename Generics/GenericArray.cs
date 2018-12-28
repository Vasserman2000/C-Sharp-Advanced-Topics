using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class GenericArray<T>
    {
        public T[] array;

        public GenericArray(int size)
        {
            array = new T[size];
        }

        public T GetItem(int index)
        {
            return array[index];
        }

        public void SetItem (T value, int index)
        {
            array[index] = value;
        }
    }
}   
