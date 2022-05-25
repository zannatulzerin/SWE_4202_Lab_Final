using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_04
{
    internal class Research_Article: Book
    {
        public int DOI;
        public int published_date;
        public string type;
        
        public string getInfo()
        {
            string info = Convert.ToString(id) + "\t" + title + "\t" + author + "\t" + DOI + "\t" + Convert.ToString(published_date) + type;
            return info;
        }
    }
}
