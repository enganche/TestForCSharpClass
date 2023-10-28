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
    public partial class BoxMessage : UserControl
    {
        public BoxMessage()
        {
            InitializeComponent();
        }

        public void setUserMessage(string content)
        {
            userContent.Text = content;
            userContent.AutoSize = true;

            userContent.Location = new Point(this.Size.Width - userContent.Size.Width, userContent.Location.Y);

            friendContent.Text = "";
            friendName.Text = "";

            friendAvatar.Visible = false;

            time.Text = "6h50";

            setBoxMessageSize(userContent.Size.Height);
        }

        public void setFriendMessage(string content, string name)
        {
            friendContent.Text = content;
            friendContent.AutoSize = true;

            friendName.Text = name;
            friendName.AutoSize = true;

            userContent.Text = "";

            setBoxMessageSize(friendContent.Size.Height);
        }

        private void setBoxMessageSize(int contentSize)
        {
            Size = new Size(Size.Width, contentSize + 32);
            time.Location = new Point(time.Location.X, contentSize);
        }
    }
}
