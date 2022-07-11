using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TR_ChatBot.ChataBotBLL
{
    public partial class OutGoingChatUserControl : UserControl
    {
        public OutGoingChatUserControl()
        {
            InitializeComponent();
        }
        public string Message
        {
            get

            {
                return txtInChatBox.Text;
            }
            set

            {
                txtInChatBox.Text = value;
                AdjustHeight();
            }
        }

        void AdjustHeight()
        {
            txtInChatBox.Height = Utils.GetTextBoxTextHeight(txtInChatBox) + 10;
            OutChatUserControlPanel.Height = txtInChatBox.Top + OutChatUserControlPanel.Top + txtInChatBox.Height;
            this.Height = OutChatUserControlPanel.Bottom + 10;
        }

        private void IncomingChatUserControl_Resize(object sender, EventArgs e)
        {
            AdjustHeight();
        }

        private void OutGoingChatUserControl_DockChanged(object sender, EventArgs e)
        {
            AdjustHeight();
        }
    }
}
