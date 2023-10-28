namespace Discord
{
    partial class BoxGroup
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
            this.txtLastTime = new System.Windows.Forms.Label();
            this.txtLastMessage = new System.Windows.Forms.Label();
            this.txtGroupName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtLastTime
            // 
            this.txtLastTime.AutoSize = true;
            this.txtLastTime.Location = new System.Drawing.Point(175, 7);
            this.txtLastTime.Name = "txtLastTime";
            this.txtLastTime.Size = new System.Drawing.Size(62, 25);
            this.txtLastTime.TabIndex = 1;
            this.txtLastTime.Text = "10h37";
            this.txtLastTime.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtLastMessage
            // 
            this.txtLastMessage.AutoSize = true;
            this.txtLastMessage.Location = new System.Drawing.Point(3, 32);
            this.txtLastMessage.Name = "txtLastMessage";
            this.txtLastMessage.Size = new System.Drawing.Size(170, 25);
            this.txtLastMessage.TabIndex = 2;
            this.txtLastMessage.Text = "Đây là tin nhắn mẫu";
            // 
            // txtGroupName
            // 
            this.txtGroupName.AutoSize = true;
            this.txtGroupName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtGroupName.Location = new System.Drawing.Point(0, 0);
            this.txtGroupName.Name = "txtGroupName";
            this.txtGroupName.Size = new System.Drawing.Size(88, 28);
            this.txtGroupName.TabIndex = 3;
            this.txtGroupName.Text = "Nhóm 1";
            // 
            // BoxGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.txtGroupName);
            this.Controls.Add(this.txtLastMessage);
            this.Controls.Add(this.txtLastTime);
            this.Name = "BoxGroup";
            this.Size = new System.Drawing.Size(240, 60);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label txtLastTime;
        private Label txtLastMessage;
        private Label txtGroupName;
    }
}
