using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
     class MyList<T>
    {
        T[] items;
        public MyList()
        {
            items = new T[0]; 
        }
        public void Add(T item)
        {
        items= new T[items.Length+1];
        T [] tempArray= items;
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            items[items.Length - 1] = item;
        }
}
