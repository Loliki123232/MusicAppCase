namespace MusicAppCase
{
    partial class WelcomeForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtBoxLogin = new TextBox();
            label2 = new Label();
            txtBoxPassword = new TextBox();
            checkBox1 = new CheckBox();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 46);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // txtBoxLogin
            // 
            txtBoxLogin.Location = new Point(12, 64);
            txtBoxLogin.Name = "txtBoxLogin";
            txtBoxLogin.Size = new Size(222, 23);
            txtBoxLogin.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 94);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 0;
            label2.Text = "Password";
            // 
            // txtBoxPassword
            // 
            txtBoxPassword.Location = new Point(12, 112);
            txtBoxPassword.Name = "txtBoxPassword";
            txtBoxPassword.PasswordChar = '•';
            txtBoxPassword.Size = new Size(222, 23);
            txtBoxPassword.TabIndex = 1;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(240, 112);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(76, 19);
            checkBox1.TabIndex = 2;
            checkBox1.Text = "Показать";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(106, 433);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Вход";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // WelcomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(330, 489);
            Controls.Add(btnLogin);
            Controls.Add(checkBox1);
            Controls.Add(txtBoxPassword);
            Controls.Add(label2);
            Controls.Add(txtBoxLogin);
            Controls.Add(label1);
            Name = "WelcomeForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtBoxLogin;
        private Label label2;
        private TextBox txtBoxPassword;
        private CheckBox checkBox1;
        private Button btnLogin;
    }
}
