namespace DemonList
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.BackgroundPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.BorderPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.LoginName = new Guna.UI2.WinForms.Guna2TextBox();
            this.LoginPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.LoginText = new System.Windows.Forms.Label();
            this.LogoPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.LoginButton = new Guna.UI2.WinForms.Guna2Button();
            this.RegisterName = new Guna.UI2.WinForms.Guna2TextBox();
            this.RegisterPassword1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.RegisterPassword2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.RegisterText = new System.Windows.Forms.Label();
            this.RegisterButton = new Guna.UI2.WinForms.Guna2Button();
            this.ExitButton = new Guna.UI2.WinForms.Guna2ControlBox();
            this.MinimizeButton = new Guna.UI2.WinForms.Guna2ControlBox();
            this.MoveControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.MovePanel = new Guna.UI2.WinForms.Guna2Panel();
            this.MovePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BackgroundPanel
            // 
            this.BackgroundPanel.AutoRoundedCorners = true;
            this.BackgroundPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BackgroundPanel.BackgroundImage")));
            this.BackgroundPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BackgroundPanel.BorderColor = System.Drawing.Color.Navy;
            this.BackgroundPanel.BorderRadius = 237;
            this.BackgroundPanel.Location = new System.Drawing.Point(475, 0);
            this.BackgroundPanel.Name = "BackgroundPanel";
            this.BackgroundPanel.Size = new System.Drawing.Size(476, 584);
            this.BackgroundPanel.TabIndex = 3;
            this.BackgroundPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // BorderPanel
            // 
            this.BorderPanel.BorderColor = System.Drawing.Color.Crimson;
            this.BorderPanel.BorderThickness = 5;
            this.BorderPanel.Location = new System.Drawing.Point(425, -11);
            this.BorderPanel.Name = "BorderPanel";
            this.BorderPanel.Size = new System.Drawing.Size(54, 598);
            this.BorderPanel.TabIndex = 5;
            this.BorderPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.BorderPanel_Paint);
            // 
            // LoginName
            // 
            this.LoginName.Animated = true;
            this.LoginName.AutoRoundedCorners = true;
            this.LoginName.BorderRadius = 15;
            this.LoginName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LoginName.DefaultText = "";
            this.LoginName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.LoginName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.LoginName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.LoginName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.LoginName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LoginName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LoginName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LoginName.Location = new System.Drawing.Point(131, 162);
            this.LoginName.Name = "LoginName";
            this.LoginName.PasswordChar = '\0';
            this.LoginName.PlaceholderText = "Username";
            this.LoginName.SelectedText = "";
            this.LoginName.Size = new System.Drawing.Size(318, 33);
            this.LoginName.TabIndex = 6;
            this.LoginName.TextChanged += new System.EventHandler(this.LoginName_TextChanged);
            // 
            // LoginPassword
            // 
            this.LoginPassword.Animated = true;
            this.LoginPassword.AutoRoundedCorners = true;
            this.LoginPassword.BorderRadius = 15;
            this.LoginPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LoginPassword.DefaultText = "";
            this.LoginPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.LoginPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.LoginPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.LoginPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.LoginPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LoginPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LoginPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LoginPassword.Location = new System.Drawing.Point(131, 201);
            this.LoginPassword.Name = "LoginPassword";
            this.LoginPassword.PasswordChar = '\0';
            this.LoginPassword.PlaceholderText = "Password";
            this.LoginPassword.SelectedText = "";
            this.LoginPassword.Size = new System.Drawing.Size(318, 33);
            this.LoginPassword.TabIndex = 7;
            this.LoginPassword.TextChanged += new System.EventHandler(this.LoginPassword_TextChanged);
            // 
            // LoginText
            // 
            this.LoginText.AutoSize = true;
            this.LoginText.BackColor = System.Drawing.Color.Transparent;
            this.LoginText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginText.Location = new System.Drawing.Point(244, 121);
            this.LoginText.Name = "LoginText";
            this.LoginText.Size = new System.Drawing.Size(101, 37);
            this.LoginText.TabIndex = 8;
            this.LoginText.Text = "Login";
            // 
            // LogoPanel
            // 
            this.LogoPanel.AutoRoundedCorners = true;
            this.LogoPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LogoPanel.BackgroundImage")));
            this.LogoPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LogoPanel.BorderRadius = 77;
            this.LogoPanel.BorderThickness = 4;
            this.LogoPanel.Location = new System.Drawing.Point(0, 0);
            this.LogoPanel.Name = "LogoPanel";
            this.LogoPanel.Size = new System.Drawing.Size(178, 156);
            this.LogoPanel.TabIndex = 9;
            // 
            // LoginButton
            // 
            this.LoginButton.Animated = true;
            this.LoginButton.AutoRoundedCorners = true;
            this.LoginButton.BorderRadius = 19;
            this.LoginButton.DialogResult = System.Windows.Forms.DialogResult.Retry;
            this.LoginButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.LoginButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.LoginButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.LoginButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.LoginButton.FillColor = System.Drawing.Color.Crimson;
            this.LoginButton.FocusedColor = System.Drawing.Color.IndianRed;
            this.LoginButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LoginButton.ForeColor = System.Drawing.Color.White;
            this.LoginButton.Location = new System.Drawing.Point(206, 240);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(164, 40);
            this.LoginButton.TabIndex = 10;
            this.LoginButton.Text = "Login";
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // RegisterName
            // 
            this.RegisterName.Animated = true;
            this.RegisterName.AutoRoundedCorners = true;
            this.RegisterName.BorderRadius = 15;
            this.RegisterName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RegisterName.DefaultText = "";
            this.RegisterName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.RegisterName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.RegisterName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.RegisterName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.RegisterName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RegisterName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RegisterName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RegisterName.Location = new System.Drawing.Point(131, 362);
            this.RegisterName.Name = "RegisterName";
            this.RegisterName.PasswordChar = '\0';
            this.RegisterName.PlaceholderText = "Username";
            this.RegisterName.SelectedText = "";
            this.RegisterName.Size = new System.Drawing.Size(318, 33);
            this.RegisterName.TabIndex = 11;
            this.RegisterName.TextChanged += new System.EventHandler(this.RegisterName_TextChanged);
            // 
            // RegisterPassword1
            // 
            this.RegisterPassword1.Animated = true;
            this.RegisterPassword1.AutoRoundedCorners = true;
            this.RegisterPassword1.BorderRadius = 15;
            this.RegisterPassword1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RegisterPassword1.DefaultText = "";
            this.RegisterPassword1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.RegisterPassword1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.RegisterPassword1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.RegisterPassword1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.RegisterPassword1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RegisterPassword1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RegisterPassword1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RegisterPassword1.Location = new System.Drawing.Point(131, 401);
            this.RegisterPassword1.Name = "RegisterPassword1";
            this.RegisterPassword1.PasswordChar = '\0';
            this.RegisterPassword1.PlaceholderText = "Password";
            this.RegisterPassword1.SelectedText = "";
            this.RegisterPassword1.Size = new System.Drawing.Size(318, 33);
            this.RegisterPassword1.TabIndex = 12;
            this.RegisterPassword1.TextChanged += new System.EventHandler(this.RegisterPassword1_TextChanged);
            // 
            // RegisterPassword2
            // 
            this.RegisterPassword2.Animated = true;
            this.RegisterPassword2.AutoRoundedCorners = true;
            this.RegisterPassword2.BorderRadius = 15;
            this.RegisterPassword2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RegisterPassword2.DefaultText = "";
            this.RegisterPassword2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.RegisterPassword2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.RegisterPassword2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.RegisterPassword2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.RegisterPassword2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RegisterPassword2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RegisterPassword2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RegisterPassword2.Location = new System.Drawing.Point(131, 440);
            this.RegisterPassword2.Name = "RegisterPassword2";
            this.RegisterPassword2.PasswordChar = '\0';
            this.RegisterPassword2.PlaceholderText = "Confirm Password";
            this.RegisterPassword2.SelectedText = "";
            this.RegisterPassword2.Size = new System.Drawing.Size(318, 33);
            this.RegisterPassword2.TabIndex = 13;
            this.RegisterPassword2.TextChanged += new System.EventHandler(this.RegisterPassword2_TextChanged);
            // 
            // RegisterText
            // 
            this.RegisterText.AutoSize = true;
            this.RegisterText.BackColor = System.Drawing.Color.Transparent;
            this.RegisterText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterText.Location = new System.Drawing.Point(220, 324);
            this.RegisterText.Name = "RegisterText";
            this.RegisterText.Size = new System.Drawing.Size(142, 37);
            this.RegisterText.TabIndex = 14;
            this.RegisterText.Text = "Register";
            // 
            // RegisterButton
            // 
            this.RegisterButton.Animated = true;
            this.RegisterButton.AutoRoundedCorners = true;
            this.RegisterButton.BorderRadius = 19;
            this.RegisterButton.DialogResult = System.Windows.Forms.DialogResult.Retry;
            this.RegisterButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.RegisterButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.RegisterButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.RegisterButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.RegisterButton.FillColor = System.Drawing.Color.Crimson;
            this.RegisterButton.FocusedColor = System.Drawing.Color.IndianRed;
            this.RegisterButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RegisterButton.ForeColor = System.Drawing.Color.White;
            this.RegisterButton.Location = new System.Drawing.Point(206, 479);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(164, 40);
            this.RegisterButton.TabIndex = 15;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
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
            // MoveControl
            // 
            this.MoveControl.DockIndicatorTransparencyValue = 0.6D;
            this.MoveControl.TargetControl = this.MovePanel;
            this.MoveControl.UseTransparentDrag = true;
            // 
            // MovePanel
            // 
            this.MovePanel.BackColor = System.Drawing.Color.Transparent;
            this.MovePanel.Controls.Add(this.ExitButton);
            this.MovePanel.Controls.Add(this.MinimizeButton);
            this.MovePanel.Location = new System.Drawing.Point(0, 0);
            this.MovePanel.Name = "MovePanel";
            this.MovePanel.Size = new System.Drawing.Size(1024, 30);
            this.MovePanel.TabIndex = 18;
            this.MovePanel.UseTransparentBackground = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1024, 576);
            this.Controls.Add(this.MovePanel);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.RegisterText);
            this.Controls.Add(this.RegisterPassword2);
            this.Controls.Add(this.RegisterPassword1);
            this.Controls.Add(this.RegisterName);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.LogoPanel);
            this.Controls.Add(this.LoginText);
            this.Controls.Add(this.LoginPassword);
            this.Controls.Add(this.LoginName);
            this.Controls.Add(this.BorderPanel);
            this.Controls.Add(this.BackgroundPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MovePanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel BackgroundPanel;
        private Guna.UI2.WinForms.Guna2Panel BorderPanel;
        private Guna.UI2.WinForms.Guna2TextBox LoginName;
        private Guna.UI2.WinForms.Guna2TextBox LoginPassword;
        private System.Windows.Forms.Label LoginText;
        private Guna.UI2.WinForms.Guna2Panel LogoPanel;
        private Guna.UI2.WinForms.Guna2Button LoginButton;
        private Guna.UI2.WinForms.Guna2TextBox RegisterName;
        private Guna.UI2.WinForms.Guna2TextBox RegisterPassword1;
        private Guna.UI2.WinForms.Guna2TextBox RegisterPassword2;
        private System.Windows.Forms.Label RegisterText;
        private Guna.UI2.WinForms.Guna2Button RegisterButton;
        private Guna.UI2.WinForms.Guna2ControlBox ExitButton;
        private Guna.UI2.WinForms.Guna2ControlBox MinimizeButton;
        private Guna.UI2.WinForms.Guna2DragControl MoveControl;
        private Guna.UI2.WinForms.Guna2Panel MovePanel;
    }
}

