using LAB3.Abstractfactory;
using LAB3.Builder;
using LAB3.Factorymethod;
using LAB3.Singleton;
namespace LAB3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Singleton");
            var settinngs1 = AppSettinngs.Instance; 
            var settinngs2 = AppSettinngs.Instance;
            Console.WriteLine("Один и тот же объект? " + object.ReferenceEquals(settinngs1, settinngs2));
            settinngs1.Print();


            Console.WriteLine("Factory Method");

            Notificationfactory fac1 = new EmailNotificationFactory();
            fac1.SendNotification("EMAIL фабрика ");
            Notificationfactory fac2 = new SMSNotificationFactory();
            fac2.SendNotification("SMS фабрика");

            Console.WriteLine("Abstract Factory");
            new Room(new ModernFactory()).Place();
            new Room(new GothicFactory()).Place();

            Console.WriteLine("Builder ");
            var gb = new StreamingComputerbuilder();
            new ComputerDirector(gb).Constructcomputer();

            Console.WriteLine("ПК для стриминга: " + gb.Getresult());

            var ob = new OfficeComputerbuilder();
            new ComputerDirector(ob).Constructcomputer();
            Console.WriteLine("Офисный ПК: " + ob.Getresult());
        }
    }
}
