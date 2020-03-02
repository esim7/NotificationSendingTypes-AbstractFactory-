using System;
using System.Collections.Generic;
using System.Text;

namespace NotificationSender
{
    public class EmailFactory : IAbstractFactory
    {
        public INotification CreateMessage()
        {
            return new EmailNotification();
        }
    }
}
