namespace WindowsFirstForm
{
    partial class Form12
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
            this.txtDName = new System.Windows.Forms.TextBox();
            this.btnDNAme = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSsave = new System.Windows.Forms.Button();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.btnSalary = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnName = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnId = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDName
            // 
            this.txtDName.Location = new System.Drawing.Point(240, 236);
            this.txtDName.Name = "txtDName";
            this.txtDName.Size = new System.Drawing.Size(100, 20);
            this.txtDName.TabIndex = 43;
            // 
            // btnDNAme
            // 
            this.btnDNAme.Location = new System.Drawing.Point(122, 233);
            this.btnDNAme.Name = "btnDNAme";
            this.btnDNAme.Size = new System.Drawing.Size(75, 23);
            this.btnDNAme.TabIndex = 42;
            this.btnDNAme.Text = "DeptName";
            this.btnDNAme.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(396, 124);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 39;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(396, 95);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 38;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(302, 317);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 37;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSsave
            // 
            this.btnSsave.Location = new System.Drawing.Point(189, 317);
            this.btnSsave.Name = "btnSsave";
            this.btnSsave.Size = new System.Drawing.Size(75, 23);
            this.btnSsave.TabIndex = 36;
            this.btnSsave.Text = "Save";
            this.btnSsave.UseVisualStyleBackColor = true;
            this.btnSsave.Click += new System.EventHandler(this.btnSsave_Click);
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(240, 187);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(100, 20);
            this.txtSalary.TabIndex = 35;
            // 
            // btnSalary
            // 
            this.btnSalary.Location = new System.Drawing.Point(122, 184);
            this.btnSalary.Name = "btnSalary";
            this.btnSalary.Size = new System.Drawing.Size(75, 23);
            this.btnSalary.TabIndex = 34;
            this.btnSalary.Text = "Salary";
            this.btnSalary.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(240, 127);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 33;
            // 
            // btnName
            // 
            this.btnName.Location = new System.Drawing.Point(122, 127);
            this.btnName.Name = "btnName";
            this.btnName.Size = new System.Drawing.Size(75, 23);
            this.btnName.TabIndex = 32;
            this.btnName.Text = "Emp Name";
            this.btnName.UseVisualStyleBackColor = true;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(238, 79);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 31;
            // 
            // btnId
            // 
            this.btnId.Location = new System.Drawing.Point(122, 77);
            this.btnId.Name = "btnId";
            this.btnId.Size = new System.Drawing.Size(75, 23);
            this.btnId.TabIndex = 30;
            this.btnId.Text = "Emp Id";
            this.btnId.UseVisualStyleBackColor = true;
            // 
            // Form12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtDName);
            this.Controls.Add(this.btnDNAme);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSsave);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.btnSalary);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnName);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnId);
            this.Name = "Form12";
            this.Text = "Emp-Disconnection Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDName;
        private System.Windows.Forms.Button btnDNAme;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSsave;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Button btnSalary;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnName;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnId;
    }
}