namespace bengaleiro
{
    partial class Login
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
            btn_login = new Button();
            label1 = new Label();
            txt_user = new TextBox();
            label2 = new Label();
            txt_pw = new TextBox();
            SuspendLayout();
            // 
            // btn_login
            // 
            btn_login.Location = new Point(69, 153);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(75, 23);
            btn_login.TabIndex = 0;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 9);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 1;
            label1.Text = "Username";
            // 
            // txt_user
            // 
            txt_user.Location = new Point(57, 27);
            txt_user.Name = "txt_user";
            txt_user.Size = new Size(100, 23);
            txt_user.TabIndex = 2;
            txt_user.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 82);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // txt_pw
            // 
            txt_pw.Location = new Point(57, 100);
            txt_pw.Name = "txt_pw";
            txt_pw.PasswordChar = '*';
            txt_pw.Size = new Size(100, 23);
            txt_pw.TabIndex = 4;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(216, 188);
            Controls.Add(txt_pw);
            Controls.Add(label2);
            Controls.Add(txt_user);
            Controls.Add(label1);
            Controls.Add(btn_login);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_login;
        private Label label1;
        private TextBox txt_user;
        private Label label2;
        private TextBox txt_pw;
    }
}