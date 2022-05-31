using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;
using System.Data;

namespace WindowsFirstForm
{
    public partial class Form9 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;

        public Form9()
        {
            InitializeComponent();
            con = new SqlConnection(@"Server=DESKTOP-BBUJ9E0\SQLEXPRESS;database=ThinkQuotient;Integrated Security=True");

        }


        private void Form9_Load(object sender, EventArgs e)

        {

        }

        private void btnSsave_Click(object sender, EventArgs e)
        {
            try
            {

                string qry = "insert into Product values(@id,@name,@price)";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtId.Text));
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@price", Convert.ToInt32(txtPrice.Text));
                con.Open();
                int re = cmd.ExecuteNonQuery();
                if (re == 1)
                {
                    MessageBox.Show("Recoerd inserted");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "select * from Product where Id=@id";
                cmd= new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtId.Text));
                con.Open();
                dr = cmd.ExecuteReader();
                if(dr.HasRows)
                {
                    while (dr.Read())
                    {
                        txtName.Text=dr["Name"].ToString();
                        txtPrice.Text = dr["Price"].ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Recored not found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally 
            { con.Close(); }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            { 
            string qry = "delete from Product where Id=@id";
            cmd = new SqlCommand(qry, con);
            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtId.Text));
            con.Open();
            int res = cmd.ExecuteNonQuery();
            if(res == 1 )
            { 
                MessageBox.Show("Recored deleted");
            }
        }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally 
            { con.Close(); }
        }

        private void btnShowPRoduct_Click(object sender, EventArgs e)
        {

            try
            {
                string qry = "Select * from product";
                cmd = new SqlCommand(qry, con);
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    DataTable table = new DataTable();

                    table.Load(dr);
                    dataGridView1.DataSource= table;
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
            finally
            {
                con.Close();
            }
            }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "Update Product  set Name =@name,Price=@price where Id=@id";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtId.Text));
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@price", Convert.ToInt32(txtPrice.Text));
                con.Open();
                int res = cmd.ExecuteNonQuery();
                if (res == 1)
                {
                    MessageBox.Show("Recored Updated");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            { 
                con.Close();
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "select max(Id) from Product";
                cmd = new SqlCommand(qry, con);
                con.Open();
                object obj = cmd.ExecuteScalar();
                dr = cmd.ExecuteReader();
               if(obj == DBNull.Value)
                {
                    txtId.Text = "1";
                }
               else
                {
                    int id =Convert.ToInt32(obj);
                    id++;
                    txtId.Text = id.ToString(); 
                }
               txtId.Enabled= false;
                txtName.Clear();
                txtPrice.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
 }
