namespace Discord
{
    partial class userMessage
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
            this.content = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // content
            // 
            this.content.AutoSize = true;
            this.content.Location = new System.Drawing.Point(457, 0);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(260, 25);
            this.content.TabIndex = 0;
            this.content.Text = "Đây cũng là đoạn tin nhắn mẫu";
            this.content.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // userMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.content);
            this.Name = "userMessage";
            this.Size = new System.Drawing.Size(720, 64);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label content;
    }
}
