using System;
using System.IO;
using System.Windows.Forms;

namespace WindowsFirstForm
{
    public partial class Form6 : Form
    {
        FileStream fs;
        public Form6()
        {
            InitializeComponent();
        }

        private void btnWritefile_Click(object sender, EventArgs e)
        {
            try
            {
                int EmpId = Convert.ToInt32(txtId.Text);
                string Name = txtName.Text;
                string Designation = txtDesignation.Text;
                double Salary = Convert.ToDouble(txtSalary.Text);
                string Department = txtdepartment.Text;
                fs = new FileStream(@"D:\TestFolder\Employee.txt", FileMode.Create, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(EmpId);
                bw.Write(Name);
                bw.Write(Designation);
                bw.Write(Salary);
                bw.Write(Department);
                bw.Close();
                MessageBox.Show("Complete");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }
        }

        private void btnReadfile_Click(object sender, EventArgs e)
        {
            try
            {
                fs = new FileStream(@"D:\TestFolder\Employee.txt", FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                txtId.Text = br.ReadInt32().ToString();
                txtName.Text = br.ReadString();
                txtDesignation.Text = br.ReadString();
                txtSalary.Text = br.ReadDouble().ToString();
                txtdepartment.Text = br.ReadString();
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
