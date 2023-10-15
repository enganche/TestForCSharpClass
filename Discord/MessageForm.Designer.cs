namespace Discord
{
    partial class MessageForm
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
            this.txtMessageInput = new System.Windows.Forms.RichTextBox();
            this.btnSendMessage = new System.Windows.Forms.Button();
            this.lblGroupName = new System.Windows.Forms.Label();
            this.panelMessage = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // txtMessageInput
            // 
            this.txtMessageInput.BackColor = System.Drawing.SystemColors.Window;
            this.txtMessageInput.Location = new System.Drawing.Point(12, 467);
            this.txtMessageInput.Name = "txtMessageInput";
            this.txtMessageInput.Size = new System.Drawing.Size(709, 51);
            this.txtMessageInput.TabIndex = 0;
            this.txtMessageInput.Text = "";
            this.txtMessageInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMessageInput_KeyDown);
            // 
            // btnSendMessage
            // 
            this.btnSendMessage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSendMessage.Location = new System.Drawing.Point(727, 467);
            this.btnSendMessage.Name = "btnSendMessage";
            this.btnSendMessage.Size = new System.Drawing.Size(126, 51);
            this.btnSendMessage.TabIndex = 1;
            this.btnSendMessage.Text = "Gửi";
            this.btnSendMessage.UseVisualStyleBackColor = true;
            this.btnSendMessage.Click += new System.EventHandler(this.btnSendMessage_Click);
            // 
            // lblGroupName
            // 
            this.lblGroupName.AutoSize = true;
            this.lblGroupName.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGroupName.Location = new System.Drawing.Point(12, 9);
            this.lblGroupName.Name = "lblGroupName";
            this.lblGroupName.Size = new System.Drawing.Size(147, 38);
            this.lblGroupName.TabIndex = 2;
            this.lblGroupName.Text = "Tên nhóm";
            // 
            // panelMessage
            // 
            this.panelMessage.AutoScroll = true;
            this.panelMessage.Location = new System.Drawing.Point(12, 50);
            this.panelMessage.Name = "panelMessage";
            this.panelMessage.Size = new System.Drawing.Size(841, 411);
            this.panelMessage.TabIndex = 5;
            // 
            // MessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 530);
            this.Controls.Add(this.panelMessage);
            this.Controls.Add(this.lblGroupName);
            this.Controls.Add(this.btnSendMessage);
            this.Controls.Add(this.txtMessageInput);
            this.Name = "MessageForm";
            this.Text = "MessageForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox txtMessageInput;
        private Button btnSendMessage;
        private Label lblGroupName;
        private Panel panelMessage;
    }
}