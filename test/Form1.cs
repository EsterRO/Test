using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
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

        private void result_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (comboBox1.ValueMember)
            {
                case "1":
                    result.Text = (Convert.ToInt64(textBox1.Text) + Convert.ToInt64(textBox2)).ToString();

                    break;
                        case "2":
                    result.Text = (Convert.ToInt64(textBox1.Text) - Convert.ToInt64(textBox2)).ToString();
                    break;
                case "4":
                    result.Text = (Convert.ToInt64(textBox1.Text) * Convert.ToInt64(textBox2)).ToString();
                    break;
                case "5":
                    result.Text = (Convert.ToInt64(textBox1.Text) / Convert.ToInt64(textBox2)).ToString();
                    break;
            }              
        }
    }
}
