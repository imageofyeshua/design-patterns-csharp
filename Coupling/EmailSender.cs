using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coupling
{
    public class EmailSender : INotificationService
    {
        public void SendNotification(string message)
        {
            Console.WriteLine("Sending Email: " + message);
        }
    }
}