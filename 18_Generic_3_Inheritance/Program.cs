namespace _18_Generic_3_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            new BaseClass<double>().GenericProperty = 10.00;
            new BaseClass<string>().GenericProperty = "Hello";
            new ChildClass().GenericProperty = 10;
            new ChildClass2<bool>().GenericProperty = true;
            new ChildClass2<DateTime>().GenericProperty = DateTime.Now;
            new ChildClass3<float>().GenericProperty = 10.5;
            new ChildClass3<char>().GenericProperty = 10;

        }
    }

    class BaseClass<T>
    {
        public T GenericProperty { get; set; }
    }

    //Kalıtım alınan temel sınıfa T tipi gönderilmelidir.
    class ChildClass : BaseClass<int>
    {
        //BaseClass'taki GenericProperty int veri tipinde oldu.
    }

    class ChildClass2<T> : BaseClass<T>
    {
        //Nesne üretilirken T yerine int gönderilmişse BaseClass'taki GenericProperty int tipinde çalışır.
    }

    class ChildClass3<T> : BaseClass<double>
    {

    }
}
