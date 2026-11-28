namespace _19_WinForm_2
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
            txt_fullName = new TextBox();
            label2 = new Label();
            cmb_university = new ComboBox();
            rd_man = new RadioButton();
            rd_woman = new RadioButton();
            label3 = new Label();
            grp_lessons = new GroupBox();
            chck_unity = new CheckBox();
            chck_go = new CheckBox();
            chck_python = new CheckBox();
            chck_java = new CheckBox();
            chck_sql = new CheckBox();
            chck_cSharp = new CheckBox();
            label4 = new Label();
            nmr_age = new NumericUpDown();
            label5 = new Label();
            dt_birth = new DateTimePicker();
            label6 = new Label();
            pct_profile = new PictureBox();
            lstbx_student = new ListBox();
            btn_save = new Button();
            btn_picture = new Button();
            lstvw_student = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            grp_lessons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmr_age).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pct_profile).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 30);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 0;
            label1.Text = "AD SOYAD:";
            // 
            // txt_fullName
            // 
            txt_fullName.Location = new Point(133, 22);
            txt_fullName.Name = "txt_fullName";
            txt_fullName.Size = new Size(202, 23);
            txt_fullName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 75);
            label2.Name = "label2";
            label2.Size = new Size(71, 15);
            label2.TabIndex = 2;
            label2.Text = "ÜNİVERSİTE:";
            // 
            // cmb_university
            // 
            cmb_university.FormattingEnabled = true;
            cmb_university.Items.AddRange(new object[] { "Boğaziçi ", "İstanbul", "Yıldız Teknik", "Marmara", "İTÜ", "Gazi", "ODTÜ" });
            cmb_university.Location = new Point(134, 68);
            cmb_university.Name = "cmb_university";
            cmb_university.Size = new Size(199, 23);
            cmb_university.TabIndex = 3;
            // 
            // rd_man
            // 
            rd_man.AutoSize = true;
            rd_man.Location = new Point(146, 120);
            rd_man.Name = "rd_man";
            rd_man.Size = new Size(53, 19);
            rd_man.TabIndex = 4;
            rd_man.TabStop = true;
            rd_man.Text = "Erkek";
            rd_man.UseVisualStyleBackColor = true;
            // 
            // rd_woman
            // 
            rd_woman.AutoSize = true;
            rd_woman.Location = new Point(259, 120);
            rd_woman.Name = "rd_woman";
            rd_woman.Size = new Size(55, 19);
            rd_woman.TabIndex = 5;
            rd_woman.TabStop = true;
            rd_woman.Text = "Kadın";
            rd_woman.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 124);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 6;
            label3.Text = "CİNSİYET:";
            // 
            // grp_lessons
            // 
            grp_lessons.Controls.Add(chck_unity);
            grp_lessons.Controls.Add(chck_go);
            grp_lessons.Controls.Add(chck_python);
            grp_lessons.Controls.Add(chck_java);
            grp_lessons.Controls.Add(chck_sql);
            grp_lessons.Controls.Add(chck_cSharp);
            grp_lessons.Location = new Point(29, 158);
            grp_lessons.Name = "grp_lessons";
            grp_lessons.Size = new Size(304, 108);
            grp_lessons.TabIndex = 7;
            grp_lessons.TabStop = false;
            grp_lessons.Text = "DERSLER";
            // 
            // chck_unity
            // 
            chck_unity.AutoSize = true;
            chck_unity.Location = new Point(171, 74);
            chck_unity.Name = "chck_unity";
            chck_unity.Size = new Size(59, 19);
            chck_unity.TabIndex = 5;
            chck_unity.Text = "UNITY";
            chck_unity.UseVisualStyleBackColor = true;
            // 
            // chck_go
            // 
            chck_go.AutoSize = true;
            chck_go.Location = new Point(171, 47);
            chck_go.Name = "chck_go";
            chck_go.Size = new Size(74, 19);
            chck_go.TabIndex = 4;
            chck_go.Text = "GOLANG";
            chck_go.UseVisualStyleBackColor = true;
            // 
            // chck_python
            // 
            chck_python.AutoSize = true;
            chck_python.Location = new Point(173, 22);
            chck_python.Name = "chck_python";
            chck_python.Size = new Size(73, 19);
            chck_python.TabIndex = 3;
            chck_python.Text = "PYTHON";
            chck_python.UseVisualStyleBackColor = true;
            // 
            // chck_java
            // 
            chck_java.AutoSize = true;
            chck_java.Location = new Point(59, 74);
            chck_java.Name = "chck_java";
            chck_java.Size = new Size(51, 19);
            chck_java.TabIndex = 2;
            chck_java.Text = "JAVA";
            chck_java.UseVisualStyleBackColor = true;
            // 
            // chck_sql
            // 
            chck_sql.AutoSize = true;
            chck_sql.Location = new Point(59, 47);
            chck_sql.Name = "chck_sql";
            chck_sql.Size = new Size(47, 19);
            chck_sql.TabIndex = 1;
            chck_sql.Text = "SQL";
            chck_sql.UseVisualStyleBackColor = true;
            // 
            // chck_cSharp
            // 
            chck_cSharp.AutoSize = true;
            chck_cSharp.Location = new Point(61, 22);
            chck_cSharp.Name = "chck_cSharp";
            chck_cSharp.Size = new Size(41, 19);
            chck_cSharp.TabIndex = 0;
            chck_cSharp.Text = "C#";
            chck_cSharp.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(355, 182);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 8;
            label4.Text = "YAŞ:";
            // 
            // nmr_age
            // 
            nmr_age.Location = new Point(457, 180);
            nmr_age.Minimum = new decimal(new int[] { 7, 0, 0, 0 });
            nmr_age.Name = "nmr_age";
            nmr_age.Size = new Size(200, 23);
            nmr_age.TabIndex = 9;
            nmr_age.Value = new decimal(new int[] { 7, 0, 0, 0 });
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(355, 238);
            label5.Name = "label5";
            label5.Size = new Size(92, 15);
            label5.TabIndex = 10;
            label5.Text = "DOĞUM TARİHİ:";
            // 
            // dt_birth
            // 
            dt_birth.Location = new Point(457, 232);
            dt_birth.MaxDate = new DateTime(2030, 12, 30, 0, 0, 0, 0);
            dt_birth.Name = "dt_birth";
            dt_birth.Size = new Size(200, 23);
            dt_birth.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(361, 30);
            label6.Name = "label6";
            label6.Size = new Size(84, 15);
            label6.TabIndex = 12;
            label6.Text = "PROFİL RESMİ:";
            // 
            // pct_profile
            // 
            pct_profile.Location = new Point(451, 30);
            pct_profile.Name = "pct_profile";
            pct_profile.Size = new Size(106, 109);
            pct_profile.SizeMode = PictureBoxSizeMode.StretchImage;
            pct_profile.TabIndex = 13;
            pct_profile.TabStop = false;
            // 
            // lstbx_student
            // 
            lstbx_student.FormattingEnabled = true;
            lstbx_student.Location = new Point(31, 289);
            lstbx_student.Name = "lstbx_student";
            lstbx_student.Size = new Size(626, 199);
            lstbx_student.TabIndex = 14;
            // 
            // btn_save
            // 
            btn_save.Location = new Point(582, 498);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(75, 23);
            btn_save.TabIndex = 15;
            btn_save.Text = "KAYDET";
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += btn_save_Click;
            // 
            // btn_picture
            // 
            btn_picture.Location = new Point(582, 116);
            btn_picture.Name = "btn_picture";
            btn_picture.Size = new Size(75, 23);
            btn_picture.TabIndex = 16;
            btn_picture.Text = "Resim Yükle";
            btn_picture.UseVisualStyleBackColor = true;
            btn_picture.Click += btn_picture_Click;
            // 
            // lstvw_student
            // 
            lstvw_student.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            lstvw_student.Location = new Point(704, 265);
            lstvw_student.Name = "lstvw_student";
            lstvw_student.Size = new Size(477, 223);
            lstvw_student.TabIndex = 17;
            lstvw_student.UseCompatibleStateImageBehavior = false;
            lstvw_student.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Ad Soyad";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Üniversite";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Cinsiyet";
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Doğum Tarihi";
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Yaş";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1238, 533);
            Controls.Add(lstvw_student);
            Controls.Add(btn_picture);
            Controls.Add(btn_save);
            Controls.Add(lstbx_student);
            Controls.Add(pct_profile);
            Controls.Add(label6);
            Controls.Add(dt_birth);
            Controls.Add(label5);
            Controls.Add(nmr_age);
            Controls.Add(label4);
            Controls.Add(grp_lessons);
            Controls.Add(label3);
            Controls.Add(rd_woman);
            Controls.Add(rd_man);
            Controls.Add(cmb_university);
            Controls.Add(label2);
            Controls.Add(txt_fullName);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            grp_lessons.ResumeLayout(false);
            grp_lessons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmr_age).EndInit();
            ((System.ComponentModel.ISupportInitialize)pct_profile).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_fullName;
        private Label label2;
        private ComboBox cmb_university;
        private RadioButton rd_man;
        private RadioButton rd_woman;
        private Label label3;
        private GroupBox grp_lessons;
        private CheckBox chck_cSharp;
        private CheckBox chck_unity;
        private CheckBox chck_go;
        private CheckBox chck_python;
        private CheckBox chck_java;
        private CheckBox chck_sql;
        private Label label4;
        private NumericUpDown nmr_age;
        private Label label5;
        private DateTimePicker dt_birth;
        private Label label6;
        private PictureBox pct_profile;
        private ListBox lstbx_student;
        private Button btn_save;
        private Button btn_picture;
        private ListView lstvw_student;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
    }
}
