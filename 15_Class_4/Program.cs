namespace _15_Class_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>();

            #region 1.Kayit
            User user = new User();
            user.Username = "altanemre";
            user.FullName = "Altan Emre Demirci";
            user.Password = "1";
            user.Email = "altanemre@gmail.com";
            users.Add(user);
            #endregion

            #region 2.Kayit

            User user2 = new User()
            {
                Username = "omer",
                Password="1",
                Email="omertaskin@gmail.com",
                FullName="Ömer Taşkın"
            };
            users.Add(user2);

            #endregion

            #region 3.Kayit
            //List<User> kullanicilar = new List<User>()
            //{
            //    new User(){Username="poyraz1907", Email="sampiyonfener@gmail.com", FullName="Poyraz Sarıkanarya",Password="1"},
            //    new User(){Username="poyraz1906", Email="sampiyonfener1@gmail.com", FullName="Poyraz Sarıkanarya",Password="1"},
            //    new User(){Username="poyraz1904", Email="sampiyonfener2@gmail.com", FullName="Poyraz Sarıkanarya",Password="1"},
            //    new User(){Username="poyraz1903", Email="sampiyonfener3@gmail.com", FullName="Poyraz Sarıkanarya",Password="1"},
            //    new User(){Username="poyraz1902", Email="sampiyonfener4@gmail.com", FullName="Poyraz Sarıkanarya",Password="1"}
            //};
            #endregion


            while (true)
            {
                Console.WriteLine("1-Kayıt Ol\n2-Giriş Yap\n3-Sil");
                int secim = Convert.ToInt32(Console.ReadLine());

                if (secim == 1)
                {
                    User.Kaydet(users);
                }
                else if(secim==2)
                {
                    User kullanici = User.Giris(users);

                    if (kullanici == null)
                    {
                        Console.WriteLine("Böyle bir kullanıcı bulunamadı");
                    }
                    else
                    {
                        Console.WriteLine(kullanici.Username);
                        Console.WriteLine(kullanici.Email);
                        Console.WriteLine(kullanici.FullName);
                    }
                }
                else if (secim == 3)
                {
                    User.Sil(users);
                }

            } 
        }
    }

    class User
    {
        public string Username;
        public string Password;
        public string Email;
        public string FullName;

        public static void Kaydet(List<User> liste)
        {
            User user = new User();
            Console.WriteLine("Ad Soyad:");
            user.FullName = Console.ReadLine();

            Console.WriteLine("Email:");
            user.Email = Console.ReadLine();

            Console.WriteLine("Kullanıcı Adı:");
            user.Username = Console.ReadLine();

            Console.WriteLine("Şifre:");
            user.Password = Console.ReadLine();

            liste.Add(user);
        }

        public static User Giris(List<User> users)
        {
            Console.WriteLine("Username:");
            string kullaniciAdi = Console.ReadLine();

            Console.WriteLine("Password:");
            string password = Console.ReadLine();

            foreach (User user in users)
            {
                if(kullaniciAdi==user.Username && password == user.Password)
                {
                    return user;
                }
            }

            return null;
        }

        private static void Listele(List<User> users)
        {
            foreach (User user in users)
            {
                Console.WriteLine("Kullanıcı Adı:"+user.Username);
                Console.WriteLine("Email:"+user.Email);
                Console.WriteLine("Ad Soyad:"+user.FullName);
                Console.WriteLine("------------------");
            }
        }

        public static void Sil(List<User> users)
        {
            Listele(users);

            Console.WriteLine("Silinecek kullanıcı adı:");
            string kullaniciAdi = Console.ReadLine();

            bool isDeleted = false;

            foreach (User item in users)
            {
                if (item.Username == kullaniciAdi)
                {
                    users.Remove(item);
                    isDeleted = true;
                    break;
                }
            }

            if (isDeleted)
            {
                Console.WriteLine("Silindi.");
            }
            else
            {
                Console.WriteLine("Silinecek kullanıcı bulunamadı.");
            }
        }
    }
}
