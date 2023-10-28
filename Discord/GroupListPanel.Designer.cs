namespace Discord
{
    partial class GroupListPanel
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
            this.groupFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.lblChat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // groupFlowPanel
            // 
            this.groupFlowPanel.AutoSize = true;
            this.groupFlowPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupFlowPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.groupFlowPanel.Location = new System.Drawing.Point(3, 41);
            this.groupFlowPanel.Name = "groupFlowPanel";
            this.groupFlowPanel.Size = new System.Drawing.Size(0, 0);
            this.groupFlowPanel.TabIndex = 0;
            // 
            // lblChat
            // 
            this.lblChat.AutoSize = true;
            this.lblChat.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblChat.Location = new System.Drawing.Point(3, 0);
            this.lblChat.Name = "lblChat";
            this.lblChat.Size = new System.Drawing.Size(77, 38);
            this.lblChat.TabIndex = 1;
            this.lblChat.Text = "Chat";
            // 
            // GroupListPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblChat);
            this.Controls.Add(this.groupFlowPanel);
            this.Name = "GroupListPanel";
            this.Size = new System.Drawing.Size(240, 640);
            this.Load += new System.EventHandler(this.GroupListPanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FlowLayoutPanel groupFlowPanel;
        private Label lblChat;
    }
}
