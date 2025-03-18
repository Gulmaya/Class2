using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Classes
{
    class Product
    {
        public int No;
        public string Name;
        public float Price;
        public int Count;
        public Product(int no, string name, float price, int count )
        {
            No = no;
            Name = name;
            Price = price;
            Count = count;
        }
    }
}