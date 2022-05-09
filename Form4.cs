using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text.Json;


namespace WindowsFirstForm
{
    public partial class Form4 : Form
    {
        FileStream fs;
        public Form4()
        {
            
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCreateFolder_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"D:\TestFolder";
                if(Directory.Exists(path))
                {
                    MessageBox.Show("Folder already exits");
                }
                else
                {
                    Directory.CreateDirectory(path);
                    MessageBox.Show("Folder Created");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCreateFile_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"D:\TestFolder\FirstFile.txt";
                if(File.Exists(path))
                {
                    MessageBox.Show("File already exist");
                }
                else
                {
                    File.Create(path);
                    MessageBox.Show("File Created");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnWritefile_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtId.Text);
                string Name=txtName.Text;
                string Location = txtLoc.Text;
                fs = new FileStream(@"D:\TestFolder\FirstFile.txt", FileMode.Create, FileAccess.Write);

                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(id);
                bw.Write(Name);
                bw.Write(Location);
                bw.Close();
                MessageBox.Show("Done");

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
        
        private void btnReadfromfile_Click(object sender, EventArgs e)
        {
            try
            {
                fs = new FileStream(@"D:\TestFolder\FirstFile.txt", FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                txtId.Text = br.ReadInt32().ToString();
                txtName.Text = br.ReadString();
                txtLoc.Text = br.ReadString();
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
        private void btnBinarywrite_Click(object sender, EventArgs e)
        {
            try
            {
                Depatment dept = new Depatment();
                dept.Id = Convert.ToInt32(txtId.Text);
                dept.Name = txtName.Text;
                dept.Location = txtLoc.Text;

                fs = new FileStream(@"D:\TestFolder\Dept", FileMode.Create, FileAccess.Write);
                BinaryFormatter binary = new BinaryFormatter();
                binary.Serialize(fs, dept);
                MessageBox.Show("Done");
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

        private void btnBinaryread_Click(object sender, EventArgs e)
        {
            try
            {
                Depatment dept = new Depatment();
                fs = new FileStream(@"D:\TestFolder\Dept", FileMode.Open,FileAccess.Read);
                BinaryFormatter binary = new BinaryFormatter();
                dept =(Depatment)binary.Deserialize(fs);
                txtId.Text = dept.ToString();
                txtName.Text = dept.Name;
                txtLoc.Text = dept.Location;
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
                Depatment dept = new Depatment();
                dept.Id = Convert.ToInt32(txtId.Text);
                dept.Name = txtName.Text;
                dept.Location = txtLoc.Text;

                fs = new FileStream(@"D:\TestFolder\DeptXml", FileMode.Create, FileAccess.Write);
                XmlSerializer xml =new XmlSerializer(typeof(Depatment));
                xml.Serialize(fs, dept);
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
                Depatment dept = new Depatment();
                fs = new FileStream(@"D:\TestFolder\DeptXml", FileMode.Open, FileAccess.Read);
                XmlSerializer xml = new XmlSerializer(typeof(Depatment));
                dept = (Depatment)xml.Deserialize(fs);
                txtId.Text = dept.ToString();
                txtName.Text = dept.Name;
                txtLoc.Text = dept.Location;
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
           
        }

        private void btnSoapRead_Click(object sender, EventArgs e)
        {
            try
            {
                Depatment dept = new Depatment();
                fs = new FileStream(@"D:\TestFolder\Soapfile", FileMode.Open, FileAccess.Read);
                SoapFormatter soap = new SoapFormatter();
                dept = (Depatment)soap.Deserialize(fs);
                txtId.Text = dept.ToString();
                txtName.Text = dept.Name;
                txtLoc.Text = dept.Location;
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

        private void btnSoapWrite_Click_1(object sender, EventArgs e)
        {
            try
            {
                Depatment dept = new Depatment();
                dept.Id = Convert.ToInt32(txtId.Text);
                dept.Name = txtName.Text;
                dept.Location = txtLoc.Text;

                fs = new FileStream(@"D:\TestFolder\Soapfile", FileMode.Create, FileAccess.Write);
                SoapFormatter soap = new SoapFormatter();
                soap.Serialize(fs, dept);
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

        private void btnJson_Click(object sender, EventArgs e)
        {
            try
            {
                Depatment dept = new Depatment();
                dept.Id = Convert.ToInt32(txtId.Text);
                dept.Name = txtName.Text;
                dept.Location = txtLoc.Text;

                fs = new FileStream(@"D:\TestFolder\Jsonfile", FileMode.Create, FileAccess.Write);
                JsonSerializer.Serialize(fs, dept);
                
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

        private void btnJsonread_Click(object sender, EventArgs e)
        {
            try
            {
                Depatment dept = new Depatment();
                fs = new FileStream(@"D:\TestFolder\Jsonfile", FileMode.Open, FileAccess.Read);
                JsonSerializer.Deserialize<Depatment>(fs);
                
                txtId.Text = dept.ToString();
                txtName.Text = dept.Name;
                txtLoc.Text = dept.Location;
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
