using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _19_WinForm_1
{
    public partial class Register : Form
    {
        List<Uye> uyeler = new List<Uye>();
        public Register()
        {
            InitializeComponent();

            //Uye kayıt formu yapalım
            /*
            Ad
            Soyad
            Kullanıcıadı
            şifre
            Email 
                
            bilgilerini alarak bir listeye ekleyiniz.
             
             */
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            Uye uye = new Uye();
            uye.Email = txt_email.Text;
            uye.KullaniciAdi = txt_username.Text;
            uye.Ad = txt_name.Text;
            uye.Soyad = txt_surname.Text;
            uye.Sifre = txt_password.Text;

            uyeler.Add(uye);
        }
    }
}
