using System;
using System.IO;
using System.Windows.Forms;

namespace WindowsFirstForm
{
    public partial class Form5 : Form
    {
        FileStream fs;   
        public Form5()
        {
            InitializeComponent();
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            try
            {
                int RollNo = Convert.ToInt32(txtRollno.Text);
                string Name =txtName.Text;
                int Percentage = Convert.ToInt32(txtPer.Text);
                string Stream = txtstream.Text;
                string City = txtcity.Text;
                fs = new FileStream(@"D:\TestFolder\Student.txt", FileMode.Create, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(RollNo);
                bw.Write(Name);
                bw.Write(Percentage);
                bw.Write(Stream);
                bw.Write(City);
                bw.Close();
                MessageBox.Show("Done");



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                fs = new FileStream(@"D:\TestFolder\Student.txt", FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                txtRollno.Text = br.ReadInt32().ToString();
                txtName.Text = br.ReadString();
                txtPer.Text = br.ReadInt32().ToString();
                txtstream.Text = br.ReadString();
                txtcity.Text = br.ReadString();
                br.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }
        }
    }
}
