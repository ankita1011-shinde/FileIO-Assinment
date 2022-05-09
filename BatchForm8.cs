using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace WindowsFirstForm
{
    public partial class BatchForm8 : Form
    {
        FileStream fs;
        public BatchForm8()
        {
            InitializeComponent();
        }

        private void btnId_Click(object sender, EventArgs e)
        {

        }

        private void btnBinaryWrite_Click(object sender, EventArgs e)
        {
            try
            {
                BatchInfo batch = new BatchInfo();
                batch.BatchId = Convert.ToInt32(batch.BatchId);
                batch.BatchName=batch.BatchName;
                batch.StartDate = batch.StartDate;
                batch.EndDate = batch.EndDate;
                batch.Location=batch.Location

                fs = new FileStream(@"D:\TestFolder\Batch", FileMode.Create, FileAccess.Write);
                BinaryFormatter binary = new BinaryFormatter();
                binary.Serialize(fs, batch);
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
                BatchInfo batch = new BatchInfo;
                fs = new FileStream(@"D:\TestFolder\Batch", FileMode.Open, FileAccess.Read);
                BinaryFormatter binary = new BinaryFormatter();
                batch = (BatchInfo)binary.Deserialize(fs);
                txtId.Text = batch.ToString();
                txtName.Text = batch.BatchName;
                txtSdate.Text = batch.StartDate;
                txtEDate.Text = batch.EndDate;
                txtLocation.Text=batch.Location;
                txtTrainer.Text=batch.Trainer;
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
