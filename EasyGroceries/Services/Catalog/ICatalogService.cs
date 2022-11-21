namespace EasyGroceries.Services.Catalog;

using EasyGroceries.Models;

public interface ICatalogService {
    List<Catalog> GetCatalog();
    Guid AddCatalog(Catalog _catalog);
    Catalog GetOne(Guid _id);

}