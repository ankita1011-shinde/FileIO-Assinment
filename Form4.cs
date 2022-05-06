using System;
using System.IO;
using System.Windows.Forms;

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
                string path = @"D:\TestFolder\FistFile.txt";
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
                fs = new FileStream(@"D:\TestFolder\FistFile.txt", FileMode.Create, FileAccess.Write);

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
                fs  =new FileStream( @"D:\TestFolder\FistFile.txt", FileMode.Open, FileAccess.Read);
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
    }
}
