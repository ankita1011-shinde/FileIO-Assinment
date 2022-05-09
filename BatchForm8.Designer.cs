namespace WindowsFirstForm
{
    partial class BatchForm8
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnId = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnName = new System.Windows.Forms.Button();
            this.txtSdate = new System.Windows.Forms.TextBox();
            this.btnStartDate = new System.Windows.Forms.Button();
            this.txtEDate = new System.Windows.Forms.TextBox();
            this.btnEndDate = new System.Windows.Forms.Button();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.btnLocation = new System.Windows.Forms.Button();
            this.txtTrainer = new System.Windows.Forms.TextBox();
            this.btnTrainer = new System.Windows.Forms.Button();
            this.btnBinaryWrite = new System.Windows.Forms.Button();
            this.btnBinaryRead = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnId
            // 
            this.btnId.Location = new System.Drawing.Point(145, 9);
            this.btnId.Name = "btnId";
            this.btnId.Size = new System.Drawing.Size(75, 23);
            this.btnId.TabIndex = 0;
            this.btnId.Text = "Batch Id";
            this.btnId.UseVisualStyleBackColor = true;
            this.btnId.Click += new System.EventHandler(this.btnId_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(295, 12);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(295, 62);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 3;
            // 
            // btnName
            // 
            this.btnName.Location = new System.Drawing.Point(145, 59);
            this.btnName.Name = "btnName";
            this.btnName.Size = new System.Drawing.Size(75, 23);
            this.btnName.TabIndex = 2;
            this.btnName.Text = "Batch Name";
            this.btnName.UseVisualStyleBackColor = true;
            // 
            // txtSdate
            // 
            this.txtSdate.Location = new System.Drawing.Point(295, 120);
            this.txtSdate.Name = "txtSdate";
            this.txtSdate.Size = new System.Drawing.Size(100, 20);
            this.txtSdate.TabIndex = 5;
            // 
            // btnStartDate
            // 
            this.btnStartDate.Location = new System.Drawing.Point(145, 118);
            this.btnStartDate.Name = "btnStartDate";
            this.btnStartDate.Size = new System.Drawing.Size(75, 23);
            this.btnStartDate.TabIndex = 4;
            this.btnStartDate.Text = "Start Date";
            this.btnStartDate.UseVisualStyleBackColor = true;
            // 
            // txtEDate
            // 
            this.txtEDate.Location = new System.Drawing.Point(295, 176);
            this.txtEDate.Name = "txtEDate";
            this.txtEDate.Size = new System.Drawing.Size(100, 20);
            this.txtEDate.TabIndex = 7;
            // 
            // btnEndDate
            // 
            this.btnEndDate.Location = new System.Drawing.Point(145, 173);
            this.btnEndDate.Name = "btnEndDate";
            this.btnEndDate.Size = new System.Drawing.Size(75, 23);
            this.btnEndDate.TabIndex = 6;
            this.btnEndDate.Text = "End Date";
            this.btnEndDate.UseVisualStyleBackColor = true;
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(295, 234);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(100, 20);
            this.txtLocation.TabIndex = 9;
            // 
            // btnLocation
            // 
            this.btnLocation.Location = new System.Drawing.Point(145, 234);
            this.btnLocation.Name = "btnLocation";
            this.btnLocation.Size = new System.Drawing.Size(75, 23);
            this.btnLocation.TabIndex = 8;
            this.btnLocation.Text = "Location";
            this.btnLocation.UseVisualStyleBackColor = true;
            // 
            // txtTrainer
            // 
            this.txtTrainer.Location = new System.Drawing.Point(295, 296);
            this.txtTrainer.Name = "txtTrainer";
            this.txtTrainer.Size = new System.Drawing.Size(100, 20);
            this.txtTrainer.TabIndex = 11;
            // 
            // btnTrainer
            // 
            this.btnTrainer.Location = new System.Drawing.Point(145, 293);
            this.btnTrainer.Name = "btnTrainer";
            this.btnTrainer.Size = new System.Drawing.Size(75, 23);
            this.btnTrainer.TabIndex = 10;
            this.btnTrainer.Text = "Trainer Name";
            this.btnTrainer.UseVisualStyleBackColor = true;
            // 
            // btnBinaryWrite
            // 
            this.btnBinaryWrite.Location = new System.Drawing.Point(131, 354);
            this.btnBinaryWrite.Name = "btnBinaryWrite";
            this.btnBinaryWrite.Size = new System.Drawing.Size(75, 23);
            this.btnBinaryWrite.TabIndex = 12;
            this.btnBinaryWrite.Text = "Binary Write";
            this.btnBinaryWrite.UseVisualStyleBackColor = true;
            this.btnBinaryWrite.Click += new System.EventHandler(this.btnBinaryWrite_Click);
            // 
            // btnBinaryRead
            // 
            this.btnBinaryRead.Location = new System.Drawing.Point(347, 354);
            this.btnBinaryRead.Name = "btnBinaryRead";
            this.btnBinaryRead.Size = new System.Drawing.Size(75, 23);
            this.btnBinaryRead.TabIndex = 13;
            this.btnBinaryRead.Text = "BinaryRead";
            this.btnBinaryRead.UseVisualStyleBackColor = true;
            this.btnBinaryRead.Click += new System.EventHandler(this.btnBinaryRead_Click);
            // 
            // BatchForm8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBinaryRead);
            this.Controls.Add(this.btnBinaryWrite);
            this.Controls.Add(this.txtTrainer);
            this.Controls.Add(this.btnTrainer);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.btnLocation);
            this.Controls.Add(this.txtEDate);
            this.Controls.Add(this.btnEndDate);
            this.Controls.Add(this.txtSdate);
            this.Controls.Add(this.btnStartDate);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnName);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnId);
            this.Name = "BatchForm8";
            this.Text = "Batch Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnName;
        private System.Windows.Forms.TextBox txtSdate;
        private System.Windows.Forms.Button btnStartDate;
        private System.Windows.Forms.TextBox txtEDate;
        private System.Windows.Forms.Button btnEndDate;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Button btnLocation;
        private System.Windows.Forms.TextBox txtTrainer;
        private System.Windows.Forms.Button btnTrainer;
        private System.Windows.Forms.Button btnBinaryWrite;
        private System.Windows.Forms.Button btnBinaryRead;
    }
}