namespace _15_Class_8_This
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Customer> customers = new List<Customer>();

            Customer musteri = new Customer();
            musteri.Create(customers);
        }
    }

    class Customer
    {
        public int Id;
        public string Name;
        public string Surname;

        public Customer()
        {

        }
        public Customer(int Id, string Name, string Surname)
        {
            this.Id = Id;
            this.Name = Name;
            this.Surname = Surname;
        }

        public void Create(List<Customer> list)
        {
            Console.WriteLine("Id:");
            Id = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Ad:");
            Name = Console.ReadLine();

            Console.WriteLine("Soyad:");
            Surname = Console.ReadLine();

            list.Add(this); //this kelimesi metodu çağıran nesneyi temsil eder.
        }

        public void Ekle() 
        {
            try
            {
                Console.WriteLine("Id:");
                this.Id = Convert.ToInt32(Console.ReadLine());

            }
            catch (Exception)
            {
                Ekle(); //Recurisive Metot (Kendi kendini çağıran metot)
            }
        }
    }
}
