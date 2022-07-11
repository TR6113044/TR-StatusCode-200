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
    public partial class IncomingChatUserControl : UserControl
    {
        public IncomingChatUserControl()
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
        public Image Avatar
        {

            get => InChatpictureBox.Image;
            set => InChatpictureBox.Image = value;
        }
        void AdjustHeight()
        {
            InChatpictureBox.Location = new Point(4, 3);
            txtInChatBox.Height = Utils.GetTextBoxTextHeight(txtInChatBox) + 10;
            InChatUserControlPanel.Height = txtInChatBox.Top + InChatpictureBox.Top + txtInChatBox.Height;
            this.Height = InChatUserControlPanel.Bottom + 10;
        }

        private void Incomming_Resize(object sender , EventArgs e)
        {
            AdjustHeight();
        }

    }
}
