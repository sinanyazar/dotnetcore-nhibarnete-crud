using Entities.Model.NHibarnateModel;
using FluentNHibernate.Mapping;

namespace DAL.ORM.NHibarnate.Maps
{
    public class CategoryMap : ClassMap<Category>
    {
        public CategoryMap()
        {
            Id(x => x.CategoryId);
            Map(x => x.CategoryName);
            Table("Categories");
        }
    }
}