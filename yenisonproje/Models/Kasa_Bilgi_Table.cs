//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace yenisonproje.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Kasa_Bilgi_Table
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Kasa_Bilgi_Table()
        {
            this.Alisveris_Table = new HashSet<Alisveris_Table>();
            this.Kasa_Table = new HashSet<Kasa_Table>();
        }
    
        public int KB_Kasa_Id { get; set; }
        public Nullable<int> KB_Kasa_Durum { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Alisveris_Table> Alisveris_Table { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Kasa_Table> Kasa_Table { get; set; }
    }
}
