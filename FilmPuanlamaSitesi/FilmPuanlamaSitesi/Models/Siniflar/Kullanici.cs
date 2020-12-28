﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FilmPuanlamaSitesi.Models.Siniflar
{
    public class Kullanici
    {
        [Key]
        public int ID { get; set; }
        public string KullaniciAd { get; set; }
        public string Sifre { get; set; }
        public string Email { get; set; }
        public int Yetki { get; set; }
    }
}
