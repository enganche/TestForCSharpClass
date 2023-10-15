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
    public partial class boxMessage : UserControl
    {
        public boxMessage()
        {
            InitializeComponent();
        }

        public void setUserMessage(string content)
        {
            userContent.Text = content;
            userContent.AutoSize = true;

            friendContent.Text = "";
            friendName.Text = "";

            friendAvatar.Visible = false;

            time.Text = "6h50";
        }

        public void setFriendMessage(string content, string name)
        {
            friendContent.Text = content;
            friendContent.AutoSize = true;

            friendName.Text = name;
            friendName.AutoSize = true;

            userContent.Text = "";
        }
    }
}
