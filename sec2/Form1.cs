using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sec2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar) {


                case 'A':
                case 'a':
                    TxtResult.Text = (Convert.ToInt32(TxtNum1.Text) + Convert.ToInt32(TxtNum2.Text)).ToString();
                    e.Handled = true;
                    break;
                case 'B':
                case 'b':
                    TxtResult.Text = (Convert.ToInt32(TxtNum1.Text) - Convert.ToInt32(TxtNum2.Text)).ToString();
                    e.Handled = true;
                    break;
                case 'M':
                case 'm':
                    TxtResult.Text = (Convert.ToInt32(TxtNum1.Text) * Convert.ToInt32(TxtNum2.Text)).ToString();
                    e.Handled = true;
                    break;
                case 'D':
                case 'd':
                    TxtResult.Text = (Convert.ToInt32(TxtNum1.Text) / Convert.ToInt32(TxtNum2.Text)).ToString();
                    e.Handled = true;
                    break;
                case 'C':
                case 'c':
                    TxtNum1.Clear();
                    TxtNum2.Clear();
                    TxtResult.Clear();
                    e.Handled = true;
                    break;
                case 'X':
                case 'x':
                    this.Close();
                    break;

            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
