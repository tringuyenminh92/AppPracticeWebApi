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
    public partial class Category : Entity
    {
        public Category()
        {
            this.T_Product = new HashSet<T_Product>();
        }
    
        public System.Guid CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string CategoryImageString { get; set; }
        public byte[] CategoryImageBytes { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public Nullable<bool> Active { get; set; }
    
        public virtual ICollection<T_Product> T_Product { get; set; }
    }
}