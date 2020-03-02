using System;
using System.Collections.Generic;
using System.Text;

namespace NotificationSender
{
    public class SmsNotification : BaseNotification, INotification 
    {
        public string CreateMessage()
        {
            this.NotificationText = "SmsNotification";
            return $"Message was sent as {this.NotificationText} at {this.CreationDate}";
        }
    }
}
