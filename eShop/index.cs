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
    public partial class index : Form
    {
        OleDbConnection db = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=./shop.mdb");
        private static DataGridView table;
        string query;

        public index(string query = "")
        {
            InitializeComponent();
            table = this.dataGridView1;
            this.query = query;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            editProduct window = new editProduct();
            window.ShowDialog();
            this.Close();
        }

        private void index_Load(object sender, EventArgs e)
        {
            showProducts();
        }

        private void showProducts()
        {
            if (query == "")
                query = "SELECT * FROM products";

            db.Open();
            OleDbDataAdapter DBAdapter = new OleDbDataAdapter(query, db);
            DataTable dt = new DataTable();
            DBAdapter.Fill(dt);

            dataGridView1.DataSource = dt;

            db.Close();
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            query = "SELECT * FROM products";

            showProducts();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Hide();

            updateProduct page = new updateProduct();
            page.id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            page.title = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            page.description = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            page.amount = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            page.saleAmount = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            page.isForSale = page.saleAmount != "";
            page.image = dataGridView1.CurrentRow.Cells[5].Value.ToString();

            page.ShowDialog();
            this.Close();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            searchProduct window = new searchProduct();
            window.ShowDialog();
            this.Close();
        }
    }
}
