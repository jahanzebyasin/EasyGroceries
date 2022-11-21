namespace EasyGrocries.Contracts.Order;
public record Catalog (
    string Name,
    string Description,
    int Qunatity,
    Guid Id,
    Decimal Price,
    string Type
);
