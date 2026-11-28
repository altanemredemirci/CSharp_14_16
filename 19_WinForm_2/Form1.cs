using System.Security.Cryptography;

namespace _19_WinForm_2
{
    public partial class Form1 : Form
    {
        Student student; 
        public Form1()
        {
            InitializeComponent();
            cmb_university.SelectedIndex = 0;
            dt_birth.MaxDate = DateTime.Now;
            student = new Student();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            
            student.NameSurname = txt_fullName.Text;
            student.University = cmb_university.Text;
            student.Gender = rd_man.Checked == true ? rd_man.Text : rd_woman.Text;
            student.Age = (int)(nmr_age.Value);
            student.BirthDate = dt_birth.Value;
           

            foreach (CheckBox item in grp_lessons.Controls)
            {
                if (item.Checked)
                {
                    student.Lessons.Add(item.Text);
                }
            }

            lstbx_student.Items.Add(student.NameSurname+" "+student.Gender+" "+student.Age+" "+student.BirthDate+" "+student.University+" "+student.Lessons.Select(i=> i));

            ListViewItem lvi = new ListViewItem();
            lvi.Text = student.NameSurname;
            lvi.SubItems.Add(student.University);
            lvi.SubItems.Add(student.Gender);
            lvi.SubItems.Add(student.BirthDate.ToString());
            lvi.SubItems.Add(student.Age.ToString());


            lstvw_student.Items.Add(lvi);

        }

        private void btn_picture_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string kaynakYol = ofd.FileName;

                    // Hedef klasörü belirle (Uygulama dizini içinde 'YuklenenDosyalar')
                    string hedefKlasor = Path.Combine("D:\\AltanEmre\\HS_14_16\\CSharp_14_16\\19_WinForm_2\\Images");

                    // Klasör yoksa oluştur
                    if (!Directory.Exists(hedefKlasor))
                    {
                        Directory.CreateDirectory(hedefKlasor);
                    }

                    // Aynı isimli dosyaların üzerine yazılmasını önlemek için benzersiz isim oluştur
                    string orijinalAd = Path.GetFileNameWithoutExtension(kaynakYol);
                    string uzanti = Path.GetExtension(kaynakYol);
                    string yeniDosyaAdi = $"{orijinalAd}_{DateTime.Now:yyyyMMdd_HHmmss}{uzanti}";

                    string hedefYol = Path.Combine(hedefKlasor, yeniDosyaAdi);

                    // Dosyayı kopyala (3. parametre 'true' ise aynı isimde dosya varsa üzerine yazar)
                    File.Copy(kaynakYol, hedefYol, true);

                    MessageBox.Show("Dosya başarıyla kopyalandı:\n" + hedefYol, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    student.ProfileImage = yeniDosyaAdi;

                    pct_profile.Image = Image.FromFile(ofd.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kopyalama sırasında hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
