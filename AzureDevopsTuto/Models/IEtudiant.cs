namespace AzureDevopsTuto.Models
{
    public interface IEtudiant
    {
         int ID { get; set; }

         string Nom { get; set; }

         string Matricule { get; set; }
    }
}