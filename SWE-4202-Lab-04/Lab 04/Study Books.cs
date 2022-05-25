using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_04
{
    internal class Study_Books: Book
    {
        public int ISBN;
        public string genre;

        public string getInfo()
        {
            string info = Convert.ToString(id) + "\t" + title + "\t" + author + "\t" + ISBN + "\t" + Convert.ToString(quantity);
            return info;
            
    }
}
