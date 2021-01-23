using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace pin_projekt.Models
{
    public class Tablica_igraca
    {
        [Key]
        public int ID { get; set; }

        [DisplayName("Ime*")]
        [Required(ErrorMessage = "Ovo polje je obavezno")]
        public string ime { get; set; }

        [DisplayName("Prezime*")]
        [Required(ErrorMessage = "Ovo polje je obavezno")]
        public string prezime { get; set; }

        [DisplayName("Pozicija*")]
        [Required(ErrorMessage = "Ovo polje je obavezno")]
        public string pozicija { get; set; }

        [DisplayName("Klub*")]
        [Required(ErrorMessage = "Ovo polje je obavezno")]
        public string klub { get; set; }
        
    }
}
