using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFirstForm.DAL;
using WindowsFirstForm.Model;

namespace WindowsFirstForm
{
    public partial class Form10 : Form
    {
        EmpDal empdal = new EmpDal();
        public Form10()
        {
            InitializeComponent();
        }

        private void btnShowPRoduct_Click(object sender, EventArgs e)
        {
            try
            {


                DataTable table = empdal.GetAllEmps();
                dataGridView1.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnSsave_Click(object sender, EventArgs e)
        {
            try
            {
                Emp emp = new Emp();
                emp.Name = txtName.Text;
                emp.Salary = Convert.ToDouble(txtSalary.Text);
                int res = empdal.Save(emp);
                if (res == 1)
                    MessageBox.Show("Inserted the record");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {


                Emp emp = empdal.GetEmpById(Convert.ToInt32(txtId.Text));
                if (emp.Id > 0)
                {
                    txtName.Text = emp.Name;
                    txtSalary.Text = emp.Salary.ToString();
                }
                else
                {
                    MessageBox.Show("Record not found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Emp emp = new Emp();
            emp.Id = Convert.ToInt32(txtId.Text);
            emp.Name = txtName.Text;
            emp.Salary = Convert.ToDouble(txtSalary.Text);
            int res = empdal.Upate(emp);
            if (res == 1)
                MessageBox.Show("updated the record");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            try
            {
                int res = empdal.Delete(Convert.ToInt32(txtId.Text));
            if (res == 1)
                MessageBox.Show("deleted the record");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
