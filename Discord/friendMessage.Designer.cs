namespace Discord
{
    partial class friendMessage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.avatar = new System.Windows.Forms.PictureBox();
            this.userName = new System.Windows.Forms.Label();
            this.content = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // avatar
            // 
            this.avatar.Location = new System.Drawing.Point(3, 3);
            this.avatar.Name = "avatar";
            this.avatar.Size = new System.Drawing.Size(48, 48);
            this.avatar.TabIndex = 0;
            this.avatar.TabStop = false;
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.userName.Location = new System.Drawing.Point(57, 3);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(144, 25);
            this.userName.TabIndex = 1;
            this.userName.Text = "Tên người dùng";
            // 
            // content
            // 
            this.content.AutoSize = true;
            this.content.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.content.Location = new System.Drawing.Point(57, 28);
            this.content.MaximumSize = new System.Drawing.Size(720, 48);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(201, 28);
            this.content.TabIndex = 2;
            this.content.Text = "Đây là đoạn chat mẫu";
            // 
            // friendMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.content);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.avatar);
            this.Name = "friendMessage";
            this.Size = new System.Drawing.Size(720, 64);
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox avatar;
        private Label userName;
        private Label content;
    }
}
