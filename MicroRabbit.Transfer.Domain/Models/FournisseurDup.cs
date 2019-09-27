using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MicroRabbit.GestionCompresseur.Domain.Models
{
    public class FournisseurDup
    {
        [Key]
        public int FournisseurID { get; set; }
        [Required]
        public string Nom { get; set; }
        public string Adresse { get; set; }
        [DataType(DataType.EmailAddress, ErrorMessage = "E-mail is not valid")]
        public string Email { get; set; }
        public virtual ICollection<FicheCompresseur> FicheCompresseurs { get; set; }
    }
}
