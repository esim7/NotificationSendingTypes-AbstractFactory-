using System;
using System.Collections.Generic;
using System.Text;

namespace NotificationSender
{
    public abstract class BaseNotification
    {
        public string NotificationText;
        public DateTime CreationDate = DateTime.Now;
    }
}
