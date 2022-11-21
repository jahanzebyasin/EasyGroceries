namespace EasyGrocries.Contracts.Order;

public record CreateOrderRequest (
    Guid Id,
    string Customer,
    int OrderNumber,
    List<OrderItem> OrderItems,
    decimal Total
);