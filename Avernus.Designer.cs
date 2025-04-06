namespace DemonList
{
    partial class Avernus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Avernus));
            this.MovePanel = new Guna.UI2.WinForms.Guna2Panel();
            this.ExitButton = new Guna.UI2.WinForms.Guna2ControlBox();
            this.MinimizeButton = new Guna.UI2.WinForms.Guna2ControlBox();
            this.Level_panel_Avernus = new Guna.UI2.WinForms.Guna2Panel();
            this.levelPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.BackButton_Avernus = new Guna.UI2.WinForms.Guna2Button();
            this.DemonListScoreNumber_Avernus = new Guna.UI.WinForms.GunaLabel();
            this.DemonListScore_Avernus = new Guna.UI.WinForms.GunaLabel();
            this.BorderPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.Creator_Avernus = new Guna.UI.WinForms.GunaLabel();
            this.AvernusLabel = new Guna.UI.WinForms.GunaLabel();
            this.Avernus_DragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.Leaderboard_header = new System.Windows.Forms.Label();
            this.Complete_Avernus = new Guna.UI2.WinForms.Guna2Button();
            this.AvernusGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel_leaderboard = new Guna.UI2.WinForms.Guna2Panel();
            this.MovePanel.SuspendLayout();
            this.Level_panel_Avernus.SuspendLayout();
            this.levelPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AvernusGridView)).BeginInit();
            this.panel_leaderboard.SuspendLayout();
            this.SuspendLayout();
            // 
            // MovePanel
            // 
            this.MovePanel.BackColor = System.Drawing.Color.Transparent;
            this.MovePanel.Controls.Add(this.ExitButton);
            this.MovePanel.Controls.Add(this.MinimizeButton);
            this.MovePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MovePanel.Location = new System.Drawing.Point(0, 0);
            this.MovePanel.Name = "MovePanel";
            this.MovePanel.Size = new System.Drawing.Size(1024, 36);
            this.MovePanel.TabIndex = 32;
            this.MovePanel.UseTransparentBackground = true;
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
            // Level_panel_Avernus
            // 
            this.Level_panel_Avernus.BorderColor = System.Drawing.Color.Black;
            this.Level_panel_Avernus.BorderRadius = 1;
            this.Level_panel_Avernus.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.Level_panel_Avernus.BorderThickness = 1;
            this.Level_panel_Avernus.Controls.Add(this.levelPanel);
            this.Level_panel_Avernus.Controls.Add(this.BackButton_Avernus);
            this.Level_panel_Avernus.Controls.Add(this.DemonListScoreNumber_Avernus);
            this.Level_panel_Avernus.Controls.Add(this.DemonListScore_Avernus);
            this.Level_panel_Avernus.Controls.Add(this.BorderPanel);
            this.Level_panel_Avernus.Controls.Add(this.Creator_Avernus);
            this.Level_panel_Avernus.Controls.Add(this.AvernusLabel);
            this.Level_panel_Avernus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Level_panel_Avernus.Location = new System.Drawing.Point(97, 43);
            this.Level_panel_Avernus.Name = "Level_panel_Avernus";
            this.Level_panel_Avernus.Size = new System.Drawing.Size(819, 671);
            this.Level_panel_Avernus.TabIndex = 33;
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
            // BackButton_Avernus
            // 
            this.BackButton_Avernus.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BackButton_Avernus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BackButton_Avernus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BackButton_Avernus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BackButton_Avernus.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BackButton_Avernus.ForeColor = System.Drawing.Color.White;
            this.BackButton_Avernus.Location = new System.Drawing.Point(4, 3);
            this.BackButton_Avernus.Name = "BackButton_Avernus";
            this.BackButton_Avernus.Size = new System.Drawing.Size(57, 45);
            this.BackButton_Avernus.TabIndex = 5;
            this.BackButton_Avernus.Text = "<";
            this.BackButton_Avernus.Click += new System.EventHandler(this.BackButton_Avernus_Click_1);
            // 
            // DemonListScoreNumber_Avernus
            // 
            this.DemonListScoreNumber_Avernus.AutoSize = true;
            this.DemonListScoreNumber_Avernus.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DemonListScoreNumber_Avernus.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DemonListScoreNumber_Avernus.Location = new System.Drawing.Point(366, 627);
            this.DemonListScoreNumber_Avernus.Name = "DemonListScoreNumber_Avernus";
            this.DemonListScoreNumber_Avernus.Size = new System.Drawing.Size(90, 32);
            this.DemonListScoreNumber_Avernus.TabIndex = 5;
            this.DemonListScoreNumber_Avernus.Text = "331.71";
            // 
            // DemonListScore_Avernus
            // 
            this.DemonListScore_Avernus.AutoSize = true;
            this.DemonListScore_Avernus.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DemonListScore_Avernus.Location = new System.Drawing.Point(311, 595);
            this.DemonListScore_Avernus.Name = "DemonListScore_Avernus";
            this.DemonListScore_Avernus.Size = new System.Drawing.Size(201, 32);
            this.DemonListScore_Avernus.TabIndex = 4;
            this.DemonListScore_Avernus.Text = "Demonlist score";
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
            // Creator_Avernus
            // 
            this.Creator_Avernus.AutoSize = true;
            this.Creator_Avernus.Font = new System.Drawing.Font("Segoe UI Symbol", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Creator_Avernus.Location = new System.Drawing.Point(56, 91);
            this.Creator_Avernus.Name = "Creator_Avernus";
            this.Creator_Avernus.Size = new System.Drawing.Size(733, 40);
            this.Creator_Avernus.TabIndex = 1;
            this.Creator_Avernus.Text = "by PockeWindFish and more, verified by [AUF] Zoink";
            this.Creator_Avernus.Click += new System.EventHandler(this.Creator_Avernus_Click);
            // 
            // AvernusLabel
            // 
            this.AvernusLabel.AutoSize = true;
            this.AvernusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AvernusLabel.Location = new System.Drawing.Point(264, 18);
            this.AvernusLabel.Name = "AvernusLabel";
            this.AvernusLabel.Size = new System.Drawing.Size(275, 73);
            this.AvernusLabel.TabIndex = 0;
            this.AvernusLabel.Text = "Avernus";
            // 
            // Avernus_DragControl
            // 
            this.Avernus_DragControl.DockIndicatorTransparencyValue = 0.6D;
            this.Avernus_DragControl.TargetControl = this.MovePanel;
            this.Avernus_DragControl.UseTransparentDrag = true;
            // 
            // Leaderboard_header
            // 
            this.Leaderboard_header.AutoSize = true;
            this.Leaderboard_header.BackColor = System.Drawing.Color.Transparent;
            this.Leaderboard_header.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Leaderboard_header.Location = new System.Drawing.Point(451, 717);
            this.Leaderboard_header.Name = "Leaderboard_header";
            this.Leaderboard_header.Size = new System.Drawing.Size(128, 27);
            this.Leaderboard_header.TabIndex = 53;
            this.Leaderboard_header.Text = "Completed?";
            // 
            // Complete_Avernus
            // 
            this.Complete_Avernus.Animated = true;
            this.Complete_Avernus.AutoRoundedCorners = true;
            this.Complete_Avernus.BorderRadius = 19;
            this.Complete_Avernus.DialogResult = System.Windows.Forms.DialogResult.Retry;
            this.Complete_Avernus.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Complete_Avernus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Complete_Avernus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Complete_Avernus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Complete_Avernus.FillColor = System.Drawing.Color.Crimson;
            this.Complete_Avernus.FocusedColor = System.Drawing.Color.IndianRed;
            this.Complete_Avernus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Complete_Avernus.ForeColor = System.Drawing.Color.White;
            this.Complete_Avernus.Location = new System.Drawing.Point(490, 747);
            this.Complete_Avernus.Name = "Complete_Avernus";
            this.Complete_Avernus.Size = new System.Drawing.Size(43, 40);
            this.Complete_Avernus.TabIndex = 54;
            this.Complete_Avernus.Click += new System.EventHandler(this.Complete_Avernus_Click);
            // 
            // AvernusGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.AvernusGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AvernusGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.AvernusGridView.ColumnHeadersHeight = 4;
            this.AvernusGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AvernusGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.AvernusGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AvernusGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.AvernusGridView.Location = new System.Drawing.Point(0, 0);
            this.AvernusGridView.Name = "AvernusGridView";
            this.AvernusGridView.RowHeadersVisible = false;
            this.AvernusGridView.Size = new System.Drawing.Size(385, 343);
            this.AvernusGridView.TabIndex = 0;
            this.AvernusGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.AvernusGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.AvernusGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.AvernusGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.AvernusGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.AvernusGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.AvernusGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.AvernusGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.AvernusGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.AvernusGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AvernusGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.AvernusGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.AvernusGridView.ThemeStyle.HeaderStyle.Height = 4;
            this.AvernusGridView.ThemeStyle.ReadOnly = false;
            this.AvernusGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.AvernusGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.AvernusGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AvernusGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.AvernusGridView.ThemeStyle.RowsStyle.Height = 22;
            this.AvernusGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.AvernusGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.AvernusGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AvernusGridView_CellContentClick);
            // 
            // panel_leaderboard
            // 
            this.panel_leaderboard.Controls.Add(this.AvernusGridView);
            this.panel_leaderboard.Location = new System.Drawing.Point(328, 811);
            this.panel_leaderboard.Name = "panel_leaderboard";
            this.panel_leaderboard.Size = new System.Drawing.Size(385, 343);
            this.panel_leaderboard.TabIndex = 34;
            // 
            // Avernus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1041, 576);
            this.Controls.Add(this.Complete_Avernus);
            this.Controls.Add(this.Leaderboard_header);
            this.Controls.Add(this.panel_leaderboard);
            this.Controls.Add(this.Level_panel_Avernus);
            this.Controls.Add(this.MovePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Avernus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Avernus";
            this.Load += new System.EventHandler(this.Avernus_Load);
            this.MovePanel.ResumeLayout(false);
            this.Level_panel_Avernus.ResumeLayout(false);
            this.Level_panel_Avernus.PerformLayout();
            this.levelPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AvernusGridView)).EndInit();
            this.panel_leaderboard.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel MovePanel;
        private Guna.UI2.WinForms.Guna2ControlBox ExitButton;
        private Guna.UI2.WinForms.Guna2ControlBox MinimizeButton;
        private Guna.UI2.WinForms.Guna2Panel Level_panel_Avernus;
        private Guna.UI2.WinForms.Guna2Panel levelPanel;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private Guna.UI2.WinForms.Guna2Button BackButton_Avernus;
        private Guna.UI.WinForms.GunaLabel DemonListScoreNumber_Avernus;
        private Guna.UI.WinForms.GunaLabel DemonListScore_Avernus;
        private Guna.UI2.WinForms.Guna2Panel BorderPanel;
        private Guna.UI.WinForms.GunaLabel Creator_Avernus;
        private Guna.UI.WinForms.GunaLabel AvernusLabel;
        private Guna.UI2.WinForms.Guna2DragControl Avernus_DragControl;
        private System.Windows.Forms.Label Leaderboard_header;
        private Guna.UI2.WinForms.Guna2Button Complete_Avernus;
        private Guna.UI2.WinForms.Guna2DataGridView AvernusGridView;
        private Guna.UI2.WinForms.Guna2Panel panel_leaderboard;
    }
}