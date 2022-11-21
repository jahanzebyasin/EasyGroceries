namespace EasyGrocries.Contracts.Order;

public record OrderResponse (
    Guid Id,
    int Customer,
    int OrderNumber,
    List<OrderItem> OrderItems,
    decimal Total
);
