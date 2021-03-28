using System;
using Core.Entities;


namespace Entities.Concrete
{
    public class Rental:IEntity
    {
        public int RentalId { get; set; }
        public int CarId { get; set; }
        public int UserId { get; set; }
        public DateTime RentalDate { get; set; }
        public int DayCount { get; set; }
        public DateTime DeliveryDate => RentalDate.AddDays(DayCount);
        public decimal Price { get; set; }
    }
}
