namespace Entities.Model.NHibarnateModel
{
    public class Customer
    {
        public virtual string CustomerId { get; set; }
        public virtual string ContactName { get; set; }
        public virtual string CompanyName { get; set; }
        public virtual string City { get; set; }
    }
}
