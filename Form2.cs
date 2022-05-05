using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFirstForm
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void labelName_Click(object sender, EventArgs e)
        {

        }

        private void labelEmail_Click(object sender, EventArgs e)
        {

        }

        private void btmShow_Click(object sender, EventArgs e)
        {
           labelDisplay.Text= $"Name: {textBox1.Text}\nEmail: {textBox2.Text} \nContact: {textBox3.Text}\nAddress: {textBox4.Text}";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void labelDisplay_Click(object sender, EventArgs e)
        {
            
        }
    }
}
