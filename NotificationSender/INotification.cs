using System;
using System.Collections.Generic;
using System.Text;

namespace NotificationSender
{
    public interface INotification
    {
        string CreateMessage();
    }
}
