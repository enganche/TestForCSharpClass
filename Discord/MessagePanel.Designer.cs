namespace Discord
{
    partial class MessagePanel
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
            this.txtMessageInput = new System.Windows.Forms.RichTextBox();
            this.btnSendMessage = new System.Windows.Forms.Button();
            this.lblGroupName = new System.Windows.Forms.Label();
            this.displayMessagePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // txtMessageInput
            // 
            this.txtMessageInput.BackColor = System.Drawing.SystemColors.Window;
            this.txtMessageInput.Location = new System.Drawing.Point(3, 586);
            this.txtMessageInput.Multiline = false;
            this.txtMessageInput.Name = "txtMessageInput";
            this.txtMessageInput.Size = new System.Drawing.Size(628, 51);
            this.txtMessageInput.TabIndex = 1;
            this.txtMessageInput.Text = "";
            this.txtMessageInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMessageInput_KeyDown);
            // 
            // btnSendMessage
            // 
            this.btnSendMessage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSendMessage.Location = new System.Drawing.Point(637, 585);
            this.btnSendMessage.Name = "btnSendMessage";
            this.btnSendMessage.Size = new System.Drawing.Size(126, 52);
            this.btnSendMessage.TabIndex = 2;
            this.btnSendMessage.Text = "Gửi";
            this.btnSendMessage.UseVisualStyleBackColor = true;
            this.btnSendMessage.Click += new System.EventHandler(this.btnSendMessage_Click);
            // 
            // lblGroupName
            // 
            this.lblGroupName.AutoSize = true;
            this.lblGroupName.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGroupName.Location = new System.Drawing.Point(3, 0);
            this.lblGroupName.Name = "lblGroupName";
            this.lblGroupName.Size = new System.Drawing.Size(147, 38);
            this.lblGroupName.TabIndex = 3;
            this.lblGroupName.Text = "Tên nhóm";
            // 
            // displayMessagePanel
            // 
            this.displayMessagePanel.AutoScroll = true;
            this.displayMessagePanel.Location = new System.Drawing.Point(3, 41);
            this.displayMessagePanel.Name = "displayMessagePanel";
            this.displayMessagePanel.Size = new System.Drawing.Size(760, 539);
            this.displayMessagePanel.TabIndex = 4;
            // 
            // MessagePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.displayMessagePanel);
            this.Controls.Add(this.lblGroupName);
            this.Controls.Add(this.btnSendMessage);
            this.Controls.Add(this.txtMessageInput);
            this.Name = "MessagePanel";
            this.Size = new System.Drawing.Size(772, 640);
            this.Load += new System.EventHandler(this.MessagePanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox txtMessageInput;
        private Button btnSendMessage;
        private Label lblGroupName;
        private FlowLayoutPanel displayMessagePanel;
    }
}
