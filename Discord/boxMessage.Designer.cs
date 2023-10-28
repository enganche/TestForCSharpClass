namespace Discord
{
    partial class BoxMessage
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
            this.userContent = new System.Windows.Forms.Label();
            this.friendContent = new System.Windows.Forms.Label();
            this.friendName = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.friendAvatar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.friendAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // userContent
            // 
            this.userContent.AutoSize = true;
            this.userContent.Location = new System.Drawing.Point(550, 0);
            this.userContent.MaximumSize = new System.Drawing.Size(680, 0);
            this.userContent.Name = "userContent";
            this.userContent.Size = new System.Drawing.Size(170, 25);
            this.userContent.TabIndex = 0;
            this.userContent.Text = "Đây là tin nhắn mẫu";
            // 
            // friendContent
            // 
            this.friendContent.AutoSize = true;
            this.friendContent.Location = new System.Drawing.Point(57, 25);
            this.friendContent.MaximumSize = new System.Drawing.Size(600, 0);
            this.friendContent.Name = "friendContent";
            this.friendContent.Size = new System.Drawing.Size(255, 25);
            this.friendContent.TabIndex = 1;
            this.friendContent.Text = "Đây là tin nhắn của người khác";
            // 
            // friendName
            // 
            this.friendName.AutoSize = true;
            this.friendName.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.friendName.Location = new System.Drawing.Point(57, 0);
            this.friendName.Name = "friendName";
            this.friendName.Size = new System.Drawing.Size(106, 21);
            this.friendName.TabIndex = 2;
            this.friendName.Text = "Tên người ta";
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.time.Location = new System.Drawing.Point(662, 43);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(55, 21);
            this.time.TabIndex = 3;
            this.time.Text = "10h37";
            this.time.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // friendAvatar
            // 
            this.friendAvatar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.friendAvatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.friendAvatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.friendAvatar.Location = new System.Drawing.Point(3, 2);
            this.friendAvatar.Name = "friendAvatar";
            this.friendAvatar.Size = new System.Drawing.Size(48, 48);
            this.friendAvatar.TabIndex = 4;
            this.friendAvatar.TabStop = false;
            // 
            // BoxMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.Controls.Add(this.friendAvatar);
            this.Controls.Add(this.time);
            this.Controls.Add(this.friendName);
            this.Controls.Add(this.friendContent);
            this.Controls.Add(this.userContent);
            this.Name = "BoxMessage";
            this.Size = new System.Drawing.Size(720, 72);
            ((System.ComponentModel.ISupportInitialize)(this.friendAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label userContent;
        private Label friendContent;
        private Label friendName;
        private Label time;
        private PictureBox friendAvatar;
    }
}
