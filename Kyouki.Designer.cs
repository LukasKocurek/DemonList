namespace DemonList
{
    partial class Kyouki
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kyouki));
            this.Level_panel_Kyouki = new Guna.UI2.WinForms.Guna2Panel();
            this.levelPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.BackButton_Kyouki = new Guna.UI2.WinForms.Guna2Button();
            this.DemonListScoreNumber_Kyouki = new Guna.UI.WinForms.GunaLabel();
            this.DemonListScore_Kyouki = new Guna.UI.WinForms.GunaLabel();
            this.BorderPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.Creator_Kyouki = new Guna.UI.WinForms.GunaLabel();
            this.KyoukiLabel = new Guna.UI.WinForms.GunaLabel();
            this.MovePanel = new Guna.UI2.WinForms.Guna2Panel();
            this.ExitButton = new Guna.UI2.WinForms.Guna2ControlBox();
            this.MinimizeButton = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.Complete_Kyouki = new Guna.UI2.WinForms.Guna2Button();
            this.Leaderboard_header = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.KyoukiGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Level_panel_Kyouki.SuspendLayout();
            this.levelPanel.SuspendLayout();
            this.MovePanel.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KyoukiGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Level_panel_Kyouki
            // 
            this.Level_panel_Kyouki.AutoScroll = true;
            this.Level_panel_Kyouki.BorderColor = System.Drawing.Color.Black;
            this.Level_panel_Kyouki.BorderRadius = 1;
            this.Level_panel_Kyouki.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.Level_panel_Kyouki.BorderThickness = 1;
            this.Level_panel_Kyouki.Controls.Add(this.levelPanel);
            this.Level_panel_Kyouki.Controls.Add(this.BackButton_Kyouki);
            this.Level_panel_Kyouki.Controls.Add(this.DemonListScoreNumber_Kyouki);
            this.Level_panel_Kyouki.Controls.Add(this.DemonListScore_Kyouki);
            this.Level_panel_Kyouki.Controls.Add(this.BorderPanel);
            this.Level_panel_Kyouki.Controls.Add(this.Creator_Kyouki);
            this.Level_panel_Kyouki.Controls.Add(this.KyoukiLabel);
            this.Level_panel_Kyouki.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Level_panel_Kyouki.Location = new System.Drawing.Point(117, 46);
            this.Level_panel_Kyouki.Name = "Level_panel_Kyouki";
            this.Level_panel_Kyouki.Size = new System.Drawing.Size(819, 671);
            this.Level_panel_Kyouki.TabIndex = 37;
            // 
            // levelPanel
            // 
            this.levelPanel.Controls.Add(this.webBrowser1);
            this.levelPanel.Location = new System.Drawing.Point(4, 160);
            this.levelPanel.Name = "levelPanel";
            this.levelPanel.Size = new System.Drawing.Size(812, 435);
            this.levelPanel.TabIndex = 6;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(812, 435);
            this.webBrowser1.TabIndex = 0;
            // 
            // BackButton_Kyouki
            // 
            this.BackButton_Kyouki.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BackButton_Kyouki.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BackButton_Kyouki.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BackButton_Kyouki.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BackButton_Kyouki.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BackButton_Kyouki.ForeColor = System.Drawing.Color.White;
            this.BackButton_Kyouki.Location = new System.Drawing.Point(4, 3);
            this.BackButton_Kyouki.Name = "BackButton_Kyouki";
            this.BackButton_Kyouki.Size = new System.Drawing.Size(57, 45);
            this.BackButton_Kyouki.TabIndex = 5;
            this.BackButton_Kyouki.Text = "<";
            this.BackButton_Kyouki.Click += new System.EventHandler(this.BackButton_AOD_Click);
            // 
            // DemonListScoreNumber_Kyouki
            // 
            this.DemonListScoreNumber_Kyouki.AutoSize = true;
            this.DemonListScoreNumber_Kyouki.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DemonListScoreNumber_Kyouki.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DemonListScoreNumber_Kyouki.Location = new System.Drawing.Point(360, 627);
            this.DemonListScoreNumber_Kyouki.Name = "DemonListScoreNumber_Kyouki";
            this.DemonListScoreNumber_Kyouki.Size = new System.Drawing.Size(90, 32);
            this.DemonListScoreNumber_Kyouki.TabIndex = 5;
            this.DemonListScoreNumber_Kyouki.Text = "253.53";
            this.DemonListScoreNumber_Kyouki.Click += new System.EventHandler(this.DemonListScoreNumber_Kyouki_Click);
            // 
            // DemonListScore_Kyouki
            // 
            this.DemonListScore_Kyouki.AutoSize = true;
            this.DemonListScore_Kyouki.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DemonListScore_Kyouki.Location = new System.Drawing.Point(311, 595);
            this.DemonListScore_Kyouki.Name = "DemonListScore_Kyouki";
            this.DemonListScore_Kyouki.Size = new System.Drawing.Size(201, 32);
            this.DemonListScore_Kyouki.TabIndex = 4;
            this.DemonListScore_Kyouki.Text = "Demonlist score";
            // 
            // BorderPanel
            // 
            this.BorderPanel.BorderColor = System.Drawing.Color.Black;
            this.BorderPanel.BorderRadius = 2;
            this.BorderPanel.BorderThickness = 2;
            this.BorderPanel.Location = new System.Drawing.Point(0, 144);
            this.BorderPanel.Name = "BorderPanel";
            this.BorderPanel.Size = new System.Drawing.Size(819, 10);
            this.BorderPanel.TabIndex = 2;
            // 
            // Creator_Kyouki
            // 
            this.Creator_Kyouki.AutoSize = true;
            this.Creator_Kyouki.Font = new System.Drawing.Font("Segoe UI Symbol", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Creator_Kyouki.Location = new System.Drawing.Point(302, 91);
            this.Creator_Kyouki.Name = "Creator_Kyouki";
            this.Creator_Kyouki.Size = new System.Drawing.Size(208, 40);
            this.Creator_Kyouki.TabIndex = 1;
            this.Creator_Kyouki.Text = "by ｛出見塩｝";
            // 
            // KyoukiLabel
            // 
            this.KyoukiLabel.AutoSize = true;
            this.KyoukiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.KyoukiLabel.Location = new System.Drawing.Point(296, 18);
            this.KyoukiLabel.Name = "KyoukiLabel";
            this.KyoukiLabel.Size = new System.Drawing.Size(231, 73);
            this.KyoukiLabel.TabIndex = 0;
            this.KyoukiLabel.Text = "Kyouki";
            this.KyoukiLabel.Click += new System.EventHandler(this.SilentClubstepLabel_Click);
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
            this.MovePanel.TabIndex = 41;
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
            // Complete_Kyouki
            // 
            this.Complete_Kyouki.Animated = true;
            this.Complete_Kyouki.AutoRoundedCorners = true;
            this.Complete_Kyouki.BorderRadius = 19;
            this.Complete_Kyouki.DialogResult = System.Windows.Forms.DialogResult.Retry;
            this.Complete_Kyouki.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Complete_Kyouki.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Complete_Kyouki.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Complete_Kyouki.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Complete_Kyouki.FillColor = System.Drawing.Color.Crimson;
            this.Complete_Kyouki.FocusedColor = System.Drawing.Color.IndianRed;
            this.Complete_Kyouki.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Complete_Kyouki.ForeColor = System.Drawing.Color.White;
            this.Complete_Kyouki.Location = new System.Drawing.Point(498, 750);
            this.Complete_Kyouki.Name = "Complete_Kyouki";
            this.Complete_Kyouki.Size = new System.Drawing.Size(43, 40);
            this.Complete_Kyouki.TabIndex = 62;
            this.Complete_Kyouki.Click += new System.EventHandler(this.Complete_Kyouki_Click);
            // 
            // Leaderboard_header
            // 
            this.Leaderboard_header.AutoSize = true;
            this.Leaderboard_header.BackColor = System.Drawing.Color.Transparent;
            this.Leaderboard_header.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Leaderboard_header.Location = new System.Drawing.Point(460, 720);
            this.Leaderboard_header.Name = "Leaderboard_header";
            this.Leaderboard_header.Size = new System.Drawing.Size(128, 27);
            this.Leaderboard_header.TabIndex = 61;
            this.Leaderboard_header.Text = "Completed?";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.KyoukiGridView);
            this.guna2Panel1.Location = new System.Drawing.Point(331, 796);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(385, 343);
            this.guna2Panel1.TabIndex = 63;
            // 
            // KyoukiGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.KyoukiGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.KyoukiGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.KyoukiGridView.ColumnHeadersHeight = 4;
            this.KyoukiGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.KyoukiGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.KyoukiGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KyoukiGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.KyoukiGridView.Location = new System.Drawing.Point(0, 0);
            this.KyoukiGridView.Name = "KyoukiGridView";
            this.KyoukiGridView.RowHeadersVisible = false;
            this.KyoukiGridView.Size = new System.Drawing.Size(385, 343);
            this.KyoukiGridView.TabIndex = 0;
            this.KyoukiGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.KyoukiGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.KyoukiGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.KyoukiGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.KyoukiGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.KyoukiGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.KyoukiGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.KyoukiGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.KyoukiGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.KyoukiGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.KyoukiGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.KyoukiGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.KyoukiGridView.ThemeStyle.HeaderStyle.Height = 4;
            this.KyoukiGridView.ThemeStyle.ReadOnly = false;
            this.KyoukiGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.KyoukiGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.KyoukiGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.KyoukiGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.KyoukiGridView.ThemeStyle.RowsStyle.Height = 22;
            this.KyoukiGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.KyoukiGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Kyouki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1024, 576);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.Complete_Kyouki);
            this.Controls.Add(this.Leaderboard_header);
            this.Controls.Add(this.MovePanel);
            this.Controls.Add(this.Level_panel_Kyouki);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Kyouki";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kyouki";
            this.Load += new System.EventHandler(this.Kyouki_Load);
            this.Level_panel_Kyouki.ResumeLayout(false);
            this.Level_panel_Kyouki.PerformLayout();
            this.levelPanel.ResumeLayout(false);
            this.MovePanel.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.KyoukiGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel Level_panel_Kyouki;
        private Guna.UI2.WinForms.Guna2Panel levelPanel;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private Guna.UI2.WinForms.Guna2Button BackButton_Kyouki;
        private Guna.UI.WinForms.GunaLabel DemonListScoreNumber_Kyouki;
        private Guna.UI.WinForms.GunaLabel DemonListScore_Kyouki;
        private Guna.UI2.WinForms.Guna2Panel BorderPanel;
        private Guna.UI.WinForms.GunaLabel Creator_Kyouki;
        private Guna.UI.WinForms.GunaLabel KyoukiLabel;
        private Guna.UI2.WinForms.Guna2Panel MovePanel;
        private Guna.UI2.WinForms.Guna2ControlBox ExitButton;
        private Guna.UI2.WinForms.Guna2ControlBox MinimizeButton;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Button Complete_Kyouki;
        private System.Windows.Forms.Label Leaderboard_header;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2DataGridView KyoukiGridView;
    }
}