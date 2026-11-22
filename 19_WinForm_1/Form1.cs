namespace _19_WinForm_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txt_username.Text;
            string sifre = txt_password.Text;

            MessageBox.Show(kullaniciAdi);
        }

        private void lnk_register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();

            Register register = new Register();
            register.Show();
        }
    }
}
