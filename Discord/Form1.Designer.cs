namespace Discord
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblPasswordRetype = new System.Windows.Forms.Label();
            this.inputUsername = new System.Windows.Forms.TextBox();
            this.inputPassword = new System.Windows.Forms.TextBox();
            this.inputRetype = new System.Windows.Forms.TextBox();
            this.btnSignup = new System.Windows.Forms.Button();
            this.lblTest = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(292, 84);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(129, 25);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Tên đăng nhập";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(335, 162);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(86, 25);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Mật khẩu";
            // 
            // lblPasswordRetype
            // 
            this.lblPasswordRetype.AutoSize = true;
            this.lblPasswordRetype.Location = new System.Drawing.Point(265, 262);
            this.lblPasswordRetype.Name = "lblPasswordRetype";
            this.lblPasswordRetype.Size = new System.Drawing.Size(156, 25);
            this.lblPasswordRetype.TabIndex = 2;
            this.lblPasswordRetype.Text = "Nhập lại mật khẩu";
            // 
            // inputUsername
            // 
            this.inputUsername.Location = new System.Drawing.Point(427, 84);
            this.inputUsername.Name = "inputUsername";
            this.inputUsername.Size = new System.Drawing.Size(215, 31);
            this.inputUsername.TabIndex = 3;
            // 
            // inputPassword
            // 
            this.inputPassword.Location = new System.Drawing.Point(427, 162);
            this.inputPassword.Name = "inputPassword";
            this.inputPassword.Size = new System.Drawing.Size(215, 31);
            this.inputPassword.TabIndex = 4;
            // 
            // inputRetype
            // 
            this.inputRetype.Location = new System.Drawing.Point(427, 262);
            this.inputRetype.Name = "inputRetype";
            this.inputRetype.Size = new System.Drawing.Size(215, 31);
            this.inputRetype.TabIndex = 5;
            // 
            // btnSignup
            // 
            this.btnSignup.Location = new System.Drawing.Point(359, 345);
            this.btnSignup.Name = "btnSignup";
            this.btnSignup.Size = new System.Drawing.Size(112, 34);
            this.btnSignup.TabIndex = 6;
            this.btnSignup.Text = "Đăng ký";
            this.btnSignup.UseVisualStyleBackColor = true;
            this.btnSignup.Click += new System.EventHandler(this.btnSignup_Click);
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.Location = new System.Drawing.Point(488, 345);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(41, 25);
            this.lblTest.TabIndex = 7;
            this.lblTest.Text = "test";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTest);
            this.Controls.Add(this.btnSignup);
            this.Controls.Add(this.inputRetype);
            this.Controls.Add(this.inputPassword);
            this.Controls.Add(this.inputUsername);
            this.Controls.Add(this.lblPasswordRetype);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblUsername;
        private Label lblPassword;
        private Label lblPasswordRetype;
        private TextBox inputUsername;
        private TextBox inputPassword;
        private TextBox inputRetype;
        private Button btnSignup;
        private Label lblTest;
    }
}