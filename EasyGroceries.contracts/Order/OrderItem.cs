namespace EasyGrocries.Contracts.Order;

public record OrderItem(
    Guid Id,
    Catalog Item,
    int Quantity
);
