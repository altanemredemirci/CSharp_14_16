namespace _19_WinForm_1
{
    partial class Register
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
            groupBox1 = new GroupBox();
            btn_register = new Button();
            txt_password = new TextBox();
            label5 = new Label();
            label4 = new Label();
            txt_email = new TextBox();
            label3 = new Label();
            label2 = new Label();
            txt_surname = new TextBox();
            txt_username = new TextBox();
            label1 = new Label();
            txt_name = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_register);
            groupBox1.Controls.Add(txt_password);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txt_email);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txt_surname);
            groupBox1.Controls.Add(txt_username);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txt_name);
            groupBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox1.Location = new Point(25, 26);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(440, 336);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "KAYIT PANELİ";
            // 
            // btn_register
            // 
            btn_register.Location = new Point(157, 286);
            btn_register.Name = "btn_register";
            btn_register.Size = new Size(225, 33);
            btn_register.TabIndex = 10;
            btn_register.Text = "Kayıt Ol";
            btn_register.UseVisualStyleBackColor = true;
            btn_register.Click += btn_register_Click;
            // 
            // txt_password
            // 
            txt_password.Font = new Font("Microsoft Sans Serif", 12F);
            txt_password.Location = new Point(157, 245);
            txt_password.Name = "txt_password";
            txt_password.PasswordChar = '*';
            txt_password.Size = new Size(225, 26);
            txt_password.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F);
            label5.Location = new Point(27, 245);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 8;
            label5.Text = "Şifre:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F);
            label4.Location = new Point(27, 199);
            label4.Name = "label4";
            label4.Size = new Size(52, 20);
            label4.TabIndex = 6;
            label4.Text = "Email:";
            // 
            // txt_email
            // 
            txt_email.Font = new Font("Microsoft Sans Serif", 12F);
            txt_email.Location = new Point(157, 199);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(225, 26);
            txt_email.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F);
            label3.Location = new Point(27, 101);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 4;
            label3.Text = "Soyad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F);
            label2.Location = new Point(27, 149);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 4;
            label2.Text = "Kullanıcı Adı:";
            // 
            // txt_surname
            // 
            txt_surname.Font = new Font("Microsoft Sans Serif", 12F);
            txt_surname.Location = new Point(157, 101);
            txt_surname.Name = "txt_surname";
            txt_surname.Size = new Size(225, 26);
            txt_surname.TabIndex = 5;
            // 
            // txt_username
            // 
            txt_username.Font = new Font("Microsoft Sans Serif", 12F);
            txt_username.Location = new Point(157, 149);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(225, 26);
            txt_username.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F);
            label1.Location = new Point(27, 52);
            label1.Name = "label1";
            label1.Size = new Size(33, 20);
            label1.TabIndex = 2;
            label1.Text = "Ad:";
            // 
            // txt_name
            // 
            txt_name.Font = new Font("Microsoft Sans Serif", 12F);
            txt_name.Location = new Point(157, 52);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(225, 26);
            txt_name.TabIndex = 3;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(494, 390);
            Controls.Add(groupBox1);
            Name = "Register";
            Text = "Register";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label4;
        private TextBox txt_email;
        private Label label3;
        private Label label2;
        private TextBox txt_surname;
        private TextBox txt_username;
        private Label label1;
        private TextBox txt_name;
        private TextBox txt_password;
        private Label label5;
        private Button btn_register;
    }
}