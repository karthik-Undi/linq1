using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq1
{
    class Sale
    {
        public int Sid { get; set; }
        public DateTime Sdate { get; set; }
        public Double Price { get; set; }
        public String Bname { get; set; }
        public Sale(int id, DateTime sdate, Double price, String bname)
        {
            this.Sid = id;
            this.Sdate = sdate;
            this.Price = price;
            this.Bname = bname;
        }
    }
}
