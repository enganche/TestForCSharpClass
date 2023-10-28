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
            this.groupListPanel1 = new Discord.GroupListPanel();
            this.messagePanel1 = new Discord.MessagePanel();
            this.SuspendLayout();
            // 
            // groupListPanel1
            // 
            this.groupListPanel1.AutoScroll = true;
            this.groupListPanel1.Location = new System.Drawing.Point(12, 9);
            this.groupListPanel1.Name = "groupListPanel1";
            this.groupListPanel1.Size = new System.Drawing.Size(280, 640);
            this.groupListPanel1.TabIndex = 1;
            // 
            // messagePanel1
            // 
            this.messagePanel1.Location = new System.Drawing.Point(298, 9);
            this.messagePanel1.Name = "messagePanel1";
            this.messagePanel1.Size = new System.Drawing.Size(770, 640);
            this.messagePanel1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 657);
            this.Controls.Add(this.messagePanel1);
            this.Controls.Add(this.groupListPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private GroupListPanel groupListPanel1;
        private MessagePanel messagePanel1;
    }
}