//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RodinaTurkey.Models.Entitiy
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tbl_RentCategory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tbl_RentCategory()
        {
            this.Tbl_Rentcar = new HashSet<Tbl_Rentcar>();
        }
    
        public byte ID { get; set; }
        public string RentCategory { get; set; }
        public Nullable<bool> Status { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_Rentcar> Tbl_Rentcar { get; set; }
    }
}
