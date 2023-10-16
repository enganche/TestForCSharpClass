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
      txtMessageInput = new RichTextBox();
      btnSendMessage = new Button();
      lblGroupName = new Label();
      panelMessage = new Panel();
      flowLayoutPanel1 = new FlowLayoutPanel();
      flowLayoutPanel1.SuspendLayout();
      SuspendLayout();
      // 
      // txtMessageInput
      // 
      txtMessageInput.BackColor = SystemColors.Window;
      txtMessageInput.Location = new Point(8, 280);
      txtMessageInput.Margin = new Padding(2);
      txtMessageInput.Name = "txtMessageInput";
      txtMessageInput.Size = new Size(498, 32);
      txtMessageInput.TabIndex = 0;
      txtMessageInput.Text = "";
      txtMessageInput.KeyDown += txtMessageInput_KeyDown;
      // 
      // btnSendMessage
      // 
      btnSendMessage.Cursor = Cursors.Hand;
      btnSendMessage.Location = new Point(509, 280);
      btnSendMessage.Margin = new Padding(2);
      btnSendMessage.Name = "btnSendMessage";
      btnSendMessage.Size = new Size(88, 31);
      btnSendMessage.TabIndex = 1;
      btnSendMessage.Text = "Gửi";
      btnSendMessage.UseVisualStyleBackColor = true;
      btnSendMessage.Click += btnSendMessage_Click;
      // 
      // lblGroupName
      // 
      lblGroupName.AutoSize = true;
      lblGroupName.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
      lblGroupName.Location = new Point(8, 5);
      lblGroupName.Margin = new Padding(2, 0, 2, 0);
      lblGroupName.Name = "lblGroupName";
      lblGroupName.Size = new Size(100, 25);
      lblGroupName.TabIndex = 2;
      lblGroupName.Text = "Tên nhóm";
      // 
      // panelMessage
      // 
      panelMessage.AutoScroll = true;
      panelMessage.Location = new Point(2, 2);
      panelMessage.Margin = new Padding(2);
      panelMessage.Name = "panelMessage";
      panelMessage.Size = new Size(580, 247);
      panelMessage.TabIndex = 5;
      // 
      // flowLayoutPanel1
      // 
      flowLayoutPanel1.AutoScroll = true;
      flowLayoutPanel1.Controls.Add(panelMessage);
      flowLayoutPanel1.Location = new Point(12, 33);
      flowLayoutPanel1.Name = "flowLayoutPanel1";
      flowLayoutPanel1.Size = new Size(582, 242);
      flowLayoutPanel1.TabIndex = 0;
      // 
      // MessageForm
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(606, 318);
      Controls.Add(flowLayoutPanel1);
      Controls.Add(lblGroupName);
      Controls.Add(btnSendMessage);
      Controls.Add(txtMessageInput);
      Margin = new Padding(2);
      Name = "MessageForm";
      Text = "MessageForm";
      flowLayoutPanel1.ResumeLayout(false);
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private RichTextBox txtMessageInput;
    private Button btnSendMessage;
    private Label lblGroupName;
    private Panel panelMessage;
    private FlowLayoutPanel flowLayoutPanel1;
  }
}