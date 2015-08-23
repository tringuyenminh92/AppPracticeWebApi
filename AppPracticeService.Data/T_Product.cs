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
    
    using AppPracticeService.Pattern.Ef6;
    public partial class T_Product : Entity
    {
        public T_Product()
        {
            this.T_OrderDetail = new HashSet<T_OrderDetail>();
            this.T_Picture = new HashSet<T_Picture>();
        }
    
        public System.Guid ProductId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Nullable<double> Price { get; set; }
        public Nullable<double> NewPrice { get; set; }
        public Nullable<System.Guid> CategoryId { get; set; }
        public Nullable<System.Guid> SizeId { get; set; }
        public string Material { get; set; }
        public Nullable<System.Guid> ColorId { get; set; }
        public string Model { get; set; }
        public Nullable<int> SeasonMonth { get; set; }
        public Nullable<int> SeasonYear { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<bool> Active { get; set; }
        public Nullable<int> Quantity { get; set; }
    
        public virtual Category Category { get; set; }
        public virtual Color Color { get; set; }
        public virtual Size Size { get; set; }
        public virtual ICollection<T_OrderDetail> T_OrderDetail { get; set; }
        public virtual ICollection<T_Picture> T_Picture { get; set; }
    }
}
