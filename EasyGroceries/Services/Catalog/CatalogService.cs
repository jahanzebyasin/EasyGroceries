namespace EasyGroceries.Services.Catalog;
using EasyGroceries.Models;
public class CatalogService : ICatalogService {

    public static readonly List<Catalog> Catalogs = new List<Catalog>();
    public List<Catalog> GetCatalog() {
        // List<Catalog> _catalogs = new List<Catalog>();
        // _catalogs.Add(new Catalog(Guid.NewGuid(), "Milk","The best of cows",500, 2.5m));
        // _catalogs.Add(new Catalog(Guid.NewGuid(), "Bread","Easy toast",500, 1.5m));
        // _catalogs.Add(new Catalog(Guid.NewGuid(), "Egg","Wild chicken",500, 0.20m));
        // _catalogs.Add(new Catalog(Guid.NewGuid(), "Chocolate","Milk Chocolate",500, 1.20m));
        // _catalogs.Add(new Catalog(Guid.NewGuid(), "Vegetable Oil","Pure and health",500, 1.75m));
        return Catalogs;
    }

    public Guid AddCatalog(Catalog _catalog) 
    {
        Catalogs.Add(_catalog);
        return _catalog.Id;
    }

    public Catalog GetOne(Guid id) {
        return Catalogs.Find(x => x.Id.Equals(id));
    }

    public CatalogService()
    {

    }
}