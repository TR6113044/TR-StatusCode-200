namespace TR_ChatBot
{
    partial class ChatBoatForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatBoatForm));
            this.PnlBottom = new System.Windows.Forms.Panel();
            this.txtMessageBox = new System.Windows.Forms.TextBox();
            this.PnlContainer = new System.Windows.Forms.Panel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnSendMsg = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.OnlineStatusPictureBox = new System.Windows.Forms.PictureBox();
            this.LblStatus = new System.Windows.Forms.Label();
            this.LblChatbotName = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.PnlBottom.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OnlineStatusPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlBottom
            // 
            this.PnlBottom.BackColor = System.Drawing.Color.Transparent;
            this.PnlBottom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PnlBottom.Controls.Add(this.txtMessageBox);
            this.PnlBottom.Controls.Add(this.btnSendMsg);
            this.PnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlBottom.Location = new System.Drawing.Point(0, 521);
            this.PnlBottom.Name = "PnlBottom";
            this.PnlBottom.Size = new System.Drawing.Size(449, 55);
            this.PnlBottom.TabIndex = 1;
            // 
            // txtMessageBox
            // 
            this.txtMessageBox.Location = new System.Drawing.Point(10, 4);
            this.txtMessageBox.Multiline = true;
            this.txtMessageBox.Name = "txtMessageBox";
            this.txtMessageBox.Size = new System.Drawing.Size(362, 44);
            this.txtMessageBox.TabIndex = 2;
            this.txtMessageBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtMessageBox_KeyUp);
            // 
            // PnlContainer
            // 
            this.PnlContainer.AutoScroll = true;
            this.PnlContainer.BackColor = System.Drawing.Color.Transparent;
            this.PnlContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlContainer.Location = new System.Drawing.Point(0, 61);
            this.PnlContainer.Name = "PnlContainer";
            this.PnlContainer.Size = new System.Drawing.Size(449, 460);
            this.PnlContainer.TabIndex = 2;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnSendMsg
            // 
            this.btnSendMsg.BackColor = System.Drawing.Color.White;
            this.btnSendMsg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSendMsg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSendMsg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendMsg.ForeColor = System.Drawing.Color.White;
            this.btnSendMsg.Image = global::TR_ChatBot.Properties.Resources.icons8_email_send_48;
            this.btnSendMsg.Location = new System.Drawing.Point(378, 4);
            this.btnSendMsg.Name = "btnSendMsg";
            this.btnSendMsg.Size = new System.Drawing.Size(56, 45);
            this.btnSendMsg.TabIndex = 1;
            this.btnSendMsg.TabStop = false;
            this.btnSendMsg.UseVisualStyleBackColor = false;
            this.btnSendMsg.Click += new System.EventHandler(this.btnSendMsg_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.BackgroundImage = global::TR_ChatBot.Properties.Resources.Thomson_Reuters_Logo2;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.OnlineStatusPictureBox);
            this.panel1.Controls.Add(this.LblStatus);
            this.panel1.Controls.Add(this.LblChatbotName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(449, 61);
            this.panel1.TabIndex = 0;
            // 
            // OnlineStatusPictureBox
            // 
            this.OnlineStatusPictureBox.BackColor = System.Drawing.Color.DarkOrange;
            this.OnlineStatusPictureBox.BackgroundImage = global::TR_ChatBot.Properties.Resources.icons8_ok_16O;
            this.OnlineStatusPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.OnlineStatusPictureBox.Location = new System.Drawing.Point(65, 27);
            this.OnlineStatusPictureBox.Name = "OnlineStatusPictureBox";
            this.OnlineStatusPictureBox.Size = new System.Drawing.Size(20, 17);
            this.OnlineStatusPictureBox.TabIndex = 2;
            this.OnlineStatusPictureBox.TabStop = false;
            // 
            // LblStatus
            // 
            this.LblStatus.AutoSize = true;
            this.LblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.76F);
            this.LblStatus.ForeColor = System.Drawing.Color.Transparent;
            this.LblStatus.Location = new System.Drawing.Point(82, 27);
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(49, 17);
            this.LblStatus.TabIndex = 1;
            this.LblStatus.Text = "Online";
            // 
            // LblChatbotName
            // 
            this.LblChatbotName.AutoSize = true;
            this.LblChatbotName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblChatbotName.ForeColor = System.Drawing.Color.Transparent;
            this.LblChatbotName.Location = new System.Drawing.Point(62, 11);
            this.LblChatbotName.Name = "LblChatbotName";
            this.LblChatbotName.Size = new System.Drawing.Size(91, 16);
            this.LblChatbotName.TabIndex = 0;
            this.LblChatbotName.Text = "ChatBot-Desk";
            // 
            // ChatBoatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(449, 576);
            this.Controls.Add(this.PnlContainer);
            this.Controls.Add(this.PnlBottom);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChatBoatForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TR-ChatBot";
            this.Load += new System.EventHandler(this.ChatBoatForm_Load);
            this.Shown += new System.EventHandler(this.ChatBoatForm_Shown);
            this.PnlBottom.ResumeLayout(false);
            this.PnlBottom.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OnlineStatusPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LblChatbotName;
        private System.Windows.Forms.Label LblStatus;
        private System.Windows.Forms.Panel PnlBottom;
        private System.Windows.Forms.Panel PnlContainer;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button btnSendMsg;
        private System.Windows.Forms.TextBox txtMessageBox;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox OnlineStatusPictureBox;
        //private System.Windows.Forms.Panel PnlContainer;
    }
}

