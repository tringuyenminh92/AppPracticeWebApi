//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AppPracticeService.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        public Order()
        {
            this.OrderDetails = new HashSet<OrderDetail>();
            this.OrderHistories = new HashSet<OrderHistory>();
        }
    
        public System.Guid OrderId { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<double> Total { get; set; }
        public Nullable<bool> Active { get; set; }
        public string DescriptionNote { get; set; }
        public string CustomerName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public Nullable<System.Guid> CityId { get; set; }
        public string CustomerAddress { get; set; }
        public Nullable<bool> PaidByCash { get; set; }
        public string ShippingName { get; set; }
        public string ShippingEmail { get; set; }
        public string ShippingPhone { get; set; }
        public string ShippingAddress { get; set; }
    
        public virtual City City { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual ICollection<OrderHistory> OrderHistories { get; set; }
    }
}
