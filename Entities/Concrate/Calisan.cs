﻿using System;
using Entites.Abstract;

namespace Emlak.Entities
{
    public class Calisan : BaseEntity
    {
        public int CalisanID { get; set; }
        public string CalisanIsimSoyisim { get; set; }
        public string CalisanKullaniciAdi { get; set; }
        public string CalisanKullaniciSifre { get; set; }
        public string CalisanGSM { get; set; }
        public string CalisanGSM2 { get; set; }
        public string CalisanMail { get; set; }
        public string CalisanMail2 { get; set; }
        public int CalisanPortfoySayisi { get; set; }
        public int CalisanDurum { get; set; }
        
    }
}
