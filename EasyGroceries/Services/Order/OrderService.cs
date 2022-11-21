namespace EasyGroceries.Services.Order;
using EasyGroceries.Models;
public class OrderService : IOrderService {
    
    public static readonly List<Order> Orders = new List<Order>();
    public List<Order> GetOrders() {
        return Orders;
    }

    public Guid AddOrder(Order _order) 
    {
        Orders.Add(_order);
        return _order.Id;
    }

    public Order GetOne(Guid id) {
        return Orders.Find(x => x.Id.Equals(id));
    }

    public Order ProcessOrder(Order _order)
    {
        //Process order by applying discount
        decimal totalAmout = 0;
        foreach(OrderItem oi in _order.OrderItems) {
            if(oi.Item.Type.Equals("NonTangable")) {
                totalAmout += Decimal.Multiply(Decimal.Multiply(oi.Item.Price, oi.Quantity),0.20m); 
            } else {
                totalAmout += Decimal.Multiply(oi.Item.Price, oi.Quantity);
            }
        }
        _order.Total = Math.Round(totalAmout,2);
        return _order;
    }

    public OrderService() {
        // List<OrderItem> items = new List<OrderItem>();
        // items.Add(new OrderItem(
        //     Guid.NewGuid(),
        //     new Catalog(Guid.NewGuid(),"Milk","Best of Cows",10,2.50m,"Tangable"),
        //     2
        // ));
        // items.Add(new OrderItem(
        //     Guid.NewGuid(),
        //     new Catalog(Guid.NewGuid(),"Bread","Easy Toast",10,1.50m,"Tangable"),
        //     1
        // ));
        // Orders.Add(
        //     new Order(Guid.NewGuid(),Guid.NewGuid(),854124,items,35496,10)
        // );
    }
}