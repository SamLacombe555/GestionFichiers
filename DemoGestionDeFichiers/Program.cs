
using DemoGestionDeFichiers;
using System.Text.Json;

// Pour l'avoir dans votre projet 
string basePath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
string fichier = Path.Combine(basePath, "Data", "livres.json");

string? dossier = Path.GetDirectoryName(fichier);

if (dossier is not null && Directory.Exists(dossier))
{
    Directory.CreateDirectory(dossier);
}

static void CreerLivreJson(string fichier)
{
    //List<Livre> livres = new List<Livre>();

    //livres.Add(new Livre("Clean ARchitecture", "Robert C. Martin", 2017));

    List<Livre> livres = new List<Livre>
    {
        new Livre("Clean ARchitecture", "Robert C. Martin", 2017),
        new Livre("The Pragmatic Programmer", "David Thomas et Andrew Hunt", 2019),
        new Livre("Fundamentals of Software Architecture", "Mark Richards et Neal Ford", 2020)
    };

    JsonSerializerOptions options = new JsonSerializerOptions { WriteIndented = true };
    string livresJson = JsonSerializer.Serialize(livres);
    File.WriteAllText(fichier, livresJson);


}

static void LireLivresJson(string fichier)
{
    string livreJson = File.ReadAllText(fichier);
    List<Livre>? livres = JsonSerializer.Deserialize<List<Livre>>(livreJson);



}

//"Clean Architecture", "Robert C. Martin", 2017
//"The Pragmatic Programmer", "David Thomas et Andrew Hunt", 2019
//"Fundamentals of Software Architecture", "Mark Richards et Neal Ford", 2020


