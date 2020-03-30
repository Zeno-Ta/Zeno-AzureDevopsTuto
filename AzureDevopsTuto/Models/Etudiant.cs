using System;
namespace AzureDevopsTuto.Models
{
    public class Etudiant : IEtudiant
    {
        public int ID { get; set; }

        public string Nom { get; set; }

        public string Matricule { get; set; }
    }
}
