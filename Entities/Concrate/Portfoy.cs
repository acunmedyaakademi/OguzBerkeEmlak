using Entites.Abstract;
using System;

namespace Emlak.Entities
{
    public class Portfoy : BaseEntity
    {
        public int PortfoyID { get; set; }
        public string PortfoyTipi { get; set; }
        public string PortfoyAdres { get; set; }
        public double MetrekareAlan { get; set; }
        public string PortfoyDurumu { get; set; }
        public decimal PortfoyTutar { get; set; }
        public string PortfoyAciklama { get; set; }
        public int? CalisanId { get; set; }
        public Calisan? Calisan { get; set; }
    }
}
