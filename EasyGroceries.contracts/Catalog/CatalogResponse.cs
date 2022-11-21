namespace EasyGrocries.Contracts.Catalog;

public record CatalogResponse (
    string Name,
    string Description,
    int Qunatity,
    Guid Id,
    Decimal Price,
    string Type
);
