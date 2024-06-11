using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eShop
{
    public partial class loginPage : Form
    {
        public string username = "09123456789";
        public string password = "password";

        public loginPage()
        {
            InitializeComponent();
        }

        private void loginPage_Load(object sender, EventArgs e)
        {
            //
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (phoneNumberInput.Text == username && passwordInput.Text == password)
            {
                this.Hide();

                index page = new index();
                page.ShowDialog(); 

                this.Close();
            }
            else
            {
                MessageBox.Show("شماره موبایل یا رمز عبور اشتباه است");
            }
        }

    }
}
