using System;
using System.Collections.Generic;
using System.Text;

namespace NotificationSender
{
    public class EmailNotification : BaseNotification, INotification
    {
        public string SendMessage()
        {
            this.NotificationText = "EmailNotification";
            return $"Message was sent as {this.NotificationText} at {this.CreationDate}"; 
        }
    }
}
