//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KutuphaneBS.Models.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class CEZA_UYE
    {
        public int Ceza_ID { get; set; }
        public int Uye_ID { get; set; }
        public string Odeme_Durumu { get; set; }
    
        public virtual CEZA CEZA { get; set; }
        public virtual UYE UYE { get; set; }
    }
}
