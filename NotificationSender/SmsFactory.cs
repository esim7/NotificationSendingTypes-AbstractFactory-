using System;
using System.Collections.Generic;
using System.Text;

namespace NotificationSender
{
    public class SmsFactory : IAbstractFactory
    {
        public INotification SendMessage()
        {
            return new SmsNotification();
        }
    }
}
