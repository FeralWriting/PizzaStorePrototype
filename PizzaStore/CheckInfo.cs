using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaStore
{
    public partial class CheckInfo : Form
    {
        public CheckInfo()
        {
            InitializeComponent();
        }

        private void CheckInfo_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Checkout_information checkout_Information = new Checkout_information();
            checkout_Information.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Signup_login signup_login = new Signup_login();
            signup_login.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            AboutUs_CustomerService aboutUs_CustomerService = new AboutUs_CustomerService();
            aboutUs_CustomerService.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            AboutUs_CustomerService aboutUs_CustomerService = new AboutUs_CustomerService();
            aboutUs_CustomerService.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Settings settings = new Settings();
            settings.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Checkout_information checkout_Information = new Checkout_information();
            checkout_Information.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Confirmation confirmation = new Confirmation();
            confirmation.Show();
        }
    }
}
