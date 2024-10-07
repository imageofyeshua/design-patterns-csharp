using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coupling
{
    public class Order
    {
        private readonly INotificationService notificationService;

        public Order(INotificationService notificationService)
        {
            this.notificationService = notificationService;
        }

        public void PlaceOrder()
        {
            // Place order logic...

            notificationService.SendNotification("Order placed successfully");
        }
    }
}