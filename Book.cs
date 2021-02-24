using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq1
{
    class Book
    {
        public int Bid { get; set; }
        public String Bname { get; set; }
        public String Author { get; set; }
        public Book(int Bid,String Bname,String Author)
        {
            this.Bid = Bid;
            this.Bname = Bname;
            this.Author = Author;
        }
    }
}
