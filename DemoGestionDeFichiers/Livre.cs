using System.Text;
using System.Text.Json;

namespace DemoGestionDeFichiers
{
    public class Livre
    {
        public string Titre { get; set; }
        public string Auteur { get; set; }
        public int Annee { get; set; }

        public Livre(string titre, string auteur, int annee)
        {
            Titre = titre;
            Auteur = auteur;
            Annee = annee;
        }

        public override string ToString()
        {
            return $"{Titre} ({Annee}), {Auteur}";
        }
       
    }
}
