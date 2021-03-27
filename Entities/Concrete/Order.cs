using System;
using Core.Entities;


namespace Entities.Concrete
{
    public class Order:IEntity
    {
        public int OrderId { get; set; }
        public int CarId { get; set; }
        public int UserId { get; set; }
        public DateTime OrderDate { get; set; }
        public int DayCount { get; set; }
        public DateTime DeliveryDate => OrderDate.AddDays(DayCount);
        public decimal Price { get; set; }
    }
}
