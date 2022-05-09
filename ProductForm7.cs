using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Text.Json;

namespace WindowsFirstForm
{
    public partial class Form7 : Form
    {
        FileStream fs;
        public Form7()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBinaryWrite_Click(object sender, EventArgs e)
        {
            try
            {
                Product prod = new Product();
                prod.Id = Convert.ToInt32(txtId.Text);
                prod.Name = txtname.Text;
                prod.Price = Convert.ToInt32(txtPrice.Text);
                prod.Category = txtCategory.Text;

                fs = new FileStream(@"D:\TestFolder\Product", FileMode.Create, FileAccess.Write);
                BinaryFormatter binary = new BinaryFormatter();
                binary.Serialize(fs, prod);
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

        private void btnBinaryRead_Click(object sender, EventArgs e)
        {

            try
            {
                Product prod = new Product();
                fs = new FileStream(@"D:\TestFolder\Product", FileMode.Open, FileAccess.Read);
                BinaryFormatter binary = new BinaryFormatter();
                prod = (Product)binary.Deserialize(fs);
                txtId.Text = prod.ToString();
                txtname.Text = prod.Name;
                txtPrice.Text = prod.ToString();
                txtCategory.Text = prod.Category;

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

        private void btnXmlWrite_Click(object sender, EventArgs e)
        {
            try
            {
                Product prod = new Product();
                prod.Id = Convert.ToInt32(txtId.Text);
                prod.Name = txtname.Text;
                prod.Price = Convert.ToInt32(txtPrice.Text);
                prod.Category = txtCategory.Text;

                fs = new FileStream(@"D:\TestFolder\ProductXml", FileMode.Create, FileAccess.Write);
                XmlSerializer xml = new XmlSerializer(typeof(Depatment));
                xml.Serialize(fs, prod);
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

        private void btnXmlRead_Click(object sender, EventArgs e)
        {

            try
            {
                Product prod = new Product();
                fs = new FileStream(@"D:\TestFolder\ProductXml", FileMode.Open, FileAccess.Read);
                XmlSerializer xml = new XmlSerializer(typeof(Product));
                prod = (Product)xml.Deserialize(fs);
                txtId.Text = prod.ToString();
                txtname.Text = prod.Name;
                txtPrice.Text = prod.ToString();
                txtCategory.Text = prod.Category;
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




        private void btnSoapWrite_Click(object sender, EventArgs e)
        {
            try
            {
                Product prod = new Product();
                prod.Id = Convert.ToInt32(txtId.Text);
                prod.Name = txtname.Text;
                prod.Price = Convert.ToInt32(txtPrice.Text);
                prod.Category = txtCategory.Text;
                

                fs = new FileStream(@"D:\TestFolder\ProductSoap", FileMode.Create, FileAccess.Write);
                SoapFormatter soap = new SoapFormatter();
                soap.Serialize(fs, prod);
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

        private void btnSoapRead_Click(object sender, EventArgs e)
        {
            try
            {
                Product prod = new Product();

                fs = new FileStream(@"D:\TestFolder\ProductSoap", FileMode.Create, FileAccess.Write);
                SoapFormatter soap = new SoapFormatter();
                prod = (Product)soap.Deserialize(fs);
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

        private void btnJsonWrite_Click(object sender, EventArgs e)
        {
            try
            {
                Product prod = new Product();
                prod.Id = Convert.ToInt32(txtId.Text);
                prod.Name = txtname.Text;
                prod.Price = Convert.ToInt32(txtPrice.Text);

                fs = new FileStream(@"D:\TestFolder\ProductJson", FileMode.Create, FileAccess.Write);
                JsonSerializer.Serialize(fs,prod);
                
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

        private void btnJsonRead_Click(object sender, EventArgs e)
        {

            try
            {
                Product prod = new Product();
                fs = new FileStream(@"D:\TestFolder\ProductJson", FileMode.Create, FileAccess.Write);
                JsonSerializer.Deserialize<Product>(fs);
                txtId.Text = prod.ToString();
                txtname.Text = prod.Name;
                txtPrice.Text = prod.ToString();
                

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
