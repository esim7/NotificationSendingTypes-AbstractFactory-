using System;

namespace NotificationSender
{
    class Program
    {
        static void Main(string[] args)
        {
            new Client().SendNotification(new EmailFactory());
        }
    }
}
