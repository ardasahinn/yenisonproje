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
    
    public partial class Alisveris_Table
    {
        public int A_Id { get; set; }
        public int A_K_Id { get; set; }
        public int A_Kas_Id { get; set; }
        public string A_U_Barkod { get; set; }
    
        public virtual Kart_Table Kart_Table { get; set; }
        public virtual Kasa_Bilgi_Table Kasa_Bilgi_Table { get; set; }
        public virtual Urun_Table Urun_Table { get; set; }
    }
}
