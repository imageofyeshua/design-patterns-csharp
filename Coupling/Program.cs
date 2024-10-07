using Coupling;

var order = new Order(new EmailSender());
var order2 = new Order(new SmsSender());
order.PlaceOrder();
order2.PlaceOrder();