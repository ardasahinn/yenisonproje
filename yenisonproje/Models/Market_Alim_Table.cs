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
    
    public partial class Market_Alim_Table
    {
        public int Mat_Id { get; set; }
        public System.DateTime Mat_Tarih { get; set; }
        public int Mat_Miktar { get; set; }
        public int Mat_Ucret { get; set; }
        public string Mat_U_Barkod { get; set; }
    
        public virtual Urun_Table Urun_Table { get; set; }
    }
}
