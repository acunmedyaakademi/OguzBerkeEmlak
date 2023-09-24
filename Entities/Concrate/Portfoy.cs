using System;

namespace Emlak.Entities
{
    public class Portfoy
    {
        public int PortfoyID { get; set; }
        public string PortfoyTipi { get; set; }
        public string PortfoyAdres { get; set; }
        public int PortfoySahibiID { get; set; }
        public int PortfoySahibi2ID { get; set; }
        public string PortfoySahibi { get; set; }
        public double MetrekareAlan { get; set; }
        public string PortfoyDurumu { get; set; }
        public decimal PortfoyTutar { get; set; }
        public string PortfoyAciklama { get; set; }
    }
}
