using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace C_Classes
{
    class Book : Product
    {
        public string Genre;
        public Book(int no, string name, float price, int count, string genre):base(no,name,price,count)
        {
            Genre = genre;
        }
    }
}