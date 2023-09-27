using System;
using Entites.Abstract;
using Entities.Concrate;

namespace Emlak.Entities
{
    public class Calisan : BaseEntity
    {
       
        public string? IsimSoyisim { get; set; }
        public string? KullaniciAdi { get; set; }
        public string? KullaniciSifre { get; set; }
        public string? GSM { get; set; }
        public string? GSM2 { get; set; }
        public string? Mail { get; set; }
        public string? Mail2 { get; set; }
        public int? PortfoySayisi { get; set; }
        public int? RoleId { get; set; }
        public Role  Role { get; set; }

    }
}
