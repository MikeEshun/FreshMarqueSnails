using System;

namespace FreshMarqueSnails.Models
{
    public class CustomerOrder
    {
        public int ID { get; set; }
        public DateTime OrderDate { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public DateTime DeliveryDate { get; set; }
        public int Quantity { get; set; }
        public decimal Cost { get; set; }
        public string DeliveryStatus { get; set; }
        public string Comments { get; set; }
    }
}