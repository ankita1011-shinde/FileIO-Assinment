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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(textBox1.Text =="Ankita" && textBox2.Text == "Ankita@123")
            {
                MessageBox.Show("Registration Successful");
            }
            
            
        }

        private void LabelId_Click(object sender, EventArgs e)
        {
           
        }

        private void btnclear_Click(object sender, EventArgs e)
        {


            textBox1.Clear();
            textBox2.Clear();
        }
    }
}
