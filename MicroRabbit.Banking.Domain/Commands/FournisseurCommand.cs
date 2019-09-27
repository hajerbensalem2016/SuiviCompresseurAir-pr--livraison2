using MicroRabbit.Domain.Core.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.GestionFournisseur.Domain.Commands
{
    public abstract class FournisseurCommand : Command
    {
        public int FournisseurID { get; protected set; }
        public string Nom { get; protected set; }
        public string Adresse { get; protected set; }
        public string Email { get; protected set; }
    }
}
