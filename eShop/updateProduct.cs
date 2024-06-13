using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace eShop
{
    public partial class updateProduct : Form
    {
        public int id = 0;
        public string title = "xyz";
        public string description = "x";
        public string amount = "123";
        public string saleAmount = "44";
        public bool isForSale = true;
        public string image = @"C:\Users\Lenovo\Pictures\Screenshot (6).png";

        string query = "";
        OleDbConnection db = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=./shop.mdb");

        public updateProduct()
        {
            InitializeComponent();
        }

        private void updateProduct_Load(object sender, EventArgs e)
        {
            label1.Text = string.Format("ویرایش محصول #{0}", id);
            titleInput.Text = title;
            descriptionInput.Text = description;
            amountInput.Text = amount;
            saleAmountInput.Text = saleAmount;
            pictureBox1.Image = Image.FromFile(image);

            if (isForSale)
            {
                saleAmountInput.Visible = true;
                saleAmountLabel.Visible = true;
                checkBox1.Checked = true;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void browseImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog
            {
                // only this files can be selected by user...
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp",
                Title = "Select an Image"
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string path = dialog.FileName;
                string root = AppDomain.CurrentDomain.BaseDirectory;
                string imagesFolder = Path.Combine(root, "images");

                if (!Directory.Exists(imagesFolder))
                {
                    Directory.CreateDirectory(imagesFolder);
                }

                string newFileName = Path.GetFileName(path);
                string destinationPath = Path.Combine(imagesFolder, newFileName);

                File.Copy(path, destinationPath, true);

                pictureBox1.Image = Image.FromFile(destinationPath);
                image = destinationPath;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                saleAmountInput.Visible = true;
                saleAmountLabel.Visible = true;

            }
            else
            {
                saleAmountInput.Visible = false;
                saleAmountLabel.Visible = false;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (titleInput.Text == "" || descriptionInput.Text == "" || amountInput.Text == "" || (checkBox1.Checked && saleAmountInput.Text == "") || image == "")
            {
                MessageBox.Show("پر کردن موارد ستاره دار الزامی است");
                return;
            }

            try
            {
                db.Open();

                query = "UPDATE products SET [title] = @a, [description] = @b, [amount] = @c, [sale_amount] = @d, [image] = @e WHERE [id] = @id";
                OleDbCommand cmd = new OleDbCommand(query, db);

                cmd.Parameters.AddWithValue("@a", titleInput.Text);
                cmd.Parameters.AddWithValue("@b", descriptionInput.Text);
                cmd.Parameters.AddWithValue("@c", int.Parse(amountInput.Text));
                cmd.Parameters.AddWithValue("@d", checkBox1.Checked ? (object)int.Parse(saleAmountInput.Text) : DBNull.Value);
                cmd.Parameters.AddWithValue("@e", image);
                cmd.Parameters.AddWithValue("@id", id);

                int affected = cmd.ExecuteNonQuery();

                if (affected > 0)
                {
                    MessageBox.Show("محصول با موفقیت به‌روزرسانی شد");

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

        private void deleteButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("آیا از حذف این محصول مطمئن هستید؟ این عمل قابل برگشت نیست", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string query = "DELETE FROM products WHERE id = " + id;

                try
                {
                    // File.Delete(image);
                    // currently not working because of permission error :(

                    db.Open();

                    OleDbCommand cmd = new OleDbCommand(query, db);
                    int affected = cmd.ExecuteNonQuery();

                    if (affected > 0)
                    {
                        MessageBox.Show("محصول با موفقیت حذف شد");

                        this.Hide();
                        index window = new index();
                        window.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("محصول یافت نشد");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("حطا در حذف محصول: " + ex.Message);
                }
                finally
                {
                    db.Close();
                }
            }
        }

    }
}
