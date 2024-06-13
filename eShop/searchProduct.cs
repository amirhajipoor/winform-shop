using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace eShop
{
    public partial class searchProduct : Form
    {
        OleDbConnection db = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=./shop.mdb");

        public searchProduct()
        {
            InitializeComponent();
        }


        private void searchButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(keyword.Text))
            {
                MessageBox.Show("لطفا عبارت جستجو را وارد کنید");
                return;
            }

            string query = "SELECT * FROM products WHERE (1=1)";

            if (startWithKeyword.Checked)
            {
                query += string.Format(" AND (title LIKE '{0}%' OR description LIKE '{0}%')", keyword.Text);
            }
            else
            {
                query += string.Format(" AND (title LIKE '%{0}%' OR description LIKE '%{0}%')", keyword.Text);
            }

            if (uppercase.Checked)
            {
                query += " AND StrConv(title, 3) = title;";
            }

            if (lowercase.Checked)
            {
                query += " AND title = LCASE(title)";
            }

            index page = new index(query);
            page.Show();
        }

    }
}
