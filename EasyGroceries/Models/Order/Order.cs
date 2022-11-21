namespace EasyGroceries.Models;
public class Order {
    public Guid Id{get;}
    public Guid UserId{get;}
    public int OrderNumber {get;}

    public int Customer{get;}
    public List<OrderItem> OrderItems{get;}

    public decimal Total {get; set;}

    public Order(Guid id, Guid userId, int orderNumber, List<OrderItem> orderItems, int customer, decimal total)
    {
        Id = id;
        UserId = userId;
        OrderItems = orderItems;
        Customer = customer;
        Total = total;
        OrderNumber = orderNumber;
    }
}