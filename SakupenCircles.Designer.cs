namespace DemonList
{
    partial class SakupenCircles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SakupenCircles));
            this.MovePanel = new Guna.UI2.WinForms.Guna2Panel();
            this.ExitButton = new Guna.UI2.WinForms.Guna2ControlBox();
            this.MinimizeButton = new Guna.UI2.WinForms.Guna2ControlBox();
            this.Level_panel_SKC = new Guna.UI2.WinForms.Guna2Panel();
            this.levelPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.BackButton_SKC = new Guna.UI2.WinForms.Guna2Button();
            this.DemonListScoreNumber_SKC = new Guna.UI.WinForms.GunaLabel();
            this.DemonListScore_SKC = new Guna.UI.WinForms.GunaLabel();
            this.BorderPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.Creator_SKC = new Guna.UI.WinForms.GunaLabel();
            this.SKCLabel = new Guna.UI.WinForms.GunaLabel();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.Complete_SakupenCircles = new Guna.UI2.WinForms.Guna2Button();
            this.Leaderboard_header = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.SakupenCirclesGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.MovePanel.SuspendLayout();
            this.Level_panel_SKC.SuspendLayout();
            this.levelPanel.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SakupenCirclesGridView)).BeginInit();
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
            this.MovePanel.Size = new System.Drawing.Size(1007, 35);
            this.MovePanel.TabIndex = 43;
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
            // Level_panel_SKC
            // 
            this.Level_panel_SKC.AutoScroll = true;
            this.Level_panel_SKC.BorderColor = System.Drawing.Color.Black;
            this.Level_panel_SKC.BorderRadius = 1;
            this.Level_panel_SKC.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.Level_panel_SKC.BorderThickness = 1;
            this.Level_panel_SKC.Controls.Add(this.levelPanel);
            this.Level_panel_SKC.Controls.Add(this.BackButton_SKC);
            this.Level_panel_SKC.Controls.Add(this.DemonListScoreNumber_SKC);
            this.Level_panel_SKC.Controls.Add(this.DemonListScore_SKC);
            this.Level_panel_SKC.Controls.Add(this.BorderPanel);
            this.Level_panel_SKC.Controls.Add(this.Creator_SKC);
            this.Level_panel_SKC.Controls.Add(this.SKCLabel);
            this.Level_panel_SKC.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Level_panel_SKC.Location = new System.Drawing.Point(114, 41);
            this.Level_panel_SKC.Name = "Level_panel_SKC";
            this.Level_panel_SKC.Size = new System.Drawing.Size(819, 671);
            this.Level_panel_SKC.TabIndex = 44;
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
            // BackButton_SKC
            // 
            this.BackButton_SKC.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BackButton_SKC.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BackButton_SKC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BackButton_SKC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BackButton_SKC.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BackButton_SKC.ForeColor = System.Drawing.Color.White;
            this.BackButton_SKC.Location = new System.Drawing.Point(4, 3);
            this.BackButton_SKC.Name = "BackButton_SKC";
            this.BackButton_SKC.Size = new System.Drawing.Size(57, 45);
            this.BackButton_SKC.TabIndex = 5;
            this.BackButton_SKC.Text = "<";
            this.BackButton_SKC.Click += new System.EventHandler(this.BackButton_SKC_Click);
            // 
            // DemonListScoreNumber_SKC
            // 
            this.DemonListScoreNumber_SKC.AutoSize = true;
            this.DemonListScoreNumber_SKC.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DemonListScoreNumber_SKC.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DemonListScoreNumber_SKC.Location = new System.Drawing.Point(360, 627);
            this.DemonListScoreNumber_SKC.Name = "DemonListScoreNumber_SKC";
            this.DemonListScoreNumber_SKC.Size = new System.Drawing.Size(90, 32);
            this.DemonListScoreNumber_SKC.TabIndex = 5;
            this.DemonListScoreNumber_SKC.Text = "221.47";
            // 
            // DemonListScore_SKC
            // 
            this.DemonListScore_SKC.AutoSize = true;
            this.DemonListScore_SKC.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DemonListScore_SKC.Location = new System.Drawing.Point(311, 595);
            this.DemonListScore_SKC.Name = "DemonListScore_SKC";
            this.DemonListScore_SKC.Size = new System.Drawing.Size(201, 32);
            this.DemonListScore_SKC.TabIndex = 4;
            this.DemonListScore_SKC.Text = "Demonlist score";
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
            // Creator_SKC
            // 
            this.Creator_SKC.AutoSize = true;
            this.Creator_SKC.Font = new System.Drawing.Font("Segoe UI Symbol", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Creator_SKC.Location = new System.Drawing.Point(17, 91);
            this.Creator_SKC.Name = "Creator_SKC";
            this.Creator_SKC.Size = new System.Drawing.Size(782, 40);
            this.Creator_SKC.TabIndex = 1;
            this.Creator_SKC.Text = "by nick24 and more, verified and published by Diamond";
            // 
            // SKCLabel
            // 
            this.SKCLabel.AutoSize = true;
            this.SKCLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SKCLabel.Location = new System.Drawing.Point(174, 18);
            this.SKCLabel.Name = "SKCLabel";
            this.SKCLabel.Size = new System.Drawing.Size(514, 73);
            this.SKCLabel.TabIndex = 0;
            this.SKCLabel.Text = "Sakupen Circles";
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.MovePanel;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // Complete_SakupenCircles
            // 
            this.Complete_SakupenCircles.Animated = true;
            this.Complete_SakupenCircles.AutoRoundedCorners = true;
            this.Complete_SakupenCircles.BorderRadius = 19;
            this.Complete_SakupenCircles.DialogResult = System.Windows.Forms.DialogResult.Retry;
            this.Complete_SakupenCircles.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Complete_SakupenCircles.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Complete_SakupenCircles.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Complete_SakupenCircles.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Complete_SakupenCircles.FillColor = System.Drawing.Color.Crimson;
            this.Complete_SakupenCircles.FocusedColor = System.Drawing.Color.IndianRed;
            this.Complete_SakupenCircles.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Complete_SakupenCircles.ForeColor = System.Drawing.Color.White;
            this.Complete_SakupenCircles.Location = new System.Drawing.Point(494, 745);
            this.Complete_SakupenCircles.Name = "Complete_SakupenCircles";
            this.Complete_SakupenCircles.Size = new System.Drawing.Size(43, 40);
            this.Complete_SakupenCircles.TabIndex = 66;
            this.Complete_SakupenCircles.Click += new System.EventHandler(this.Complete_SakupenCircles_Click);
            // 
            // Leaderboard_header
            // 
            this.Leaderboard_header.AutoSize = true;
            this.Leaderboard_header.BackColor = System.Drawing.Color.Transparent;
            this.Leaderboard_header.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Leaderboard_header.Location = new System.Drawing.Point(456, 715);
            this.Leaderboard_header.Name = "Leaderboard_header";
            this.Leaderboard_header.Size = new System.Drawing.Size(128, 27);
            this.Leaderboard_header.TabIndex = 65;
            this.Leaderboard_header.Text = "Completed?";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.SakupenCirclesGridView);
            this.guna2Panel1.Location = new System.Drawing.Point(331, 791);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(385, 343);
            this.guna2Panel1.TabIndex = 67;
            // 
            // SakupenCirclesGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.SakupenCirclesGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SakupenCirclesGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.SakupenCirclesGridView.ColumnHeadersHeight = 4;
            this.SakupenCirclesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SakupenCirclesGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.SakupenCirclesGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SakupenCirclesGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.SakupenCirclesGridView.Location = new System.Drawing.Point(0, 0);
            this.SakupenCirclesGridView.Name = "SakupenCirclesGridView";
            this.SakupenCirclesGridView.RowHeadersVisible = false;
            this.SakupenCirclesGridView.Size = new System.Drawing.Size(385, 343);
            this.SakupenCirclesGridView.TabIndex = 0;
            this.SakupenCirclesGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.SakupenCirclesGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.SakupenCirclesGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.SakupenCirclesGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.SakupenCirclesGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.SakupenCirclesGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.SakupenCirclesGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.SakupenCirclesGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.SakupenCirclesGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.SakupenCirclesGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SakupenCirclesGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.SakupenCirclesGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.SakupenCirclesGridView.ThemeStyle.HeaderStyle.Height = 4;
            this.SakupenCirclesGridView.ThemeStyle.ReadOnly = false;
            this.SakupenCirclesGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.SakupenCirclesGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.SakupenCirclesGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SakupenCirclesGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.SakupenCirclesGridView.ThemeStyle.RowsStyle.Height = 22;
            this.SakupenCirclesGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.SakupenCirclesGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.SakupenCirclesGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SakupenCirclesGridView_CellContentClick);
            // 
            // SakupenCircles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1024, 576);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.Complete_SakupenCircles);
            this.Controls.Add(this.Leaderboard_header);
            this.Controls.Add(this.Level_panel_SKC);
            this.Controls.Add(this.MovePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SakupenCircles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SakupenCircles";
            this.Load += new System.EventHandler(this.SakupenCircles_Load);
            this.MovePanel.ResumeLayout(false);
            this.Level_panel_SKC.ResumeLayout(false);
            this.Level_panel_SKC.PerformLayout();
            this.levelPanel.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SakupenCirclesGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel MovePanel;
        private Guna.UI2.WinForms.Guna2ControlBox ExitButton;
        private Guna.UI2.WinForms.Guna2ControlBox MinimizeButton;
        private Guna.UI2.WinForms.Guna2Panel Level_panel_SKC;
        private Guna.UI2.WinForms.Guna2Panel levelPanel;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private Guna.UI2.WinForms.Guna2Button BackButton_SKC;
        private Guna.UI.WinForms.GunaLabel DemonListScoreNumber_SKC;
        private Guna.UI.WinForms.GunaLabel DemonListScore_SKC;
        private Guna.UI2.WinForms.Guna2Panel BorderPanel;
        private Guna.UI.WinForms.GunaLabel Creator_SKC;
        private Guna.UI.WinForms.GunaLabel SKCLabel;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Button Complete_SakupenCircles;
        private System.Windows.Forms.Label Leaderboard_header;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2DataGridView SakupenCirclesGridView;
    }
}