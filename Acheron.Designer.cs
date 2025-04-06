namespace DemonList
{
    partial class Acheron
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Acheron));
            this.Level_panel_Acheron = new Guna.UI2.WinForms.Guna2Panel();
            this.levelPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.BackButton_Acheron = new Guna.UI2.WinForms.Guna2Button();
            this.DemonListScoreNumber_Acheron = new Guna.UI.WinForms.GunaLabel();
            this.DemonListScore_Acheron = new Guna.UI.WinForms.GunaLabel();
            this.BorderPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.Creator_Acheron = new Guna.UI.WinForms.GunaLabel();
            this.AcheronLabel = new Guna.UI.WinForms.GunaLabel();
            this.panel_leaderboard = new Guna.UI2.WinForms.Guna2Panel();
            this.AcheronGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ExitButton = new Guna.UI2.WinForms.Guna2ControlBox();
            this.MinimizeButton = new Guna.UI2.WinForms.Guna2ControlBox();
            this.MovePanel = new Guna.UI2.WinForms.Guna2Panel();
            this.Acheron_DragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.Complete_Acheron = new Guna.UI2.WinForms.Guna2Button();
            this.Leaderboard_header = new System.Windows.Forms.Label();
            this.Level_panel_Acheron.SuspendLayout();
            this.levelPanel.SuspendLayout();
            this.panel_leaderboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AcheronGridView)).BeginInit();
            this.MovePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Level_panel_Acheron
            // 
            this.Level_panel_Acheron.AutoScroll = true;
            this.Level_panel_Acheron.BorderColor = System.Drawing.Color.Black;
            this.Level_panel_Acheron.BorderRadius = 1;
            this.Level_panel_Acheron.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.Level_panel_Acheron.BorderThickness = 1;
            this.Level_panel_Acheron.Controls.Add(this.levelPanel);
            this.Level_panel_Acheron.Controls.Add(this.BackButton_Acheron);
            this.Level_panel_Acheron.Controls.Add(this.DemonListScoreNumber_Acheron);
            this.Level_panel_Acheron.Controls.Add(this.DemonListScore_Acheron);
            this.Level_panel_Acheron.Controls.Add(this.BorderPanel);
            this.Level_panel_Acheron.Controls.Add(this.Creator_Acheron);
            this.Level_panel_Acheron.Controls.Add(this.AcheronLabel);
            this.Level_panel_Acheron.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Level_panel_Acheron.Location = new System.Drawing.Point(103, 50);
            this.Level_panel_Acheron.Name = "Level_panel_Acheron";
            this.Level_panel_Acheron.Size = new System.Drawing.Size(819, 671);
            this.Level_panel_Acheron.TabIndex = 34;
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
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // BackButton_Acheron
            // 
            this.BackButton_Acheron.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BackButton_Acheron.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BackButton_Acheron.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BackButton_Acheron.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BackButton_Acheron.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BackButton_Acheron.ForeColor = System.Drawing.Color.White;
            this.BackButton_Acheron.Location = new System.Drawing.Point(4, 3);
            this.BackButton_Acheron.Name = "BackButton_Acheron";
            this.BackButton_Acheron.Size = new System.Drawing.Size(57, 45);
            this.BackButton_Acheron.TabIndex = 5;
            this.BackButton_Acheron.Text = "<";
            this.BackButton_Acheron.Click += new System.EventHandler(this.BackButton_Acheron_Click);
            // 
            // DemonListScoreNumber_Acheron
            // 
            this.DemonListScoreNumber_Acheron.AutoSize = true;
            this.DemonListScoreNumber_Acheron.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DemonListScoreNumber_Acheron.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DemonListScoreNumber_Acheron.Location = new System.Drawing.Point(366, 627);
            this.DemonListScoreNumber_Acheron.Name = "DemonListScoreNumber_Acheron";
            this.DemonListScoreNumber_Acheron.Size = new System.Drawing.Size(90, 32);
            this.DemonListScoreNumber_Acheron.TabIndex = 5;
            this.DemonListScoreNumber_Acheron.Text = "313.42";
            this.DemonListScoreNumber_Acheron.Click += new System.EventHandler(this.DemonListScoreNumber_Acheron_Click);
            // 
            // DemonListScore_Acheron
            // 
            this.DemonListScore_Acheron.AutoSize = true;
            this.DemonListScore_Acheron.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DemonListScore_Acheron.Location = new System.Drawing.Point(311, 595);
            this.DemonListScore_Acheron.Name = "DemonListScore_Acheron";
            this.DemonListScore_Acheron.Size = new System.Drawing.Size(201, 32);
            this.DemonListScore_Acheron.TabIndex = 4;
            this.DemonListScore_Acheron.Text = "Demonlist score";
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
            // Creator_Acheron
            // 
            this.Creator_Acheron.AutoSize = true;
            this.Creator_Acheron.Font = new System.Drawing.Font("Segoe UI Symbol", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Creator_Acheron.Location = new System.Drawing.Point(139, 91);
            this.Creator_Acheron.Name = "Creator_Acheron";
            this.Creator_Acheron.Size = new System.Drawing.Size(529, 40);
            this.Creator_Acheron.TabIndex = 1;
            this.Creator_Acheron.Text = "by ryamu and more, verified by Zoink";
            // 
            // AcheronLabel
            // 
            this.AcheronLabel.AutoSize = true;
            this.AcheronLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AcheronLabel.Location = new System.Drawing.Point(264, 18);
            this.AcheronLabel.Name = "AcheronLabel";
            this.AcheronLabel.Size = new System.Drawing.Size(279, 73);
            this.AcheronLabel.TabIndex = 0;
            this.AcheronLabel.Text = "Acheron";
            this.AcheronLabel.Click += new System.EventHandler(this.AcheronLabel_Click);
            // 
            // panel_leaderboard
            // 
            this.panel_leaderboard.Controls.Add(this.AcheronGridView);
            this.panel_leaderboard.Location = new System.Drawing.Point(315, 800);
            this.panel_leaderboard.Name = "panel_leaderboard";
            this.panel_leaderboard.Size = new System.Drawing.Size(385, 343);
            this.panel_leaderboard.TabIndex = 35;
            // 
            // AcheronGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.AcheronGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AcheronGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.AcheronGridView.ColumnHeadersHeight = 4;
            this.AcheronGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AcheronGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.AcheronGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AcheronGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.AcheronGridView.Location = new System.Drawing.Point(0, 0);
            this.AcheronGridView.Name = "AcheronGridView";
            this.AcheronGridView.RowHeadersVisible = false;
            this.AcheronGridView.Size = new System.Drawing.Size(385, 343);
            this.AcheronGridView.TabIndex = 0;
            this.AcheronGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.AcheronGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.AcheronGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.AcheronGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.AcheronGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.AcheronGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.AcheronGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.AcheronGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.AcheronGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.AcheronGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AcheronGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.AcheronGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.AcheronGridView.ThemeStyle.HeaderStyle.Height = 4;
            this.AcheronGridView.ThemeStyle.ReadOnly = false;
            this.AcheronGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.AcheronGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.AcheronGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AcheronGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.AcheronGridView.ThemeStyle.RowsStyle.Height = 22;
            this.AcheronGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.AcheronGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.ExitButton.IconColor = System.Drawing.Color.White;
            this.ExitButton.Location = new System.Drawing.Point(979, 0);
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
            this.MinimizeButton.Location = new System.Drawing.Point(928, 0);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(45, 29);
            this.MinimizeButton.TabIndex = 17;
            // 
            // MovePanel
            // 
            this.MovePanel.BackColor = System.Drawing.Color.Transparent;
            this.MovePanel.Controls.Add(this.ExitButton);
            this.MovePanel.Controls.Add(this.MinimizeButton);
            this.MovePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MovePanel.Location = new System.Drawing.Point(0, 0);
            this.MovePanel.Name = "MovePanel";
            this.MovePanel.Size = new System.Drawing.Size(1024, 37);
            this.MovePanel.TabIndex = 36;
            this.MovePanel.UseTransparentBackground = true;
            // 
            // Acheron_DragControl
            // 
            this.Acheron_DragControl.DockIndicatorTransparencyValue = 0.6D;
            this.Acheron_DragControl.TargetControl = this.MovePanel;
            this.Acheron_DragControl.UseTransparentDrag = true;
            // 
            // Complete_Acheron
            // 
            this.Complete_Acheron.Animated = true;
            this.Complete_Acheron.AutoRoundedCorners = true;
            this.Complete_Acheron.BorderRadius = 19;
            this.Complete_Acheron.DialogResult = System.Windows.Forms.DialogResult.Retry;
            this.Complete_Acheron.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Complete_Acheron.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Complete_Acheron.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Complete_Acheron.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Complete_Acheron.FillColor = System.Drawing.Color.Crimson;
            this.Complete_Acheron.FocusedColor = System.Drawing.Color.IndianRed;
            this.Complete_Acheron.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Complete_Acheron.ForeColor = System.Drawing.Color.White;
            this.Complete_Acheron.Location = new System.Drawing.Point(492, 754);
            this.Complete_Acheron.Name = "Complete_Acheron";
            this.Complete_Acheron.Size = new System.Drawing.Size(43, 40);
            this.Complete_Acheron.TabIndex = 56;
            this.Complete_Acheron.Click += new System.EventHandler(this.Complete_Acheron_Click);
            // 
            // Leaderboard_header
            // 
            this.Leaderboard_header.AutoSize = true;
            this.Leaderboard_header.BackColor = System.Drawing.Color.Transparent;
            this.Leaderboard_header.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Leaderboard_header.Location = new System.Drawing.Point(453, 724);
            this.Leaderboard_header.Name = "Leaderboard_header";
            this.Leaderboard_header.Size = new System.Drawing.Size(128, 27);
            this.Leaderboard_header.TabIndex = 55;
            this.Leaderboard_header.Text = "Completed?";
            // 
            // Acheron
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1041, 576);
            this.Controls.Add(this.Complete_Acheron);
            this.Controls.Add(this.Leaderboard_header);
            this.Controls.Add(this.MovePanel);
            this.Controls.Add(this.panel_leaderboard);
            this.Controls.Add(this.Level_panel_Acheron);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Acheron";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acheron";
            this.Load += new System.EventHandler(this.Acheron_Load);
            this.Level_panel_Acheron.ResumeLayout(false);
            this.Level_panel_Acheron.PerformLayout();
            this.levelPanel.ResumeLayout(false);
            this.panel_leaderboard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AcheronGridView)).EndInit();
            this.MovePanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel Level_panel_Acheron;
        private Guna.UI2.WinForms.Guna2Panel levelPanel;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private Guna.UI2.WinForms.Guna2Button BackButton_Acheron;
        private Guna.UI.WinForms.GunaLabel DemonListScoreNumber_Acheron;
        private Guna.UI.WinForms.GunaLabel DemonListScore_Acheron;
        private Guna.UI2.WinForms.Guna2Panel BorderPanel;
        private Guna.UI.WinForms.GunaLabel Creator_Acheron;
        private Guna.UI.WinForms.GunaLabel AcheronLabel;
        private Guna.UI2.WinForms.Guna2Panel panel_leaderboard;
        private Guna.UI2.WinForms.Guna2ControlBox ExitButton;
        private Guna.UI2.WinForms.Guna2ControlBox MinimizeButton;
        private Guna.UI2.WinForms.Guna2Panel MovePanel;
        private Guna.UI2.WinForms.Guna2DragControl Acheron_DragControl;
        private Guna.UI2.WinForms.Guna2Button Complete_Acheron;
        private System.Windows.Forms.Label Leaderboard_header;
        private Guna.UI2.WinForms.Guna2DataGridView AcheronGridView;
    }
}