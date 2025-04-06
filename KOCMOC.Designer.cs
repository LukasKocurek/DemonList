namespace DemonList
{
    partial class KOCMOC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KOCMOC));
            this.MovePanel = new Guna.UI2.WinForms.Guna2Panel();
            this.ExitButton = new Guna.UI2.WinForms.Guna2ControlBox();
            this.MinimizeButton = new Guna.UI2.WinForms.Guna2ControlBox();
            this.Level_panel_KOCMOC = new Guna.UI2.WinForms.Guna2Panel();
            this.levelPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.BackButton_KOCMOC = new Guna.UI2.WinForms.Guna2Button();
            this.DemonListScoreNumber_KOCMOC = new Guna.UI.WinForms.GunaLabel();
            this.DemonListScore_KOCMOC = new Guna.UI.WinForms.GunaLabel();
            this.BorderPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.Creator_KOCMOC = new Guna.UI.WinForms.GunaLabel();
            this.KOCMOCLabel = new Guna.UI.WinForms.GunaLabel();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.Complete_KOCMOC = new Guna.UI2.WinForms.Guna2Button();
            this.Leaderboard_header = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.KOCMOCGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.MovePanel.SuspendLayout();
            this.Level_panel_KOCMOC.SuspendLayout();
            this.levelPanel.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KOCMOCGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // MovePanel
            // 
            this.MovePanel.AutoScroll = true;
            this.MovePanel.BackColor = System.Drawing.Color.Transparent;
            this.MovePanel.Controls.Add(this.ExitButton);
            this.MovePanel.Controls.Add(this.MinimizeButton);
            this.MovePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MovePanel.Location = new System.Drawing.Point(0, 0);
            this.MovePanel.Name = "MovePanel";
            this.MovePanel.Size = new System.Drawing.Size(1007, 35);
            this.MovePanel.TabIndex = 45;
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
            // Level_panel_KOCMOC
            // 
            this.Level_panel_KOCMOC.AutoScroll = true;
            this.Level_panel_KOCMOC.BorderColor = System.Drawing.Color.Black;
            this.Level_panel_KOCMOC.BorderRadius = 1;
            this.Level_panel_KOCMOC.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.Level_panel_KOCMOC.BorderThickness = 1;
            this.Level_panel_KOCMOC.Controls.Add(this.levelPanel);
            this.Level_panel_KOCMOC.Controls.Add(this.BackButton_KOCMOC);
            this.Level_panel_KOCMOC.Controls.Add(this.DemonListScoreNumber_KOCMOC);
            this.Level_panel_KOCMOC.Controls.Add(this.DemonListScore_KOCMOC);
            this.Level_panel_KOCMOC.Controls.Add(this.BorderPanel);
            this.Level_panel_KOCMOC.Controls.Add(this.Creator_KOCMOC);
            this.Level_panel_KOCMOC.Controls.Add(this.KOCMOCLabel);
            this.Level_panel_KOCMOC.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Level_panel_KOCMOC.Location = new System.Drawing.Point(109, 43);
            this.Level_panel_KOCMOC.Name = "Level_panel_KOCMOC";
            this.Level_panel_KOCMOC.Size = new System.Drawing.Size(819, 684);
            this.Level_panel_KOCMOC.TabIndex = 46;
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
            // BackButton_KOCMOC
            // 
            this.BackButton_KOCMOC.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BackButton_KOCMOC.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BackButton_KOCMOC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BackButton_KOCMOC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BackButton_KOCMOC.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BackButton_KOCMOC.ForeColor = System.Drawing.Color.White;
            this.BackButton_KOCMOC.Location = new System.Drawing.Point(4, 3);
            this.BackButton_KOCMOC.Name = "BackButton_KOCMOC";
            this.BackButton_KOCMOC.Size = new System.Drawing.Size(57, 45);
            this.BackButton_KOCMOC.TabIndex = 5;
            this.BackButton_KOCMOC.Text = "<";
            this.BackButton_KOCMOC.Click += new System.EventHandler(this.BackButton_KOCMOC_Click);
            // 
            // DemonListScoreNumber_KOCMOC
            // 
            this.DemonListScoreNumber_KOCMOC.AutoSize = true;
            this.DemonListScoreNumber_KOCMOC.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DemonListScoreNumber_KOCMOC.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DemonListScoreNumber_KOCMOC.Location = new System.Drawing.Point(360, 627);
            this.DemonListScoreNumber_KOCMOC.Name = "DemonListScoreNumber_KOCMOC";
            this.DemonListScoreNumber_KOCMOC.Size = new System.Drawing.Size(90, 32);
            this.DemonListScoreNumber_KOCMOC.TabIndex = 5;
            this.DemonListScoreNumber_KOCMOC.Text = "194.54";
            // 
            // DemonListScore_KOCMOC
            // 
            this.DemonListScore_KOCMOC.AutoSize = true;
            this.DemonListScore_KOCMOC.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DemonListScore_KOCMOC.Location = new System.Drawing.Point(311, 595);
            this.DemonListScore_KOCMOC.Name = "DemonListScore_KOCMOC";
            this.DemonListScore_KOCMOC.Size = new System.Drawing.Size(201, 32);
            this.DemonListScore_KOCMOC.TabIndex = 4;
            this.DemonListScore_KOCMOC.Text = "Demonlist score";
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
            // Creator_KOCMOC
            // 
            this.Creator_KOCMOC.AutoSize = true;
            this.Creator_KOCMOC.Font = new System.Drawing.Font("Segoe UI Symbol", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Creator_KOCMOC.Location = new System.Drawing.Point(144, 91);
            this.Creator_KOCMOC.Name = "Creator_KOCMOC";
            this.Creator_KOCMOC.Size = new System.Drawing.Size(542, 40);
            this.Creator_KOCMOC.TabIndex = 1;
            this.Creator_KOCMOC.Text = "by cherryteam, verified by [AUF] Zoink";
            // 
            // KOCMOCLabel
            // 
            this.KOCMOCLabel.AutoSize = true;
            this.KOCMOCLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.KOCMOCLabel.Location = new System.Drawing.Point(252, 18);
            this.KOCMOCLabel.Name = "KOCMOCLabel";
            this.KOCMOCLabel.Size = new System.Drawing.Size(326, 73);
            this.KOCMOCLabel.TabIndex = 0;
            this.KOCMOCLabel.Text = "KOCMOC";
            this.KOCMOCLabel.UseMnemonic = false;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.MovePanel;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2DragControl2
            // 
            this.guna2DragControl2.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl2.UseTransparentDrag = true;
            // 
            // Complete_KOCMOC
            // 
            this.Complete_KOCMOC.Animated = true;
            this.Complete_KOCMOC.AutoRoundedCorners = true;
            this.Complete_KOCMOC.BorderRadius = 19;
            this.Complete_KOCMOC.DialogResult = System.Windows.Forms.DialogResult.Retry;
            this.Complete_KOCMOC.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Complete_KOCMOC.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Complete_KOCMOC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Complete_KOCMOC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Complete_KOCMOC.FillColor = System.Drawing.Color.Crimson;
            this.Complete_KOCMOC.FocusedColor = System.Drawing.Color.IndianRed;
            this.Complete_KOCMOC.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Complete_KOCMOC.ForeColor = System.Drawing.Color.White;
            this.Complete_KOCMOC.Location = new System.Drawing.Point(486, 760);
            this.Complete_KOCMOC.Name = "Complete_KOCMOC";
            this.Complete_KOCMOC.Size = new System.Drawing.Size(43, 40);
            this.Complete_KOCMOC.TabIndex = 70;
            this.Complete_KOCMOC.Click += new System.EventHandler(this.Complete_KOCMOC_Click);
            // 
            // Leaderboard_header
            // 
            this.Leaderboard_header.AutoSize = true;
            this.Leaderboard_header.BackColor = System.Drawing.Color.Transparent;
            this.Leaderboard_header.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Leaderboard_header.Location = new System.Drawing.Point(447, 730);
            this.Leaderboard_header.Name = "Leaderboard_header";
            this.Leaderboard_header.Size = new System.Drawing.Size(128, 27);
            this.Leaderboard_header.TabIndex = 69;
            this.Leaderboard_header.Text = "Completed?";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.KOCMOCGridView);
            this.guna2Panel1.Location = new System.Drawing.Point(319, 806);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(385, 343);
            this.guna2Panel1.TabIndex = 71;
            // 
            // KOCMOCGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.KOCMOCGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.KOCMOCGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.KOCMOCGridView.ColumnHeadersHeight = 4;
            this.KOCMOCGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.KOCMOCGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.KOCMOCGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KOCMOCGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.KOCMOCGridView.Location = new System.Drawing.Point(0, 0);
            this.KOCMOCGridView.Name = "KOCMOCGridView";
            this.KOCMOCGridView.RowHeadersVisible = false;
            this.KOCMOCGridView.Size = new System.Drawing.Size(385, 343);
            this.KOCMOCGridView.TabIndex = 0;
            this.KOCMOCGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.KOCMOCGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.KOCMOCGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.KOCMOCGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.KOCMOCGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.KOCMOCGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.KOCMOCGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.KOCMOCGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.KOCMOCGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.KOCMOCGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.KOCMOCGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.KOCMOCGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.KOCMOCGridView.ThemeStyle.HeaderStyle.Height = 4;
            this.KOCMOCGridView.ThemeStyle.ReadOnly = false;
            this.KOCMOCGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.KOCMOCGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.KOCMOCGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.KOCMOCGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.KOCMOCGridView.ThemeStyle.RowsStyle.Height = 22;
            this.KOCMOCGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.KOCMOCGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.KOCMOCGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.KOCMOCGridView_CellContentClick);
            // 
            // KOCMOC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1024, 576);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.Complete_KOCMOC);
            this.Controls.Add(this.Leaderboard_header);
            this.Controls.Add(this.Level_panel_KOCMOC);
            this.Controls.Add(this.MovePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KOCMOC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KOCMOC";
            this.Load += new System.EventHandler(this.KOCMOC_Load);
            this.MovePanel.ResumeLayout(false);
            this.Level_panel_KOCMOC.ResumeLayout(false);
            this.Level_panel_KOCMOC.PerformLayout();
            this.levelPanel.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.KOCMOCGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel MovePanel;
        private Guna.UI2.WinForms.Guna2ControlBox ExitButton;
        private Guna.UI2.WinForms.Guna2ControlBox MinimizeButton;
        private Guna.UI2.WinForms.Guna2Panel Level_panel_KOCMOC;
        private Guna.UI2.WinForms.Guna2Panel levelPanel;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private Guna.UI2.WinForms.Guna2Button BackButton_KOCMOC;
        private Guna.UI.WinForms.GunaLabel DemonListScoreNumber_KOCMOC;
        private Guna.UI.WinForms.GunaLabel DemonListScore_KOCMOC;
        private Guna.UI2.WinForms.Guna2Panel BorderPanel;
        private Guna.UI.WinForms.GunaLabel Creator_KOCMOC;
        private Guna.UI.WinForms.GunaLabel KOCMOCLabel;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl2;
        private Guna.UI2.WinForms.Guna2Button Complete_KOCMOC;
        private System.Windows.Forms.Label Leaderboard_header;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2DataGridView KOCMOCGridView;
    }
}