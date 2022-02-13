using System;

namespace Entities.Model.NHibarnateModel
{
    public class Order
    {
        public virtual int OrderId { get; set; }
        public virtual string CustomerId { get; set; }
        public virtual int EmployeeId { get; set; }
        public virtual DateTime OrderDate { get; set; }
        public virtual string ShipCity { get; set; }
    }
}
