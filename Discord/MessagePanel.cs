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
    public partial class MessagePanel : UserControl
    {
        List<Message> messageList = new List<Message>();

        public MessagePanel()
        {
            InitializeComponent();
        }

        private void MessagePanel_Load(object sender, EventArgs e)
        {
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
            displayMessagePanel.Controls.Clear();

            for (int i = 0; i < messageList.Count; i++)
            {
                BoxMessage message = new BoxMessage();

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
                Random rnd = new Random();
                message.Location = new Point(displayMessagePanel.Size.Width, displayMessagePanel.Size.Height);
                Console.WriteLine(message.Location);

                displayMessagePanel.Controls.Add(message);
            }

            displayMessagePanel.VerticalScroll.Value = displayMessagePanel.VerticalScroll.Maximum;
        }

        private void loadSample()
        {

            Message msg = new Message(false, "VNA", "123", "");
            messageList.Add(msg);

            msg = new Message(false, "VNA", "Mong admin duyệt bài. Thật sự khi thấy ds học bổng e rất buồn vì mình đã cố gắng  rất nhiều mà kết quả chẳng như ý. Bao nhiêu công sức ko dc đền đáp. Bên cạnh đó e thấy khi đi thi có 1 số bạn sử dụng điện thoại và tài liệu nhưng giám thị vẫn không bắt(không biết có phải ko thấy ko?). Mình thì cũng chỉ tập trung làm bài chứ ko chẳng muốn tố cáo sợ bị trả thù. Mong các thầy cô có thể coi thi gắt gao hơn và làm hết trách nhiệm của người giám thị để kết quả học bổng dc công bằng ko ạ?", "");
            messageList.Add(msg);

            msg = new Message(true, "Chào các bạn");
            messageList.Add(msg);

            msg = new Message(true, "Hello");
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

    class Message
    {
        public bool IsUser { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public string Avatar { get; set; }

        public Message(bool isUser, string content)
        {
            IsUser = isUser;
            Content = content;
        }

        public Message(bool isUser, string name, string content, string avatar)
        {
            IsUser = isUser;
            Name = name;
            Content = content;
            Avatar = avatar;
        }

    }
}
