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
    public partial class BoxGroup : UserControl
    {
        public BoxGroup()
        {
            InitializeComponent();
        }

        public void setGroup(string groupName, string lastTime, string lastMessage)
        {
            txtGroupName.Text = groupName;
            txtLastTime.Text = lastTime;
            txtLastMessage.Text = lastMessage;
        }
    }
}
