//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StokTakip.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class UrunTakip
    {
        public int Id { get; set; }
        public string Tur { get; set; }
        public Nullable<System.DateTime> Tarih { get; set; }
        public Nullable<int> BarcodId { get; set; }
        public Nullable<int> AlternatifUrunId { get; set; }
        public Nullable<double> Adet { get; set; }
        public Nullable<double> ToplamAdet { get; set; }
        public Nullable<decimal> Maliyet { get; set; }
        public Nullable<System.DateTime> SonKullanımTarihi { get; set; }
    }
}