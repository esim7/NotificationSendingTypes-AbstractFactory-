using System;
using System.Collections.Generic;
using System.Text;

namespace NotificationSender
{
    public class PushFactory : IAbstractFactory
    {
        public INotification CreateMessage()
        {
            return new PushNotification();
        }
    }
}
