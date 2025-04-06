namespace DemonList
{
    partial class Rules
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rules));
            this.rightBackground = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.Rules_header = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.BackButton_Leaderboard = new Guna.UI2.WinForms.Guna2Button();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.MovePanel = new Guna.UI2.WinForms.Guna2Panel();
            this.ExitButton = new Guna.UI2.WinForms.Guna2ControlBox();
            this.MinimizeButton = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.MovePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // rightBackground
            // 
            this.rightBackground.BackgroundImage = global::DemonList.Properties.Resources.wallpapermainright;
            this.rightBackground.Location = new System.Drawing.Point(917, 158);
            this.rightBackground.Name = "rightBackground";
            this.rightBackground.Size = new System.Drawing.Size(83, 552);
            this.rightBackground.TabIndex = 49;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackgroundImage = global::DemonList.Properties.Resources.wallpapermainright;
            this.guna2Panel1.Location = new System.Drawing.Point(-3, 158);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(107, 552);
            this.guna2Panel1.TabIndex = 50;
            // 
            // Rules_header
            // 
            this.Rules_header.AutoSize = true;
            this.Rules_header.BackColor = System.Drawing.Color.Transparent;
            this.Rules_header.Font = new System.Drawing.Font("Yu Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rules_header.Location = new System.Drawing.Point(457, 73);
            this.Rules_header.Name = "Rules_header";
            this.Rules_header.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Rules_header.Size = new System.Drawing.Size(105, 42);
            this.Rules_header.TabIndex = 52;
            this.Rules_header.Text = "Rules";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(155, 158);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(724, 552);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.guna2PictureBox1.TabIndex = 53;
            this.guna2PictureBox1.TabStop = false;
            // 
            // BackButton_Leaderboard
            // 
            this.BackButton_Leaderboard.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BackButton_Leaderboard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BackButton_Leaderboard.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BackButton_Leaderboard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BackButton_Leaderboard.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BackButton_Leaderboard.FocusedColor = System.Drawing.Color.Cyan;
            this.BackButton_Leaderboard.Font = new System.Drawing.Font("Segoe UI", 26.25F);
            this.BackButton_Leaderboard.ForeColor = System.Drawing.Color.White;
            this.BackButton_Leaderboard.Location = new System.Drawing.Point(-3, -2);
            this.BackButton_Leaderboard.Name = "BackButton_Leaderboard";
            this.BackButton_Leaderboard.Size = new System.Drawing.Size(51, 50);
            this.BackButton_Leaderboard.TabIndex = 54;
            this.BackButton_Leaderboard.Text = "<";
            this.BackButton_Leaderboard.Click += new System.EventHandler(this.BackButton_Leaderboard_Click);
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = null;
            // 
            // MovePanel
            // 
            this.MovePanel.BackColor = System.Drawing.Color.Transparent;
            this.MovePanel.Controls.Add(this.ExitButton);
            this.MovePanel.Controls.Add(this.MinimizeButton);
            this.MovePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MovePanel.Location = new System.Drawing.Point(0, 0);
            this.MovePanel.Name = "MovePanel";
            this.MovePanel.Size = new System.Drawing.Size(1007, 39);
            this.MovePanel.TabIndex = 55;
            this.MovePanel.UseTransparentBackground = true;
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.ExitButton.IconColor = System.Drawing.Color.White;
            this.ExitButton.Location = new System.Drawing.Point(962, 0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(45, 29);
            this.ExitButton.TabIndex = 16;
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizeButton.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.MinimizeButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.MinimizeButton.IconColor = System.Drawing.Color.White;
            this.MinimizeButton.Location = new System.Drawing.Point(911, 0);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(45, 29);
            this.MinimizeButton.TabIndex = 17;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.MovePanel;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // Rules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1024, 576);
            this.Controls.Add(this.MovePanel);
            this.Controls.Add(this.BackButton_Leaderboard);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.Rules_header);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.rightBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Rules";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rules";
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.MovePanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel rightBackground;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label Rules_header;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button BackButton_Leaderboard;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private Guna.UI2.WinForms.Guna2Panel MovePanel;
        private Guna.UI2.WinForms.Guna2ControlBox ExitButton;
        private Guna.UI2.WinForms.Guna2ControlBox MinimizeButton;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
    }
}