using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace eShop
{
    public partial class editProduct : Form
    {
        OleDbConnection db = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Lenovo\Documents\shop.mdb");
        string query = "";
        string imagePath = "";

        public editProduct()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                saleAmountInput.Visible = true;
                salePriceLabel.Visible = true;
            }
            else
            {
                saleAmountInput.Visible = false;
                salePriceLabel.Visible = false;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("آیا از انصراف مطمئن هستید؟", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void browseImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog{
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp",
                Title = "Select an Image"
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string path = dialog.FileName;
                string root = AppDomain.CurrentDomain.BaseDirectory;
                string imagesFolder = Path.Combine(root, "images");

                if (! Directory.Exists(imagesFolder))
                {
                    Directory.CreateDirectory(imagesFolder);
                }

                string newFileName = Path.GetFileName(path);
                string destinationPath = Path.Combine(imagesFolder, newFileName);

                File.Copy(path, destinationPath, true);

                imagePath = destinationPath;
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (title.Text == "" || description.Text == "" || amount.Text == "" || (checkBox1.Checked && saleAmountInput.Text == "") || imagePath == "")
            {
                MessageBox.Show("پر کردن موارد ستاره دار الزامی است");
                return;
            }

            try
            {
                db.Open();

                query = "INSERT INTO products ([title], [description], [amount], [sale_amount], [image]) VALUES (@a, @b, @c, @d, @e)";
                OleDbCommand cmd = new OleDbCommand(query, db);

                cmd.Parameters.AddWithValue("@a", title.Text);
                cmd.Parameters.AddWithValue("@b", description.Text);
                cmd.Parameters.AddWithValue("@c", int.Parse(amount.Text));
                cmd.Parameters.AddWithValue("@d", checkBox1.Checked ? (object)int.Parse(saleAmountInput.Text) : DBNull.Value);
                cmd.Parameters.AddWithValue("@e", imagePath);

                int affected = cmd.ExecuteNonQuery();

                if (affected > 0)
                {
                    MessageBox.Show("محصول با موفقیت اضافه شد");

                    this.Hide();
                    index window = new index();
                    window.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("خطا در اتصال به دیتابیس");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                MessageBox.Show("خطای دیتابیس. دویاره تلاش کنید");
            }
            finally
            {
                db.Close();
            }
        }


    }
}

