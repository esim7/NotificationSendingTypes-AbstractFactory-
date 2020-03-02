using System;
using System.Collections.Generic;
using System.Text;

namespace NotificationSender
{
    public class Client
    {
        public void SendNotification(IAbstractFactory factory)
        {
            var result = factory.SendMessage();
            result.CreateMessage();
            Console.WriteLine(result.CreateMessage());
        }
    }
}
