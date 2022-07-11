namespace TR_ChatBot.ChataBotBLL
{
    partial class OutGoingChatUserControl
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
            this.OutChatUserControlPanel = new System.Windows.Forms.Panel();
            this.txtInChatBox = new System.Windows.Forms.TextBox();
            this.OutChatUserpictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.OutChatUserpictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // OutChatUserControlPanel
            // 
            this.OutChatUserControlPanel.BackColor = System.Drawing.Color.Transparent;
            this.OutChatUserControlPanel.Location = new System.Drawing.Point(3, 13);
            this.OutChatUserControlPanel.Name = "OutChatUserControlPanel";
            this.OutChatUserControlPanel.Size = new System.Drawing.Size(385, 51);
            this.OutChatUserControlPanel.TabIndex = 0;
            // 
            // txtInChatBox
            // 
            this.txtInChatBox.BackColor = System.Drawing.Color.LightSkyBlue;
            this.txtInChatBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInChatBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInChatBox.ForeColor = System.Drawing.Color.Transparent;
            this.txtInChatBox.Location = new System.Drawing.Point(3, 13);
            this.txtInChatBox.Multiline = true;
            this.txtInChatBox.Name = "txtInChatBox";
            this.txtInChatBox.ReadOnly = true;
            this.txtInChatBox.Size = new System.Drawing.Size(379, 46);
            this.txtInChatBox.TabIndex = 0;
            // 
            // OutChatUserpictureBox
            // 
            this.OutChatUserpictureBox.BackColor = System.Drawing.Color.Transparent;
            this.OutChatUserpictureBox.BackgroundImage = global::TR_ChatBot.Properties.Resources.icons8_npc_face_48;
            this.OutChatUserpictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.OutChatUserpictureBox.Location = new System.Drawing.Point(388, 3);
            this.OutChatUserpictureBox.Name = "OutChatUserpictureBox";
            this.OutChatUserpictureBox.Size = new System.Drawing.Size(43, 48);
            this.OutChatUserpictureBox.TabIndex = 2;
            this.OutChatUserpictureBox.TabStop = false;
            // 
            // OutGoingChatUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.txtInChatBox);
            this.Controls.Add(this.OutChatUserpictureBox);
            this.Controls.Add(this.OutChatUserControlPanel);
            this.Name = "OutGoingChatUserControl";
            this.Size = new System.Drawing.Size(453, 69);
            this.DockChanged += new System.EventHandler(this.OutGoingChatUserControl_DockChanged);
            ((System.ComponentModel.ISupportInitialize)(this.OutChatUserpictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel OutChatUserControlPanel;
        private System.Windows.Forms.TextBox txtInChatBox;
        private System.Windows.Forms.PictureBox OutChatUserpictureBox;
    }
}
