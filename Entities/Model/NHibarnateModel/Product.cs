namespace Entities.Model.NHibarnateModel
{
    public class Product
    {
        public virtual int ProductId { get; set; }
        public virtual int CategoryId { get; set; }
        public virtual string ProductName { get; set; }
        public virtual short UnitsInStock { get; set; }
        public virtual decimal UnitPrice { get; set; }
    }
}
