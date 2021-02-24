using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;

namespace linq1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Book> BookList = new List<Book>();
            List<Sale> SalesList = new List<Sale>();
            BookList.Add(new Book(11, "book1", "author1"));
            BookList.Add(new Book(22, "book2", "author2"));
            BookList.Add(new Book(33, "book3", "author3"));
            BookList.Add(new Book(44, "book4", "author4"));

            SalesList.Add(new Sale(111, DateTime.Now, 1000, "book1"));
            SalesList.Add(new Sale(222, DateTime.Now, 2000, "book1"));
            SalesList.Add(new Sale(333, DateTime.Now, 3000, "book2"));
            SalesList.Add(new Sale(444, DateTime.Now, 4000, "book2"));
            SalesList.Add(new Sale(555, DateTime.Now, 5000, "book4"));
            SalesList.Add(new Sale(666, DateTime.Now, 6000, "book4"));

            //dataGridView1.DataSource = BookList;

            var joinedData = from book in BookList
                             join sale in SalesList on book.Bname equals sale.Bname 
                             select new {
                                 BookID=book.Bid,
                                 Bookname=book.Bname,
                                 Author=book.Author,
                                 salesid=sale.Sid,
                                 Sale_Date=sale.Sdate,
                                 Price=sale.Price
                             } ;

            dataGridView1.DataSource = joinedData.ToList();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
