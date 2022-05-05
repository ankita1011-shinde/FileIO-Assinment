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
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}