using System;
using System.Collections.Generic;

namespace AzureDevopsTuto.Models.BD
{
    public class DBContext
    {
        public List<IEtudiant> Etudiants { get; set; }

        public DBContext()
        {
            Etudiants = new List<IEtudiant>
            {
                new Etudiant
                {
                     ID=01,
                     Nom="toto LeToto",
                     Matricule="0001"
                },
                new Etudiant
                {
                     ID=02,
                     Nom="tata LaTata",
                     Matricule="0002"
                },
                new Etudiant
                {
                     ID=04,
                     Nom="tonton LeTonton",
                     Matricule="0003"
                },
            };
        }
    }
}
