namespace WindowsFirstForm
{
    partial class Form4
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
            this.btnWritefile = new System.Windows.Forms.Button();
            this.labelId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.txtLoc = new System.Windows.Forms.TextBox();
            this.labelLoca = new System.Windows.Forms.Label();
            this.btnReadfromfile = new System.Windows.Forms.Button();
            this.btnCreateFolder = new System.Windows.Forms.Button();
            this.btnCreateFile = new System.Windows.Forms.Button();
            this.btnBinarywrite = new System.Windows.Forms.Button();
            this.btnBinaryread = new System.Windows.Forms.Button();
            this.btnXmlWrite = new System.Windows.Forms.Button();
            this.btnXmlRead = new System.Windows.Forms.Button();
            this.btnSoapWrite = new System.Windows.Forms.Button();
            this.btnSoapRead = new System.Windows.Forms.Button();
            this.btnJson = new System.Windows.Forms.Button();
            this.btnJsonread = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnWritefile
            // 
            this.btnWritefile.Location = new System.Drawing.Point(255, 228);
            this.btnWritefile.Name = "btnWritefile";
            this.btnWritefile.Size = new System.Drawing.Size(86, 23);
            this.btnWritefile.TabIndex = 0;
            this.btnWritefile.Text = "Write to File";
            this.btnWritefile.UseVisualStyleBackColor = true;
            this.btnWritefile.Click += new System.EventHandler(this.btnWritefile_Click);
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(210, 32);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(102, 13);
            this.labelId.TabIndex = 1;
            this.labelId.Text = "Enter Department Id";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(367, 25);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(143, 20);
            this.txtId.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(367, 112);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(143, 20);
            this.txtName.TabIndex = 4;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(210, 112);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(89, 13);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Enter Dept Name";
            // 
            // txtLoc
            // 
            this.txtLoc.Location = new System.Drawing.Point(367, 168);
            this.txtLoc.Name = "txtLoc";
            this.txtLoc.Size = new System.Drawing.Size(143, 20);
            this.txtLoc.TabIndex = 6;
            // 
            // labelLoca
            // 
            this.labelLoca.AutoSize = true;
            this.labelLoca.Location = new System.Drawing.Point(210, 175);
            this.labelLoca.Name = "labelLoca";
            this.labelLoca.Size = new System.Drawing.Size(76, 13);
            this.labelLoca.TabIndex = 5;
            this.labelLoca.Text = "Enter Location";
            // 
            // btnReadfromfile
            // 
            this.btnReadfromfile.Location = new System.Drawing.Point(408, 228);
            this.btnReadfromfile.Name = "btnReadfromfile";
            this.btnReadfromfile.Size = new System.Drawing.Size(88, 23);
            this.btnReadfromfile.TabIndex = 7;
            this.btnReadfromfile.Text = "Read From File";
            this.btnReadfromfile.UseVisualStyleBackColor = true;
            this.btnReadfromfile.Click += new System.EventHandler(this.btnReadfromfile_Click);
            // 
            // btnCreateFolder
            // 
            this.btnCreateFolder.Location = new System.Drawing.Point(255, 289);
            this.btnCreateFolder.Name = "btnCreateFolder";
            this.btnCreateFolder.Size = new System.Drawing.Size(86, 23);
            this.btnCreateFolder.TabIndex = 8;
            this.btnCreateFolder.Text = "Create Folder";
            this.btnCreateFolder.UseVisualStyleBackColor = true;
            this.btnCreateFolder.Click += new System.EventHandler(this.btnCreateFolder_Click);
            // 
            // btnCreateFile
            // 
            this.btnCreateFile.Location = new System.Drawing.Point(408, 289);
            this.btnCreateFile.Name = "btnCreateFile";
            this.btnCreateFile.Size = new System.Drawing.Size(88, 23);
            this.btnCreateFile.TabIndex = 9;
            this.btnCreateFile.Text = "Create File";
            this.btnCreateFile.UseVisualStyleBackColor = true;
            this.btnCreateFile.Click += new System.EventHandler(this.btnCreateFile_Click);
            // 
            // btnBinarywrite
            // 
            this.btnBinarywrite.Location = new System.Drawing.Point(599, 27);
            this.btnBinarywrite.Name = "btnBinarywrite";
            this.btnBinarywrite.Size = new System.Drawing.Size(75, 23);
            this.btnBinarywrite.TabIndex = 10;
            this.btnBinarywrite.Text = "Binary Write";
            this.btnBinarywrite.UseVisualStyleBackColor = true;
            this.btnBinarywrite.Click += new System.EventHandler(this.btnBinarywrite_Click);
            // 
            // btnBinaryread
            // 
            this.btnBinaryread.Location = new System.Drawing.Point(599, 77);
            this.btnBinaryread.Name = "btnBinaryread";
            this.btnBinaryread.Size = new System.Drawing.Size(75, 23);
            this.btnBinaryread.TabIndex = 11;
            this.btnBinaryread.Text = "Binary Read";
            this.btnBinaryread.UseVisualStyleBackColor = true;
            this.btnBinaryread.Click += new System.EventHandler(this.btnBinaryread_Click);
            // 
            // btnXmlWrite
            // 
            this.btnXmlWrite.Location = new System.Drawing.Point(599, 123);
            this.btnXmlWrite.Name = "btnXmlWrite";
            this.btnXmlWrite.Size = new System.Drawing.Size(75, 23);
            this.btnXmlWrite.TabIndex = 12;
            this.btnXmlWrite.Text = "XML Write";
            this.btnXmlWrite.UseVisualStyleBackColor = true;
            this.btnXmlWrite.Click += new System.EventHandler(this.btnXmlWrite_Click);
            // 
            // btnXmlRead
            // 
            this.btnXmlRead.Location = new System.Drawing.Point(599, 165);
            this.btnXmlRead.Name = "btnXmlRead";
            this.btnXmlRead.Size = new System.Drawing.Size(75, 23);
            this.btnXmlRead.TabIndex = 13;
            this.btnXmlRead.Text = "XMLRead";
            this.btnXmlRead.UseVisualStyleBackColor = true;
            this.btnXmlRead.Click += new System.EventHandler(this.btnXmlRead_Click);
            // 
            // btnSoapWrite
            // 
            this.btnSoapWrite.Location = new System.Drawing.Point(599, 209);
            this.btnSoapWrite.Name = "btnSoapWrite";
            this.btnSoapWrite.Size = new System.Drawing.Size(75, 23);
            this.btnSoapWrite.TabIndex = 14;
            this.btnSoapWrite.Text = "SoapWrite";
            this.btnSoapWrite.UseVisualStyleBackColor = true;
            this.btnSoapWrite.Click += new System.EventHandler(this.btnSoapWrite_Click_1);
            // 
            // btnSoapRead
            // 
            this.btnSoapRead.Location = new System.Drawing.Point(599, 254);
            this.btnSoapRead.Name = "btnSoapRead";
            this.btnSoapRead.Size = new System.Drawing.Size(75, 23);
            this.btnSoapRead.TabIndex = 15;
            this.btnSoapRead.Text = "Soap Read";
            this.btnSoapRead.UseVisualStyleBackColor = true;
            this.btnSoapRead.Click += new System.EventHandler(this.btnSoapRead_Click);
            // 
            // btnJson
            // 
            this.btnJson.Location = new System.Drawing.Point(599, 305);
            this.btnJson.Name = "btnJson";
            this.btnJson.Size = new System.Drawing.Size(75, 23);
            this.btnJson.TabIndex = 16;
            this.btnJson.Text = "JSon Write";
            this.btnJson.UseVisualStyleBackColor = true;
            this.btnJson.Click += new System.EventHandler(this.btnJson_Click);
            // 
            // btnJsonread
            // 
            this.btnJsonread.Location = new System.Drawing.Point(599, 368);
            this.btnJsonread.Name = "btnJsonread";
            this.btnJsonread.Size = new System.Drawing.Size(75, 23);
            this.btnJsonread.TabIndex = 17;
            this.btnJsonread.Text = "JSonRead";
            this.btnJsonread.UseVisualStyleBackColor = true;
            this.btnJsonread.Click += new System.EventHandler(this.btnJsonread_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnJsonread);
            this.Controls.Add(this.btnJson);
            this.Controls.Add(this.btnSoapRead);
            this.Controls.Add(this.btnSoapWrite);
            this.Controls.Add(this.btnXmlRead);
            this.Controls.Add(this.btnXmlWrite);
            this.Controls.Add(this.btnBinaryread);
            this.Controls.Add(this.btnBinarywrite);
            this.Controls.Add(this.btnCreateFile);
            this.Controls.Add(this.btnCreateFolder);
            this.Controls.Add(this.btnReadfromfile);
            this.Controls.Add(this.txtLoc);
            this.Controls.Add(this.labelLoca);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.btnWritefile);
            this.Name = "Form4";
            this.Text = "File IO";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWritefile;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox txtLoc;
        private System.Windows.Forms.Label labelLoca;
        private System.Windows.Forms.Button btnReadfromfile;
        private System.Windows.Forms.Button btnCreateFolder;
        private System.Windows.Forms.Button btnCreateFile;
        private System.Windows.Forms.Button btnBinarywrite;
        private System.Windows.Forms.Button btnBinaryread;
        private System.Windows.Forms.Button btnXmlWrite;
        private System.Windows.Forms.Button btnXmlRead;
        private System.Windows.Forms.Button btnSoapWrite;
        private System.Windows.Forms.Button btnSoapRead;
        private System.Windows.Forms.Button btnJson;
        private System.Windows.Forms.Button btnJsonread;
    }
}