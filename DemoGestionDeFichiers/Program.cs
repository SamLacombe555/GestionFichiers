
using DemoGestionDeFichiers;
using System.Text.Json;

// Pour l'avoir dans votre projet 
string basePath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
string fichier = Path.Combine(basePath, "Data", "livres.json");

string? dossier = Path.GetDirectoryName(fichier);


//"Clean Architecture", "Robert C. Martin", 2017
//"The Pragmatic Programmer", "David Thomas et Andrew Hunt", 2019
//"Fundamentals of Software Architecture", "Mark Richards et Neal Ford", 2020