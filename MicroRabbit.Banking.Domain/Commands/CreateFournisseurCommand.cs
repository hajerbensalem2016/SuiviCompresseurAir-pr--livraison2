using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.GestionFournisseur.Domain.Commands
{
    public class CreateFournisseurCommand : FournisseurCommand
    {
        public CreateFournisseurCommand(int fournisseurID, string nom, string adresse, string email)
        {
            FournisseurID = fournisseurID;
            Nom = nom;
            Adresse = adresse;
            Email = email;
        }
    }
}
