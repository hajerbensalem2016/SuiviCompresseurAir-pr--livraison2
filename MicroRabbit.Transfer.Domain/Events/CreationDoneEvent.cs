using MicroRabbit.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.GestionCompresseur.Domain.Events
{
    public class CreationDoneEvent : Event
    {
        public int FournisseurID { get; private set; }
        public string Nom { get; private set; }
        public string Adresse { get; private set; }
        public string Email { get; private set; }

        public CreationDoneEvent(int fournisseurID, string nom, string adresse, string email)
        {
            FournisseurID = fournisseurID;
            Nom = nom;
            Adresse = adresse;
            Email = email;
        }
    }
}
