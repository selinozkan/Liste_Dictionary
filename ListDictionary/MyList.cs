using System;
using System.Collections.Generic;
using System.Text;

namespace ListDictionary
{
    class MyList<T>
    {
        T[] items;

        public MyList()
        {
            items = new T[0];
        }
        public void EKLE(T item)
        {
            T[] Temparray = items;
            items = new T[items.Length+1];
            for (int i = 0; i <Temparray.Length; i++)
            {
                items[i] = Temparray[i];
            }
            items[items.Length - 1] = item;
        }
    }
}
