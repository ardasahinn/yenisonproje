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
    
    public partial class Personel_Table
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Personel_Table()
        {
            this.Kasa_Table = new HashSet<Kasa_Table>();
        }
    
        public int P_Id { get; set; }
        public string P_Adı { get; set; }
        public string P_Soyadı { get; set; }
        public string P_Maas_Bilgi { get; set; }
        public string P_Telefon { get; set; }
        public string P_G_Mail { get; set; }
        public string P_Adres { get; set; }
        public string P_Egitim_Bilgi { get; set; }
        public System.DateTime P_Baslama_Tarihi { get; set; }
        public string P_Sifre { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Kasa_Table> Kasa_Table { get; set; }
    }
}
