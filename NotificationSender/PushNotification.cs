using System;
using System.Collections.Generic;
using System.Text;

namespace NotificationSender
{
    public class PushNotification : BaseNotification, INotification
    {
        public string CreateMessage()
        {
            this.NotificationText = "PushNotification";
            return $"Message was sent as {this.NotificationText} at {this.CreationDate}";
        }
    }
}
