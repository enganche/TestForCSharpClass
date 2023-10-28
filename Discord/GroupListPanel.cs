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
    public partial class GroupListPanel : UserControl
    {
        public GroupListPanel()
        {
            InitializeComponent();
        }

        private void GroupListPanel_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {   
                BoxGroup groupBox = new BoxGroup();
                groupBox.setGroup("Nhóm " + i.ToString(), i % 2 == 0 ? "10h37" : "6h50", "Tin nhắn mẫu");
                groupFlowPanel.Controls.Add(groupBox);

            }

        }
    }
}
