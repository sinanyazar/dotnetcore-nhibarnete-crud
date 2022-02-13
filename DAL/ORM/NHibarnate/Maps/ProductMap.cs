using Entities.Model.NHibarnateModel;
using FluentNHibernate.Mapping;

namespace DAL.ORM.NHibarnate.Maps
{
    public class ProductMap : ClassMap<Product>
    {
        public ProductMap()
        {
            Id(x => x.ProductId);
            Map(x => x.CategoryId);
            Map(x => x.ProductName);
            Map(x => x.UnitPrice);
            Map(x => x.UnitsInStock);
            Table("Products");
        }
    }
}