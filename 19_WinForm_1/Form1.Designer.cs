namespace _19_WinForm_1
{
    partial class Form1
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
            txt_username = new TextBox();
            txt_password = new TextBox();
            label2 = new Label();
            groupBox1 = new GroupBox();
            btn_login = new Button();
            lnk_register = new LinkLabel();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(23, 53);
            label1.Name = "label1";
            label1.Size = new Size(124, 25);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Adı:";
            // 
            // txt_username
            // 
            txt_username.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txt_username.Location = new Point(153, 53);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(166, 29);
            txt_username.TabIndex = 1;
            // 
            // txt_password
            // 
            txt_password.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txt_password.Location = new Point(153, 109);
            txt_password.Name = "txt_password";
            txt_password.PasswordChar = '*';
            txt_password.Size = new Size(166, 29);
            txt_password.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(23, 109);
            label2.Name = "label2";
            label2.Size = new Size(56, 25);
            label2.TabIndex = 2;
            label2.Text = "Şifre:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lnk_register);
            groupBox1.Controls.Add(btn_login);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txt_password);
            groupBox1.Controls.Add(txt_username);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox1.Location = new Point(27, 32);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(357, 259);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "KULLANICI GİRİŞ PANELİ";
            // 
            // btn_login
            // 
            btn_login.Location = new Point(153, 160);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(166, 31);
            btn_login.TabIndex = 4;
            btn_login.Text = "GİRİŞ";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // lnk_register
            // 
            lnk_register.AutoSize = true;
            lnk_register.Location = new Point(211, 210);
            lnk_register.Name = "lnk_register";
            lnk_register.Size = new Size(80, 25);
            lnk_register.TabIndex = 5;
            lnk_register.TabStop = true;
            lnk_register.Text = "Kayıt Ol";
            lnk_register.LinkClicked += lnk_register_LinkClicked;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 344);
            Controls.Add(groupBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox txt_username;
        private TextBox txt_password;
        private Label label2;
        private GroupBox groupBox1;
        private Button btn_login;
        private LinkLabel lnk_register;
    }
}
