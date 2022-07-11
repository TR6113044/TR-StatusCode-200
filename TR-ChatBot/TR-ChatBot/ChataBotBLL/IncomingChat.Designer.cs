namespace TR_ChatBot.ChataBotBLL
{
    partial class IncomingChatUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.InChatUserControlPanel = new System.Windows.Forms.Panel();
            this.txtInChatBox = new System.Windows.Forms.TextBox();
            this.InChatpictureBox = new System.Windows.Forms.PictureBox();
            this.InChatUserControlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InChatpictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // InChatUserControlPanel
            // 
            this.InChatUserControlPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.InChatUserControlPanel.Controls.Add(this.txtInChatBox);
            this.InChatUserControlPanel.Location = new System.Drawing.Point(66, 19);
            this.InChatUserControlPanel.Name = "InChatUserControlPanel";
            this.InChatUserControlPanel.Size = new System.Drawing.Size(385, 51);
            this.InChatUserControlPanel.TabIndex = 0;
            // 
            // txtInChatBox
            // 
            this.txtInChatBox.BackColor = System.Drawing.Color.RoyalBlue;
            this.txtInChatBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInChatBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInChatBox.ForeColor = System.Drawing.Color.Transparent;
            this.txtInChatBox.Location = new System.Drawing.Point(3, 3);
            this.txtInChatBox.Multiline = true;
            this.txtInChatBox.Name = "txtInChatBox";
            this.txtInChatBox.ReadOnly = true;
            this.txtInChatBox.Size = new System.Drawing.Size(395, 46);
            this.txtInChatBox.TabIndex = 0;
            // 
            // InChatpictureBox
            // 
            this.InChatpictureBox.BackColor = System.Drawing.Color.Transparent;
            this.InChatpictureBox.BackgroundImage = global::TR_ChatBot.Properties.Resources.icons8_chatbot_48;
            this.InChatpictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.InChatpictureBox.Location = new System.Drawing.Point(13, 3);
            this.InChatpictureBox.Name = "InChatpictureBox";
            this.InChatpictureBox.Size = new System.Drawing.Size(47, 53);
            this.InChatpictureBox.TabIndex = 1;
            this.InChatpictureBox.TabStop = false;
            // 
            // IncomingChatUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.InChatpictureBox);
            this.Controls.Add(this.InChatUserControlPanel);
            this.Name = "IncomingChatUserControl";
            this.Size = new System.Drawing.Size(465, 80);
            this.InChatUserControlPanel.ResumeLayout(false);
            this.InChatUserControlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InChatpictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel InChatUserControlPanel;
        private System.Windows.Forms.PictureBox InChatpictureBox;
        private System.Windows.Forms.TextBox txtInChatBox;
    }
}
