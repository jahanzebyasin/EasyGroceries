namespace EasyGrocries.Contracts.Catalog;

public record CreateCatalogRequest (
    string Name,
    string Description,
    int Quantity,
    Guid Id,
    decimal Price,
    string Type
);
