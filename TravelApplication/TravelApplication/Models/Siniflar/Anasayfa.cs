﻿using System.ComponentModel.DataAnnotations;

namespace TravelApplication.Models.Siniflar
{
    public class Anasayfa
    {
        [Key]
        public int ID { get; set; }
        public string Baslik { get; set; }

        public string Aciklama { get; set; }
    }
}
