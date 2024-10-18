using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_1_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RedButton_Click(object sender, EventArgs e)
        {
            BackColor = Color.Red;
        }
       
        private void GreenButton_Click(object sender, EventArgs e)
        {
            BackColor = Color.Green;
        }

        private void BlueButton_Click(object sender, EventArgs e)
        {
            BackColor = Color.Blue;
        }

        private void YellowButton_Click(object sender, EventArgs e)
        {
            BackColor = Color.Yellow;
        }

        private void HellowButton_Click(object sender, EventArgs e)
        {
            label1.Text = "Привет!";
        }

        private void GoodBuyButton_Click(object sender, EventArgs e)
        {
            label1.Text = "До свидания!";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}