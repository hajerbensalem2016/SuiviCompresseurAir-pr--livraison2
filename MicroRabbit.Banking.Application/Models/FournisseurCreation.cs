using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.GestionFournisseur.Application.Models
{
    public class FournisseurCreation
    {
      
        public int FournisseurID { get; set; }
        public string Nom { get; set; }
        public string Adresse { get; set; }
        public string Email { get; set; }
    }

}
