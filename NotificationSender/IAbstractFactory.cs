using System;
using System.Collections.Generic;
using System.Text;

namespace NotificationSender
{
    public interface IAbstractFactory
    {
        INotification SendMessage();
    }
}
