namespace DemonList
{
    partial class AbyssOfDarkness
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AbyssOfDarkness));
            this.Level_panel_AOD = new Guna.UI2.WinForms.Guna2Panel();
            this.levelPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.BackButton_AOD = new Guna.UI2.WinForms.Guna2Button();
            this.DemonListScoreNumber_AOD = new Guna.UI.WinForms.GunaLabel();
            this.DemonListScore_AOD = new Guna.UI.WinForms.GunaLabel();
            this.BorderPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.Creator_AOD = new Guna.UI.WinForms.GunaLabel();
            this.AODLabel = new Guna.UI.WinForms.GunaLabel();
            this.MovePanel = new Guna.UI2.WinForms.Guna2Panel();
            this.ExitButton = new Guna.UI2.WinForms.Guna2ControlBox();
            this.MinimizeButton = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.Complete_AOD = new Guna.UI2.WinForms.Guna2Button();
            this.Leaderboard_header = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.AbyssOfDarknessGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Level_panel_AOD.SuspendLayout();
            this.levelPanel.SuspendLayout();
            this.MovePanel.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AbyssOfDarknessGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Level_panel_AOD
            // 
            this.Level_panel_AOD.AutoScroll = true;
            this.Level_panel_AOD.BorderColor = System.Drawing.Color.Black;
            this.Level_panel_AOD.BorderRadius = 1;
            this.Level_panel_AOD.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.Level_panel_AOD.BorderThickness = 1;
            this.Level_panel_AOD.Controls.Add(this.levelPanel);
            this.Level_panel_AOD.Controls.Add(this.BackButton_AOD);
            this.Level_panel_AOD.Controls.Add(this.DemonListScoreNumber_AOD);
            this.Level_panel_AOD.Controls.Add(this.DemonListScore_AOD);
            this.Level_panel_AOD.Controls.Add(this.BorderPanel);
            this.Level_panel_AOD.Controls.Add(this.Creator_AOD);
            this.Level_panel_AOD.Controls.Add(this.AODLabel);
            this.Level_panel_AOD.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Level_panel_AOD.Location = new System.Drawing.Point(98, 45);
            this.Level_panel_AOD.Name = "Level_panel_AOD";
            this.Level_panel_AOD.Size = new System.Drawing.Size(819, 671);
            this.Level_panel_AOD.TabIndex = 36;
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
            // BackButton_AOD
            // 
            this.BackButton_AOD.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BackButton_AOD.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BackButton_AOD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BackButton_AOD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BackButton_AOD.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BackButton_AOD.ForeColor = System.Drawing.Color.White;
            this.BackButton_AOD.Location = new System.Drawing.Point(4, 3);
            this.BackButton_AOD.Name = "BackButton_AOD";
            this.BackButton_AOD.Size = new System.Drawing.Size(57, 45);
            this.BackButton_AOD.TabIndex = 5;
            this.BackButton_AOD.Text = "<";
            this.BackButton_AOD.Click += new System.EventHandler(this.BackButton_AOD_Click);
            // 
            // DemonListScoreNumber_AOD
            // 
            this.DemonListScoreNumber_AOD.AutoSize = true;
            this.DemonListScoreNumber_AOD.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DemonListScoreNumber_AOD.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DemonListScoreNumber_AOD.Location = new System.Drawing.Point(366, 627);
            this.DemonListScoreNumber_AOD.Name = "DemonListScoreNumber_AOD";
            this.DemonListScoreNumber_AOD.Size = new System.Drawing.Size(90, 32);
            this.DemonListScoreNumber_AOD.TabIndex = 5;
            this.DemonListScoreNumber_AOD.Text = "271.78";
            // 
            // DemonListScore_AOD
            // 
            this.DemonListScore_AOD.AutoSize = true;
            this.DemonListScore_AOD.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DemonListScore_AOD.Location = new System.Drawing.Point(311, 595);
            this.DemonListScore_AOD.Name = "DemonListScore_AOD";
            this.DemonListScore_AOD.Size = new System.Drawing.Size(201, 32);
            this.DemonListScore_AOD.TabIndex = 4;
            this.DemonListScore_AOD.Text = "Demonlist score";
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
            // Creator_AOD
            // 
            this.Creator_AOD.AutoSize = true;
            this.Creator_AOD.Font = new System.Drawing.Font("Segoe UI Symbol", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Creator_AOD.Location = new System.Drawing.Point(154, 91);
            this.Creator_AOD.Name = "Creator_AOD";
            this.Creator_AOD.Size = new System.Drawing.Size(525, 40);
            this.Creator_AOD.TabIndex = 1;
            this.Creator_AOD.Text = "by Exen and more, verified by Cursed";
            // 
            // AODLabel
            // 
            this.AODLabel.AutoSize = true;
            this.AODLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AODLabel.Location = new System.Drawing.Point(138, 18);
            this.AODLabel.Name = "AODLabel";
            this.AODLabel.Size = new System.Drawing.Size(583, 73);
            this.AODLabel.TabIndex = 0;
            this.AODLabel.Text = "Abyss of Darkness";
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
            this.MovePanel.TabIndex = 38;
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
            // Complete_AOD
            // 
            this.Complete_AOD.Animated = true;
            this.Complete_AOD.AutoRoundedCorners = true;
            this.Complete_AOD.BorderRadius = 19;
            this.Complete_AOD.DialogResult = System.Windows.Forms.DialogResult.Retry;
            this.Complete_AOD.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Complete_AOD.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Complete_AOD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Complete_AOD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Complete_AOD.FillColor = System.Drawing.Color.Crimson;
            this.Complete_AOD.FocusedColor = System.Drawing.Color.IndianRed;
            this.Complete_AOD.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Complete_AOD.ForeColor = System.Drawing.Color.White;
            this.Complete_AOD.Location = new System.Drawing.Point(483, 749);
            this.Complete_AOD.Name = "Complete_AOD";
            this.Complete_AOD.Size = new System.Drawing.Size(43, 40);
            this.Complete_AOD.TabIndex = 60;
            this.Complete_AOD.Click += new System.EventHandler(this.Complete_AOD_Click);
            // 
            // Leaderboard_header
            // 
            this.Leaderboard_header.AutoSize = true;
            this.Leaderboard_header.BackColor = System.Drawing.Color.Transparent;
            this.Leaderboard_header.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Leaderboard_header.Location = new System.Drawing.Point(445, 719);
            this.Leaderboard_header.Name = "Leaderboard_header";
            this.Leaderboard_header.Size = new System.Drawing.Size(128, 27);
            this.Leaderboard_header.TabIndex = 59;
            this.Leaderboard_header.Text = "Completed?";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.AbyssOfDarknessGridView);
            this.guna2Panel1.Location = new System.Drawing.Point(325, 795);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(385, 343);
            this.guna2Panel1.TabIndex = 61;
            // 
            // AbyssOfDarknessGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.AbyssOfDarknessGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AbyssOfDarknessGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.AbyssOfDarknessGridView.ColumnHeadersHeight = 4;
            this.AbyssOfDarknessGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AbyssOfDarknessGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.AbyssOfDarknessGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AbyssOfDarknessGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.AbyssOfDarknessGridView.Location = new System.Drawing.Point(0, 0);
            this.AbyssOfDarknessGridView.Name = "AbyssOfDarknessGridView";
            this.AbyssOfDarknessGridView.RowHeadersVisible = false;
            this.AbyssOfDarknessGridView.Size = new System.Drawing.Size(385, 343);
            this.AbyssOfDarknessGridView.TabIndex = 0;
            this.AbyssOfDarknessGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.AbyssOfDarknessGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.AbyssOfDarknessGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.AbyssOfDarknessGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.AbyssOfDarknessGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.AbyssOfDarknessGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.AbyssOfDarknessGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.AbyssOfDarknessGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.AbyssOfDarknessGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.AbyssOfDarknessGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AbyssOfDarknessGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.AbyssOfDarknessGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.AbyssOfDarknessGridView.ThemeStyle.HeaderStyle.Height = 4;
            this.AbyssOfDarknessGridView.ThemeStyle.ReadOnly = false;
            this.AbyssOfDarknessGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.AbyssOfDarknessGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.AbyssOfDarknessGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AbyssOfDarknessGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.AbyssOfDarknessGridView.ThemeStyle.RowsStyle.Height = 22;
            this.AbyssOfDarknessGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.AbyssOfDarknessGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // AbyssOfDarkness
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1024, 576);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.Complete_AOD);
            this.Controls.Add(this.Leaderboard_header);
            this.Controls.Add(this.MovePanel);
            this.Controls.Add(this.Level_panel_AOD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AbyssOfDarkness";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AbyssOfDarkness";
            this.Load += new System.EventHandler(this.AbyssOfDarkness_Load);
            this.Level_panel_AOD.ResumeLayout(false);
            this.Level_panel_AOD.PerformLayout();
            this.levelPanel.ResumeLayout(false);
            this.MovePanel.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AbyssOfDarknessGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel Level_panel_AOD;
        private Guna.UI2.WinForms.Guna2Panel levelPanel;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private Guna.UI2.WinForms.Guna2Button BackButton_AOD;
        private Guna.UI.WinForms.GunaLabel DemonListScoreNumber_AOD;
        private Guna.UI.WinForms.GunaLabel DemonListScore_AOD;
        private Guna.UI2.WinForms.Guna2Panel BorderPanel;
        private Guna.UI.WinForms.GunaLabel Creator_AOD;
        private Guna.UI.WinForms.GunaLabel AODLabel;
        private Guna.UI2.WinForms.Guna2Panel MovePanel;
        private Guna.UI2.WinForms.Guna2ControlBox ExitButton;
        private Guna.UI2.WinForms.Guna2ControlBox MinimizeButton;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Button Complete_AOD;
        private System.Windows.Forms.Label Leaderboard_header;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2DataGridView AbyssOfDarknessGridView;
    }
}