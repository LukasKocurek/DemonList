namespace DemonList
{
    partial class TunnelOfDespair
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TunnelOfDespair));
            this.MovePanel = new Guna.UI2.WinForms.Guna2Panel();
            this.ExitButton = new Guna.UI2.WinForms.Guna2ControlBox();
            this.MinimizeButton = new Guna.UI2.WinForms.Guna2ControlBox();
            this.Level_panel_TOD = new Guna.UI2.WinForms.Guna2Panel();
            this.levelPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.BackButton_TOD = new Guna.UI2.WinForms.Guna2Button();
            this.DemonListScoreNumber_TOD = new Guna.UI.WinForms.GunaLabel();
            this.DemonListScore_TOD = new Guna.UI.WinForms.GunaLabel();
            this.BorderPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.Creator_TOD = new Guna.UI.WinForms.GunaLabel();
            this.TODLabel = new Guna.UI.WinForms.GunaLabel();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.Complete_TOD = new Guna.UI2.WinForms.Guna2Button();
            this.Leaderboard_header = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.TunnelofDespairGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.MovePanel.SuspendLayout();
            this.Level_panel_TOD.SuspendLayout();
            this.levelPanel.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TunnelofDespairGridView)).BeginInit();
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
            this.MovePanel.TabIndex = 44;
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
            // Level_panel_TOD
            // 
            this.Level_panel_TOD.AutoScroll = true;
            this.Level_panel_TOD.BorderColor = System.Drawing.Color.Black;
            this.Level_panel_TOD.BorderRadius = 1;
            this.Level_panel_TOD.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.Level_panel_TOD.BorderThickness = 1;
            this.Level_panel_TOD.Controls.Add(this.levelPanel);
            this.Level_panel_TOD.Controls.Add(this.BackButton_TOD);
            this.Level_panel_TOD.Controls.Add(this.DemonListScoreNumber_TOD);
            this.Level_panel_TOD.Controls.Add(this.DemonListScore_TOD);
            this.Level_panel_TOD.Controls.Add(this.BorderPanel);
            this.Level_panel_TOD.Controls.Add(this.Creator_TOD);
            this.Level_panel_TOD.Controls.Add(this.TODLabel);
            this.Level_panel_TOD.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Level_panel_TOD.Location = new System.Drawing.Point(116, 41);
            this.Level_panel_TOD.Name = "Level_panel_TOD";
            this.Level_panel_TOD.Size = new System.Drawing.Size(819, 684);
            this.Level_panel_TOD.TabIndex = 45;
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
            // BackButton_TOD
            // 
            this.BackButton_TOD.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BackButton_TOD.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BackButton_TOD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BackButton_TOD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BackButton_TOD.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BackButton_TOD.ForeColor = System.Drawing.Color.White;
            this.BackButton_TOD.Location = new System.Drawing.Point(4, 3);
            this.BackButton_TOD.Name = "BackButton_TOD";
            this.BackButton_TOD.Size = new System.Drawing.Size(57, 45);
            this.BackButton_TOD.TabIndex = 5;
            this.BackButton_TOD.Text = "<";
            this.BackButton_TOD.Click += new System.EventHandler(this.BackButton_TOD_Click);
            // 
            // DemonListScoreNumber_TOD
            // 
            this.DemonListScoreNumber_TOD.AutoSize = true;
            this.DemonListScoreNumber_TOD.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DemonListScoreNumber_TOD.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DemonListScoreNumber_TOD.Location = new System.Drawing.Point(360, 627);
            this.DemonListScoreNumber_TOD.Name = "DemonListScoreNumber_TOD";
            this.DemonListScoreNumber_TOD.Size = new System.Drawing.Size(90, 32);
            this.DemonListScoreNumber_TOD.TabIndex = 5;
            this.DemonListScoreNumber_TOD.Text = "207.42";
            // 
            // DemonListScore_TOD
            // 
            this.DemonListScore_TOD.AutoSize = true;
            this.DemonListScore_TOD.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DemonListScore_TOD.Location = new System.Drawing.Point(311, 595);
            this.DemonListScore_TOD.Name = "DemonListScore_TOD";
            this.DemonListScore_TOD.Size = new System.Drawing.Size(201, 32);
            this.DemonListScore_TOD.TabIndex = 4;
            this.DemonListScore_TOD.Text = "Demonlist score";
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
            // Creator_TOD
            // 
            this.Creator_TOD.AutoSize = true;
            this.Creator_TOD.Font = new System.Drawing.Font("Segoe UI Symbol", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Creator_TOD.Location = new System.Drawing.Point(95, 91);
            this.Creator_TOD.Name = "Creator_TOD";
            this.Creator_TOD.Size = new System.Drawing.Size(648, 40);
            this.Creator_TOD.TabIndex = 1;
            this.Creator_TOD.Text = "by Exen and ImMaxX1, verified by [AUF] Zoink";
            // 
            // TODLabel
            // 
            this.TODLabel.AutoSize = true;
            this.TODLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TODLabel.Location = new System.Drawing.Point(134, 18);
            this.TODLabel.Name = "TODLabel";
            this.TODLabel.Size = new System.Drawing.Size(555, 73);
            this.TODLabel.TabIndex = 0;
            this.TODLabel.Text = "Tunnel of Despair";
            this.TODLabel.UseMnemonic = false;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.MovePanel;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // Complete_TOD
            // 
            this.Complete_TOD.Animated = true;
            this.Complete_TOD.AutoRoundedCorners = true;
            this.Complete_TOD.BorderRadius = 19;
            this.Complete_TOD.DialogResult = System.Windows.Forms.DialogResult.Retry;
            this.Complete_TOD.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Complete_TOD.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Complete_TOD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Complete_TOD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Complete_TOD.FillColor = System.Drawing.Color.Crimson;
            this.Complete_TOD.FocusedColor = System.Drawing.Color.IndianRed;
            this.Complete_TOD.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Complete_TOD.ForeColor = System.Drawing.Color.White;
            this.Complete_TOD.Location = new System.Drawing.Point(497, 758);
            this.Complete_TOD.Name = "Complete_TOD";
            this.Complete_TOD.Size = new System.Drawing.Size(43, 40);
            this.Complete_TOD.TabIndex = 68;
            this.Complete_TOD.Click += new System.EventHandler(this.Complete_TOD_Click);
            // 
            // Leaderboard_header
            // 
            this.Leaderboard_header.AutoSize = true;
            this.Leaderboard_header.BackColor = System.Drawing.Color.Transparent;
            this.Leaderboard_header.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Leaderboard_header.Location = new System.Drawing.Point(459, 728);
            this.Leaderboard_header.Name = "Leaderboard_header";
            this.Leaderboard_header.Size = new System.Drawing.Size(128, 27);
            this.Leaderboard_header.TabIndex = 67;
            this.Leaderboard_header.Text = "Completed?";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.TunnelofDespairGridView);
            this.guna2Panel1.Location = new System.Drawing.Point(336, 804);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(385, 343);
            this.guna2Panel1.TabIndex = 69;
            // 
            // TunnelofDespairGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.TunnelofDespairGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TunnelofDespairGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.TunnelofDespairGridView.ColumnHeadersHeight = 4;
            this.TunnelofDespairGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TunnelofDespairGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.TunnelofDespairGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TunnelofDespairGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.TunnelofDespairGridView.Location = new System.Drawing.Point(0, 0);
            this.TunnelofDespairGridView.Name = "TunnelofDespairGridView";
            this.TunnelofDespairGridView.RowHeadersVisible = false;
            this.TunnelofDespairGridView.Size = new System.Drawing.Size(385, 343);
            this.TunnelofDespairGridView.TabIndex = 0;
            this.TunnelofDespairGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.TunnelofDespairGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.TunnelofDespairGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.TunnelofDespairGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.TunnelofDespairGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.TunnelofDespairGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.TunnelofDespairGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.TunnelofDespairGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TunnelofDespairGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.TunnelofDespairGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TunnelofDespairGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.TunnelofDespairGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.TunnelofDespairGridView.ThemeStyle.HeaderStyle.Height = 4;
            this.TunnelofDespairGridView.ThemeStyle.ReadOnly = false;
            this.TunnelofDespairGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.TunnelofDespairGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.TunnelofDespairGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TunnelofDespairGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.TunnelofDespairGridView.ThemeStyle.RowsStyle.Height = 22;
            this.TunnelofDespairGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.TunnelofDespairGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.TunnelofDespairGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TunnelofDespairGridView_CellContentClick);
            // 
            // TunnelOfDespair
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1024, 576);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.Complete_TOD);
            this.Controls.Add(this.Leaderboard_header);
            this.Controls.Add(this.Level_panel_TOD);
            this.Controls.Add(this.MovePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TunnelOfDespair";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TunnelOfDespair";
            this.Load += new System.EventHandler(this.TunnelOfDespair_Load);
            this.MovePanel.ResumeLayout(false);
            this.Level_panel_TOD.ResumeLayout(false);
            this.Level_panel_TOD.PerformLayout();
            this.levelPanel.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TunnelofDespairGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel MovePanel;
        private Guna.UI2.WinForms.Guna2ControlBox ExitButton;
        private Guna.UI2.WinForms.Guna2ControlBox MinimizeButton;
        private Guna.UI2.WinForms.Guna2Panel Level_panel_TOD;
        private Guna.UI2.WinForms.Guna2Panel levelPanel;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private Guna.UI2.WinForms.Guna2Button BackButton_TOD;
        private Guna.UI.WinForms.GunaLabel DemonListScoreNumber_TOD;
        private Guna.UI.WinForms.GunaLabel DemonListScore_TOD;
        private Guna.UI2.WinForms.Guna2Panel BorderPanel;
        private Guna.UI.WinForms.GunaLabel Creator_TOD;
        private Guna.UI.WinForms.GunaLabel TODLabel;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Button Complete_TOD;
        private System.Windows.Forms.Label Leaderboard_header;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2DataGridView TunnelofDespairGridView;
    }
}