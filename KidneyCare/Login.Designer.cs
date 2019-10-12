namespace KidneyCare
{
    partial class LoginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            this.LoginDisplay = new System.Windows.Forms.Panel();
            this.LoginPageDisplayImage = new System.Windows.Forms.PictureBox();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.loginButton = new System.Windows.Forms.Button();
            this.loginText = new System.Windows.Forms.TextBox();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.signupButton = new System.Windows.Forms.Button();
            this.forgotPassword = new System.Windows.Forms.Label();
            this.LoginDisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoginPageDisplayImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginDisplay
            // 
            this.LoginDisplay.Controls.Add(this.LoginPageDisplayImage);
            this.LoginDisplay.Dock = System.Windows.Forms.DockStyle.Left;
            this.LoginDisplay.Location = new System.Drawing.Point(0, 0);
            this.LoginDisplay.Name = "LoginDisplay";
            this.LoginDisplay.Size = new System.Drawing.Size(400, 500);
            this.LoginDisplay.TabIndex = 0;
            // 
            // LoginPageDisplayImage
            // 
            this.LoginPageDisplayImage.Image = ((System.Drawing.Image)(resources.GetObject("LoginPageDisplayImage.Image")));
            this.LoginPageDisplayImage.Location = new System.Drawing.Point(0, 0);
            this.LoginPageDisplayImage.Name = "LoginPageDisplayImage";
            this.LoginPageDisplayImage.Size = new System.Drawing.Size(400, 500);
            this.LoginPageDisplayImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LoginPageDisplayImage.TabIndex = 0;
            this.LoginPageDisplayImage.TabStop = false;
            // 
            // Logo
            // 
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(479, 27);
            this.Logo.Margin = new System.Windows.Forms.Padding(0);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(250, 200);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 1;
            this.Logo.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Location = new System.Drawing.Point(479, 226);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 1);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.Location = new System.Drawing.Point(479, 301);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 1);
            this.panel2.TabIndex = 4;
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(126)))), ((int)(((byte)(175)))));
            this.loginButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("Calibri Light", 15.75F);
            this.loginButton.ForeColor = System.Drawing.Color.White;
            this.loginButton.Location = new System.Drawing.Point(479, 382);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(110, 40);
            this.loginButton.TabIndex = 7;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            // 
            // loginText
            // 
            this.loginText.BackColor = System.Drawing.Color.White;
            this.loginText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.loginText.Font = new System.Drawing.Font("Calibri Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginText.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.loginText.Location = new System.Drawing.Point(479, 197);
            this.loginText.Name = "loginText";
            this.loginText.Size = new System.Drawing.Size(250, 30);
            this.loginText.TabIndex = 9;
            this.loginText.Text = "User Name";
            this.loginText.Enter += new System.EventHandler(this.LoginText_Enter);
            this.loginText.Leave += new System.EventHandler(this.LoginText_Leave);
            // 
            // passwordText
            // 
            this.passwordText.BackColor = System.Drawing.Color.White;
            this.passwordText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordText.Font = new System.Drawing.Font("Calibri Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordText.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.passwordText.Location = new System.Drawing.Point(479, 272);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(250, 30);
            this.passwordText.TabIndex = 10;
            this.passwordText.Text = "Password";
            this.passwordText.Enter += new System.EventHandler(this.PasswordText_Enter);
            this.passwordText.Leave += new System.EventHandler(this.PasswordText_Leave);
            // 
            // signupButton
            // 
            this.signupButton.BackColor = System.Drawing.Color.White;
            this.signupButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.signupButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signupButton.Font = new System.Drawing.Font("Calibri Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(126)))), ((int)(((byte)(175)))));
            this.signupButton.Location = new System.Drawing.Point(619, 382);
            this.signupButton.Name = "signupButton";
            this.signupButton.Size = new System.Drawing.Size(110, 40);
            this.signupButton.TabIndex = 11;
            this.signupButton.Text = "Sign Up";
            this.signupButton.UseVisualStyleBackColor = false;
            // 
            // forgotPassword
            // 
            this.forgotPassword.AutoSize = true;
            this.forgotPassword.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgotPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(126)))), ((int)(((byte)(175)))));
            this.forgotPassword.Location = new System.Drawing.Point(638, 321);
            this.forgotPassword.Name = "forgotPassword";
            this.forgotPassword.Size = new System.Drawing.Size(90, 13);
            this.forgotPassword.TabIndex = 12;
            this.forgotPassword.Text = "forgot password ?";
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.forgotPassword);
            this.Controls.Add(this.signupButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LoginDisplay);
            this.Controls.Add(this.loginText);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.Logo);
            this.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Page";
            this.LoginDisplay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LoginPageDisplayImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel LoginDisplay;
        private System.Windows.Forms.PictureBox LoginPageDisplayImage;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox loginText;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.Button signupButton;
        private System.Windows.Forms.Label forgotPassword;
    }
}

