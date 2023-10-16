using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Discord
{

  public partial class MessageForm : Form
  {
    List<Message> messageList = new List<Message>();

    public MessageForm()
    {
      InitializeComponent();
      loadSample();
      loadMessage();
    }

    private void btnSendMessage_Click(object sender, EventArgs e)
    {
      if (txtMessageInput.Text != "")
      {
        handleSendMessage();
      }
    }

    private void txtMessageInput_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Enter)
      {
        handleSendMessage();
      }
    }

    private void handleSendMessage()
    {
      string text = txtMessageInput.Text.ToString();

      Message msg = new Message(true, text);
      messageList.Add(msg);

      loadFakeReceiveMessage();

      loadMessage();

      txtMessageInput.Text = "";

    }

    private void loadMessage()
    {
      panelMessage.Controls.Clear();
      panelMessage.Size = new Size(panelMessage.Width, messageList.Count * 39);

      for (int i = 0; i < messageList.Count; i++)
      {
        boxMessage message = new boxMessage();

        Message msg = messageList[i];

        if (msg.IsUser)
        {
          message.setUserMessage(msg.Content);
          message.BackColor = Color.AliceBlue;
        }

        else
        {
          message.setFriendMessage(msg.Content, msg.Name);
        }

        message.Location = new Point(0, i > 0 ? panelMessage.Controls[i - 1].Location.Y + message.Size.Height : 0);
        Console.WriteLine(message.Location);

        panelMessage.Controls.Add(message);
      }

      panelMessage.VerticalScroll.Value = panelMessage.VerticalScroll.Maximum;
      //foreach (var msg in messageList)
      //{
      //    boxMessage message = new boxMessage();

      //    if (msg.IsUser)
      //    {
      //        message.setUserMessage(msg.Content);
      //        message.BackColor = Color.AliceBlue;
      //    }

      //    else
      //    {
      //        message.setFriendMessage(msg.Content, msg.Name);
      //    }

      //    message.Location = new Point(0, ((messageList.IndexOf(msg) * 64) + 64));

      //    panelMessage.Controls.Add(message);
      //    panelMessage.VerticalScroll.Value = panelMessage.VerticalScroll.Maximum;
      //}
    }

    private void loadSample()
    {

      Message msg = new Message(false, "VNA", "123", "");
      messageList.Add(msg);

      msg = new Message(false, "VNA", "Alo", "");
      messageList.Add(msg);

      msg = new Message(true, "Chào các bạn");
      messageList.Add(msg);

      msg = new Message(true, "Hello");
      messageList.Add(msg);

      msg = new Message(false, "VNA", "Alo", "");
      messageList.Add(msg);

      msg = new Message(false, "VNA", "Alo", "");
      messageList.Add(msg);

      msg = new Message(false, "VNA", "Alo", "");
      messageList.Add(msg);

      msg = new Message(false, "VNA", "Alo", "");
      messageList.Add(msg);
    }

    private void loadFakeReceiveMessage()
    {
      Random random = new Random();

      int i = random.Next(1, 6);

      switch (i)
      {
        case 1:
          Message msg = new Message(false, "Levi", "Hello Tuấn", "");
          messageList.Add(msg);

          msg = new Message(false, "Kati", "Xin chào Tuấn", "");
          messageList.Add(msg);
          break;
        case 2:
          msg = new Message(false, "Artemis", "Chào chị Ngân", "");
          messageList.Add(msg);

          msg = new Message(false, "Glory", "Hello chị Ngân", "");
          messageList.Add(msg);
          break;
        case 4:
          msg = new Message(false, "Deft", "<3", "");
          messageList.Add(msg);

          msg = new Message(false, "Chovi", "Chào ae!!!", "");
          messageList.Add(msg);
          break;
        case 5:
          msg = new Message(false, "Thầy Thảo", "@@", "");
          messageList.Add(msg);

          msg = new Message(false, "Felix Pham", "???", "");
          messageList.Add(msg);
          break;
        default:
          break;
      }


    }

  }
}
