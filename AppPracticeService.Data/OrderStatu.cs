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
    
    public partial class OrderStatu
    {
        public OrderStatu()
        {
            this.OrderHistories = new HashSet<OrderHistory>();
        }
    
        public System.Guid OrderStatusId { get; set; }
        public string Code { get; set; }
        public string StatusName { get; set; }
        public string Icon { get; set; }
        public string Style { get; set; }
        public Nullable<bool> Active { get; set; }
    
        public virtual ICollection<OrderHistory> OrderHistories { get; set; }
    }
}
