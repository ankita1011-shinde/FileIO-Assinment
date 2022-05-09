using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text.Json;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace WindowsFirstForm
{
    public partial class BookForm8 : Form
    {
        FileStream fs;
        public BookForm8()
        {
            InitializeComponent();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
        //Binary Write
        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                Book book = new Book();
                book.Id = Convert.ToInt32(txtId.Text);
                book.Name = txtName.Text;
                book.AuthorName = txtAuthorName.Text;
                book.Price = Convert.ToInt32(txtPrice.Text);
                book.StoreBookDetails = txtBookDetails.Text;

                fs = new FileStream(@"D:\TestFolder\Book", FileMode.Create, FileAccess.Write);
                BinaryFormatter binary = new BinaryFormatter();
                binary.Serialize(fs, book);
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
        //Binary Read
        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                Book book = new Book();
                fs = new FileStream(@"D:\TestFolder\Book", FileMode.Open, FileAccess.Read);
                BinaryFormatter binary = new BinaryFormatter();
                book = (Book)binary.Deserialize(fs);
                txtId.Text = book.ToString();
                txtName.Text = book.Name;
                txtAuthorName.Text = book.AuthorName;
                txtPrice.Text = book.ToString();
                txtBookDetails.Text = book.StoreBookDetails;

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
        //Xml Write
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Book book = new Book();
                book.Id = Convert.ToInt32(txtId.Text);
                book.Name = txtName.Text;
                book.AuthorName = txtBookDetails.Text;
                book.Price = Convert.ToInt32(txtPrice.Text);
                book.StoreBookDetails = txtBookDetails.Text;

                fs = new FileStream(@"D:\TestFolder\BookXml", FileMode.Create, FileAccess.Write);
                XmlSerializer xml = new XmlSerializer(typeof(Depatment));
                xml.Serialize(fs, book);
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
        //Xml Read
        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                Book book = new Book();
                fs = new FileStream(@"D:\TestFolder\BookXml", FileMode.Open, FileAccess.Read);
                XmlSerializer xml = new XmlSerializer(typeof(Product));
                book = (Book)xml.Deserialize(fs);
                txtId.Text = book.ToString();
                txtName.Text = book.Name;
                txtPrice.Text = book.ToString();
                txtBookDetails.Text = book.StoreBookDetails;
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
        //Soap Write
        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                Book book = new Book();
                book.Id = Convert.ToInt32(txtId.Text);
                book.Name = txtName.Text;
                book.AuthorName = txtAuthorName.Text;
                book.Price = Convert.ToInt32(txtPrice.Text);
                book.StoreBookDetails = txtBookDetails.Text;


                fs = new FileStream(@"D:\TestFolder\BookSoap", FileMode.Create, FileAccess.Write);
                SoapFormatter soap = new SoapFormatter();
                soap.Serialize(fs, book);
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
        //Soap Read
        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                Book book = new Book();

                fs = new FileStream(@"D:\TestFolder\BookSoap", FileMode.Create, FileAccess.Write);
                SoapFormatter soap = new SoapFormatter();
                book = (Book)soap.Deserialize(fs);
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
        //Json Write
        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                Book book = new Book();
                book.Id = Convert.ToInt32(txtId.Text);
                book.Name = txtName.Text;
                book.AuthorName = txtAuthorName.Text;
                book.Price = Convert.ToInt32(txtPrice.Text);
                book.StoreBookDetails = txtBookDetails.Text;

                fs = new FileStream(@"D:\TestFolder\BookJson", FileMode.Create, FileAccess.Write);
                JsonSerializer.Serialize(fs, book);

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
        //Json Read
        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                Book book = new Book();
                fs = new FileStream(@"D:\TestFolder\BookJson", FileMode.Create, FileAccess.Write);
                JsonSerializer.Deserialize<Book>(fs);
                txtId.Text = book.ToString();
                txtName.Text = book.Name;
                txtAuthorName.Text = book.AuthorName;
                txtPrice.Text = book.ToString();
                txtBookDetails.Text = book.StoreBookDetails;

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
