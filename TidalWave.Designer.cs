namespace DemonList
{
    partial class TidalWave
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TidalWave));
            this.TidalWaveLabel = new Guna.UI.WinForms.GunaLabel();
            this.Level_panel_tidalWave = new Guna.UI2.WinForms.Guna2Panel();
            this.levelPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.BackButton_TidalWave = new Guna.UI2.WinForms.Guna2Button();
            this.DemonListScoreNumber_TidalWave = new Guna.UI.WinForms.GunaLabel();
            this.DemonListScore_TidalWave = new Guna.UI.WinForms.GunaLabel();
            this.BorderPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.Creator_TidalWave = new Guna.UI.WinForms.GunaLabel();
            this.MovePanel = new Guna.UI2.WinForms.Guna2Panel();
            this.ExitButton = new Guna.UI2.WinForms.Guna2ControlBox();
            this.MinimizeButton = new Guna.UI2.WinForms.Guna2ControlBox();
            this.MoveControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.mySqlCommand1 = new MySqlConnector.MySqlCommand();
            this.panel_leaderboard = new Guna.UI2.WinForms.Guna2Panel();
            this.TidalWaveGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Complete_TidalWave = new Guna.UI2.WinForms.Guna2Button();
            this.Leaderboard_header = new System.Windows.Forms.Label();
            this.Level_panel_tidalWave.SuspendLayout();
            this.levelPanel.SuspendLayout();
            this.MovePanel.SuspendLayout();
            this.panel_leaderboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TidalWaveGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // TidalWaveLabel
            // 
            this.TidalWaveLabel.AutoSize = true;
            this.TidalWaveLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TidalWaveLabel.Location = new System.Drawing.Point(216, 14);
            this.TidalWaveLabel.Name = "TidalWaveLabel";
            this.TidalWaveLabel.Size = new System.Drawing.Size(362, 73);
            this.TidalWaveLabel.TabIndex = 0;
            this.TidalWaveLabel.Text = "Tidal Wave";
            // 
            // Level_panel_tidalWave
            // 
            this.Level_panel_tidalWave.BorderColor = System.Drawing.Color.Black;
            this.Level_panel_tidalWave.BorderRadius = 1;
            this.Level_panel_tidalWave.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.Level_panel_tidalWave.BorderThickness = 1;
            this.Level_panel_tidalWave.Controls.Add(this.levelPanel);
            this.Level_panel_tidalWave.Controls.Add(this.BackButton_TidalWave);
            this.Level_panel_tidalWave.Controls.Add(this.DemonListScoreNumber_TidalWave);
            this.Level_panel_tidalWave.Controls.Add(this.DemonListScore_TidalWave);
            this.Level_panel_tidalWave.Controls.Add(this.BorderPanel);
            this.Level_panel_tidalWave.Controls.Add(this.Creator_TidalWave);
            this.Level_panel_tidalWave.Controls.Add(this.TidalWaveLabel);
            this.Level_panel_tidalWave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Level_panel_tidalWave.Location = new System.Drawing.Point(104, 39);
            this.Level_panel_tidalWave.Name = "Level_panel_tidalWave";
            this.Level_panel_tidalWave.Size = new System.Drawing.Size(819, 671);
            this.Level_panel_tidalWave.TabIndex = 1;
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
            // BackButton_TidalWave
            // 
            this.BackButton_TidalWave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BackButton_TidalWave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BackButton_TidalWave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BackButton_TidalWave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BackButton_TidalWave.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BackButton_TidalWave.ForeColor = System.Drawing.Color.White;
            this.BackButton_TidalWave.Location = new System.Drawing.Point(4, 3);
            this.BackButton_TidalWave.Name = "BackButton_TidalWave";
            this.BackButton_TidalWave.Size = new System.Drawing.Size(57, 45);
            this.BackButton_TidalWave.TabIndex = 5;
            this.BackButton_TidalWave.Text = "<";
            this.BackButton_TidalWave.Click += new System.EventHandler(this.BackButton_TidalWave_Click);
            // 
            // DemonListScoreNumber_TidalWave
            // 
            this.DemonListScoreNumber_TidalWave.AutoSize = true;
            this.DemonListScoreNumber_TidalWave.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DemonListScoreNumber_TidalWave.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DemonListScoreNumber_TidalWave.Location = new System.Drawing.Point(366, 627);
            this.DemonListScoreNumber_TidalWave.Name = "DemonListScoreNumber_TidalWave";
            this.DemonListScoreNumber_TidalWave.Size = new System.Drawing.Size(90, 32);
            this.DemonListScoreNumber_TidalWave.TabIndex = 5;
            this.DemonListScoreNumber_TidalWave.Text = "350.00";
            this.DemonListScoreNumber_TidalWave.Click += new System.EventHandler(this.DemonListScoreNumber_TidalWave_Click);
            // 
            // DemonListScore_TidalWave
            // 
            this.DemonListScore_TidalWave.AutoSize = true;
            this.DemonListScore_TidalWave.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DemonListScore_TidalWave.Location = new System.Drawing.Point(311, 595);
            this.DemonListScore_TidalWave.Name = "DemonListScore_TidalWave";
            this.DemonListScore_TidalWave.Size = new System.Drawing.Size(201, 32);
            this.DemonListScore_TidalWave.TabIndex = 4;
            this.DemonListScore_TidalWave.Text = "Demonlist score";
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
            // Creator_TidalWave
            // 
            this.Creator_TidalWave.AutoSize = true;
            this.Creator_TidalWave.Font = new System.Drawing.Font("Segoe UI Symbol", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Creator_TidalWave.Location = new System.Drawing.Point(157, 91);
            this.Creator_TidalWave.Name = "Creator_TidalWave";
            this.Creator_TidalWave.Size = new System.Drawing.Size(485, 40);
            this.Creator_TidalWave.TabIndex = 1;
            this.Creator_TidalWave.Text = "by Onilink, verified by [AUF] Zoink";
            // 
            // MovePanel
            // 
            this.MovePanel.BackColor = System.Drawing.Color.Transparent;
            this.MovePanel.Controls.Add(this.ExitButton);
            this.MovePanel.Controls.Add(this.MinimizeButton);
            this.MovePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MovePanel.Location = new System.Drawing.Point(0, 0);
            this.MovePanel.Name = "MovePanel";
            this.MovePanel.Size = new System.Drawing.Size(1007, 36);
            this.MovePanel.TabIndex = 31;
            this.MovePanel.UseTransparentBackground = true;
            this.MovePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MovePanel_Paint);
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
            // MoveControl
            // 
            this.MoveControl.DockIndicatorTransparencyValue = 0.6D;
            this.MoveControl.TargetControl = this.MovePanel;
            this.MoveControl.UseTransparentDrag = true;
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CommandTimeout = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.Transaction = null;
            this.mySqlCommand1.UpdatedRowSource = System.Data.UpdateRowSource.None;
            // 
            // panel_leaderboard
            // 
            this.panel_leaderboard.Controls.Add(this.TidalWaveGridView);
            this.panel_leaderboard.Location = new System.Drawing.Point(312, 801);
            this.panel_leaderboard.Name = "panel_leaderboard";
            this.panel_leaderboard.Size = new System.Drawing.Size(385, 343);
            this.panel_leaderboard.TabIndex = 32;
            // 
            // TidalWaveGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.TidalWaveGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TidalWaveGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.TidalWaveGridView.ColumnHeadersHeight = 4;
            this.TidalWaveGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TidalWaveGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.TidalWaveGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TidalWaveGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.TidalWaveGridView.Location = new System.Drawing.Point(0, 0);
            this.TidalWaveGridView.Name = "TidalWaveGridView";
            this.TidalWaveGridView.RowHeadersVisible = false;
            this.TidalWaveGridView.Size = new System.Drawing.Size(385, 343);
            this.TidalWaveGridView.TabIndex = 0;
            this.TidalWaveGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.TidalWaveGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.TidalWaveGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.TidalWaveGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.TidalWaveGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.TidalWaveGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.TidalWaveGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.TidalWaveGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TidalWaveGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.TidalWaveGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TidalWaveGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.TidalWaveGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.TidalWaveGridView.ThemeStyle.HeaderStyle.Height = 4;
            this.TidalWaveGridView.ThemeStyle.ReadOnly = false;
            this.TidalWaveGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.TidalWaveGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.TidalWaveGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TidalWaveGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.TidalWaveGridView.ThemeStyle.RowsStyle.Height = 22;
            this.TidalWaveGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.TidalWaveGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.TidalWaveGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TidalWaveGridView_CellContentClick);
            // 
            // Complete_TidalWave
            // 
            this.Complete_TidalWave.Animated = true;
            this.Complete_TidalWave.AutoRoundedCorners = true;
            this.Complete_TidalWave.BorderRadius = 19;
            this.Complete_TidalWave.DialogResult = System.Windows.Forms.DialogResult.Retry;
            this.Complete_TidalWave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Complete_TidalWave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Complete_TidalWave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Complete_TidalWave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Complete_TidalWave.FillColor = System.Drawing.Color.Crimson;
            this.Complete_TidalWave.FocusedColor = System.Drawing.Color.IndianRed;
            this.Complete_TidalWave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Complete_TidalWave.ForeColor = System.Drawing.Color.White;
            this.Complete_TidalWave.Location = new System.Drawing.Point(492, 743);
            this.Complete_TidalWave.Name = "Complete_TidalWave";
            this.Complete_TidalWave.Size = new System.Drawing.Size(43, 40);
            this.Complete_TidalWave.TabIndex = 11;
            this.Complete_TidalWave.Click += new System.EventHandler(this.Complete_TidalWave_Click);
            // 
            // Leaderboard_header
            // 
            this.Leaderboard_header.AutoSize = true;
            this.Leaderboard_header.BackColor = System.Drawing.Color.Transparent;
            this.Leaderboard_header.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Leaderboard_header.Location = new System.Drawing.Point(454, 713);
            this.Leaderboard_header.Name = "Leaderboard_header";
            this.Leaderboard_header.Size = new System.Drawing.Size(128, 27);
            this.Leaderboard_header.TabIndex = 52;
            this.Leaderboard_header.Text = "Completed?";
            this.Leaderboard_header.Click += new System.EventHandler(this.Leaderboard_header_Click);
            // 
            // TidalWave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1024, 576);
            this.Controls.Add(this.Leaderboard_header);
            this.Controls.Add(this.Complete_TidalWave);
            this.Controls.Add(this.panel_leaderboard);
            this.Controls.Add(this.MovePanel);
            this.Controls.Add(this.Level_panel_tidalWave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TidalWave";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TidalWave";
            this.Load += new System.EventHandler(this.TidalWave_Load);
            this.Level_panel_tidalWave.ResumeLayout(false);
            this.Level_panel_tidalWave.PerformLayout();
            this.levelPanel.ResumeLayout(false);
            this.MovePanel.ResumeLayout(false);
            this.panel_leaderboard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TidalWaveGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel TidalWaveLabel;
        private Guna.UI2.WinForms.Guna2Panel Level_panel_tidalWave;
        private Guna.UI.WinForms.GunaLabel DemonListScoreNumber_TidalWave;
        private Guna.UI.WinForms.GunaLabel DemonListScore_TidalWave;
        private Guna.UI2.WinForms.Guna2Panel BorderPanel;
        private Guna.UI.WinForms.GunaLabel Creator_TidalWave;
        private Guna.UI2.WinForms.Guna2Button BackButton_TidalWave;
        private Guna.UI2.WinForms.Guna2Panel MovePanel;
        private Guna.UI2.WinForms.Guna2ControlBox ExitButton;
        private Guna.UI2.WinForms.Guna2ControlBox MinimizeButton;
        private Guna.UI2.WinForms.Guna2DragControl MoveControl;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private MySqlConnector.MySqlCommand mySqlCommand1;
        private Guna.UI2.WinForms.Guna2Panel panel_leaderboard;
        private Guna.UI2.WinForms.Guna2Panel levelPanel;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private Guna.UI2.WinForms.Guna2Button Complete_TidalWave;
        private System.Windows.Forms.Label Leaderboard_header;
        private Guna.UI2.WinForms.Guna2DataGridView TidalWaveGridView;
    }
}