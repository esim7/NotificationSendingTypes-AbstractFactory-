using System;
using System.Collections.Generic;
using System.Text;

namespace NotificationSender
{
    public class Client
    {
        public void SendNotification(IAbstractFactory factory)
        {
            var result = factory.CreateMessage();
            Console.WriteLine(result.SendMessage());
        }
    }
}
