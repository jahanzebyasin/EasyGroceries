namespace EasyGroceries.Services.Order;

using EasyGroceries.Models;

public interface IOrderService {
    List<Order> GetOrders();
    Guid AddOrder(Order _order);
    Order GetOne(Guid _id);

    Order ProcessOrder(Order _order);
}