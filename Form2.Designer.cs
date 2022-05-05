namespace WindowsFirstForm
{
    partial class Form2
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
            this.labelName = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelCNo = new System.Windows.Forms.Label();
            this.labelAdrs = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btmShow = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.labelDisplay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(58, 31);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(89, 20);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Full Name";
            this.labelName.Click += new System.EventHandler(this.labelName_Click);
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(58, 84);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(74, 20);
            this.labelEmail.TabIndex = 1;
            this.labelEmail.Text = "Email Id";
            this.labelEmail.Click += new System.EventHandler(this.labelEmail_Click);
            // 
            // labelCNo
            // 
            this.labelCNo.AutoSize = true;
            this.labelCNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCNo.Location = new System.Drawing.Point(58, 124);
            this.labelCNo.Name = "labelCNo";
            this.labelCNo.Size = new System.Drawing.Size(144, 20);
            this.labelCNo.TabIndex = 2;
            this.labelCNo.Text = "Contact Number ";
            // 
            // labelAdrs
            // 
            this.labelAdrs.AutoSize = true;
            this.labelAdrs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdrs.Location = new System.Drawing.Point(58, 179);
            this.labelAdrs.Name = "labelAdrs";
            this.labelAdrs.Size = new System.Drawing.Size(80, 20);
            this.labelAdrs.TabIndex = 3;
            this.labelAdrs.Text = "Address ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(208, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(245, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(208, 84);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(245, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(208, 126);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(136, 20);
            this.textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(208, 181);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(245, 20);
            this.textBox4.TabIndex = 7;
            // 
            // btmShow
            // 
            this.btmShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmShow.Location = new System.Drawing.Point(109, 262);
            this.btmShow.Name = "btmShow";
            this.btmShow.Size = new System.Drawing.Size(75, 23);
            this.btmShow.TabIndex = 8;
            this.btmShow.Text = "Show";
            this.btmShow.UseVisualStyleBackColor = true;
            this.btmShow.Click += new System.EventHandler(this.btmShow_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(357, 262);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // labelDisplay
            // 
            this.labelDisplay.AutoSize = true;
            this.labelDisplay.Location = new System.Drawing.Point(71, 306);
            this.labelDisplay.Name = "labelDisplay";
            this.labelDisplay.Size = new System.Drawing.Size(67, 13);
            this.labelDisplay.TabIndex = 10;
            this.labelDisplay.Text = "Display Form";
            this.labelDisplay.Click += new System.EventHandler(this.labelDisplay_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 450);
            this.Controls.Add(this.labelDisplay);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btmShow);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelAdrs);
            this.Controls.Add(this.labelCNo);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelName);
            this.Name = "Form2";
            this.Text = "Registration form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelCNo;
        private System.Windows.Forms.Label labelAdrs;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btmShow;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label labelDisplay;
    }
}