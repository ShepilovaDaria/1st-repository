using System;
using System.Collections.Generic;
using System.Text;

namespace LAB3.Factorymethod
{
    public interface Notification
    {
        void send(string message);
    }
    //уведомление в сообщении (конкретный продукт)
    public class SMSnotification: Notification
    {
        public void send(string message)
        {
            Console.WriteLine("Sending  SMS : " + message);
        }
    }
    // уведомление на почте (конкретный продукт)

    public class Emailnotification : Notification
    {
        public void send(string message)
        {
            Console.WriteLine("Sending Email: " + message);
        }

    }
    public abstract class Notificationfactory // создатель/фабрика
    {
        public abstract Notification Createnotification();
        public void SendNotification(string message)
        {
            Notification notif = Createnotification();
            notif.send(message);
        }
    }

   //конкретная фабрика - смс уведомление
    public class SMSNotificationFactory :Notificationfactory
    {
        public override Notification Createnotification() => new SMSnotification();

    }
    //конкретная фабрика - уведомление на почтн
    public class EmailNotificationFactory : Notificationfactory
    {
        public override Notification Createnotification() => new Emailnotification();
    }


}
