namespace TapAz.Forms
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
            labelUsername = new Label();
            textBox1 = new TextBox();
            buttonLogin = new Button();
            textBox2 = new TextBox();
            labelPassword = new Label();
            SuspendLayout();
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Location = new Point(66, 131);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(99, 28);
            labelUsername.TabIndex = 0;
            labelUsername.Text = "Username";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(175, 128);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(383, 34);
            textBox1.TabIndex = 1;
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(175, 250);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(383, 57);
            buttonLogin.TabIndex = 3;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(175, 189);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(383, 34);
            textBox2.TabIndex = 2;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(66, 192);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(93, 28);
            labelPassword.TabIndex = 3;
            labelPassword.Text = "Password";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateBlue;
            ClientSize = new Size(657, 469);
            Controls.Add(textBox2);
            Controls.Add(labelPassword);
            Controls.Add(buttonLogin);
            Controls.Add(textBox1);
            Controls.Add(labelUsername);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 4, 4, 4);
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelUsername;
        private TextBox textBox1;
        private Button buttonLogin;
        private TextBox textBox2;
        private Label labelPassword;
    }
}