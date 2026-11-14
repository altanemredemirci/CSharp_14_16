namespace _17_OOP_5_Abstract_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*

             User    :Create,Update,Delete,List,Find
             Product :Create,Update,Delete,List,Find
             Category:Create,Update,Delete,List,Find
             Brand   :Create,Update,Delete,List,Find
             Cart    :Create,Update,Delete,List,Find
             Order   :Create,Update,Delete,List,Find

            */

            //Base basee = new Base(); //Nesne oluşturma özelliğini engelledik.

            User user = new User();

            User.Yaz();
            
        }
    }

    abstract class Base
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime DeletedDate { get; set; }

        public abstract void Create();
        public abstract void Update();
        public abstract void Delete();
        public abstract void List();
        public abstract void Find();

        public static void Yaz()
        {
            Console.WriteLine("Abstract olmayan metotlarda bulunabilir.");
        }

    }

    class User : Base
    {
        public override void Create()
        {
            throw new NotImplementedException();
        }

        public override void Delete()
        {
            throw new NotImplementedException();
        }

        public override void Find()
        {
            throw new NotImplementedException();
        }

        public override void List()
        {
            throw new NotImplementedException();
        }

        public override void Update()
        {
            throw new NotImplementedException();
        }
    }
}
