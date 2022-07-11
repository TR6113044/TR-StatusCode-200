using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TR_ChatBot
{
    public partial class ChatBoatForm : Form
    {
        public ChatBoatForm()
        {
            InitializeComponent();
        }
        private async void ChatBoatForm_Load(object sender, EventArgs e)
        {
            var con = await obj.StartConversationAsync();
            string outputresult = await obj.SendMessageAsync("");
            AddIncommingMessage(outputresult);
        }

        private void btnSendMsg_Click(object sender, EventArgs e)
        {
            SendMessage();
        }

        int curTop = 10;
        CallBotServiceAsync obj = new CallBotServiceAsync();
        void AddIncommingMessage(string message)
        {
            var bubble = new ChataBotBLL.IncomingChatUserControl();
            PnlContainer.Controls.Add(bubble);
            bubble.Top = curTop;
            bubble.Width = PnlContainer.Width - 10;
           // bubble.BringToFront();
           // bubble.Dock = DockStyle.Top;
            bubble.Message = message;
            curTop += bubble.Height;
        }
        async void SendMessage()
        {
            
            if (txtMessageBox.Text.Trim().Length == 0) return;
            AddOutgoingMessage(txtMessageBox.Text);
            txtMessageBox.Text = string.Empty;

            LblStatus.Text = "Typing...";
            timer1.Start();
        }
        bool response = false;
        //bool gotincomemsg = false;
         async void AddOutgoingMessage(string message)
        {
            var bubble = new ChataBotBLL.OutGoingChatUserControl();
            PnlContainer.Controls.Add(bubble);
            bubble.Top = curTop;
            bubble.Width = PnlContainer.Width - 20;
            // bubble.BringToFront();
            // bubble.Dock = DockStyle.Top;
            bubble.Message = message;
            curTop += bubble.Height;

            //CallBotService obj = new CallBotService();
            //List<string> lst = obj.SayHello(txtMessageBox.Text);
            //string outputresult = "";
            //string input = "";
            //foreach (string item in lst)
            //{
            //    if (item.ToString().ToLower() != txtMessageBox.Text.ToLower() && item.ToString().ToLower() != "hello and welcome")
            //        outputresult += item + "\n";
            //    else if (item.ToString().ToLower() != "hello and welcome")
            //        input += txtMessageBox.Text;
            //}
            //if(outputresult!="")
            //{
            //    gotincomemsg = true;
            //}

            //calling async
            
           
            string outputresult =await obj.SendMessageAsync(txtMessageBox.Text);
          
            if (outputresult != "")
            {
                response = true;
            }
            AddIncommingMessage(outputresult);
        }

        private void txtMessageBox_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Return)
            {
                SendMessage();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            LblStatus.Text = "Online";
            //if (!gotincomemsg)
            //    AddIncommingMessage("Sorry Please Contact Other Resource,Thank You!");
        }

        private void ChatBoatForm_Shown(object sender, EventArgs e)
        {
            //AddIncommingMessage("Hello " + Environment.UserName + "Ask me anything :) .");
        }
    }
}
