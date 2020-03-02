using System;
using System.Collections.Generic;
using System.Text;

namespace NotificationSender
{
    public class EmailFactory : IAbstractFactory
    {
        public INotification SendMessage()
        {
            return new EmailNotification();
        }
    }
}
