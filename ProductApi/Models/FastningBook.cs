﻿using System.ComponentModel.DataAnnotations.Schema;

namespace ProductApi.Models
{
    public class FastningBook
    {
        public int ID { get; set; }
        public int? Indskrivningsnr { get; set; }
        public string? FaesterNavn { get; set; }
        public string? Fornavn { get; set; }
        public string? Efternavn { get; set; }
        public string? FaesterTilNavn {  get; set; }
        public string? ForrigeFaesterNavn { get; set; }
        public string? ForrigeFaesterForNavn { get; set; }
        public string? ForrigeFaesterEfterNavn { get; set; }
        public string? ForrigeFaesterTilNavnmm {  get; set; }
        public string? Kommentarer {  get; set; }
        public string? Gaard {  get; set; }
        public string? Sogn { get; set; }
        public string? FaestebrevUdstedt { get; set; }
        public string? Side {  get; set; }
        [NotMapped]
        public Object? book {  get; set; }
        public string? Film { get; set; }
        public string? Herred { get; set; }


    }
}
