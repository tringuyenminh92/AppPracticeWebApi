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
    public partial class T_Picture : Entity
    {
        public System.Guid PictureId { get; set; }
        public Nullable<System.Guid> ProductId { get; set; }
        public string ProductColor { get; set; }
        public string ContentString { get; set; }
        public byte[] ContentBytes { get; set; }
        public Nullable<bool> Active { get; set; }
        public Nullable<bool> IsProfile { get; set; }
        public Nullable<int> DisplayOrder { get; set; }
    
        public virtual T_Product T_Product { get; set; }
    }
}