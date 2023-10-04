
using System.Collections.Generic;

//Liste Std
List<string> etudiants = new List<string>() { "Brice", "Amine", "Oussama", "khalil", "Emna", "Mouadhafer", "Claudia" };
// Liste absents
List<string> etudiantsAbsent = new List<string>();
// bouclé sur les étudiants

Console.WriteLine(@"  __  __  _____ ___  _____                __                          
 |  \/  |/ ____|__ \|  __ \              /_/                          
 | \  / | (___    ) | |  | |  _ __  _ __ ___  ___  ___ _ __   ___ ___ 
 | |\/| |\___ \  / /| |  | | | '_ \| '__/ _ \/ __|/ _ \ '_ \ / __/ _ \
 | |  | |____) |/ /_| |__| | | |_) | | |  __/\__ \  __/ | | | (_|  __/
 |_|  |_|_____/|____|_____/  | .__/|_|  \___||___/\___|_| |_|\___\___|
                             | |                                      
                             |_|                                      

");
foreach (var i in etudiants)
{
    Console.WriteLine($"Est ce que {i} est présent(e) ? O/N");
    var rep = Console.ReadLine();
    //if std present == no => add to etudiantsAbsent

    // vérification de la saisie while si ni o ni n on repose la questions
    while (rep != "N" ^ rep != "n" ^ rep != "O" ^ rep != "o")
    {
        Console.WriteLine($"Est ce que {i} est présent(e) ? O/N");
        Console.WriteLine("Veuillez choisir O / N pour réponse");
        rep = Console.ReadLine();
    }
    if (rep == "N" ^ rep == "n")
    {
        etudiantsAbsent.Add(i);
    };
}

//afficher le résultat
Console.WriteLine(@"                                                                                                                                                                                     
                                                                                                                                                                                     
                                                                                                                                                                                     
                                                                                                                                                                                     
 _______  _______  _______  _______  _______  _______  _______  _______  _______  _______  _______  _______  _______  _______  
/______/\/______/\/______/\/______/\/______/\/______/\/______/\/______/\/______/\/______/\/______/\/______/\/______/\/______/\
\__::::\/\__::::\/\__::::\/\__::::\/\__::::\/\__::::\/\__::::\/\__::::\/\__::::\/\__::::\/\__::::\/\__::::\/\__::::\/\__::::\/ 
                                                                                                                                                                                     

");
//si il y'a 0 absents je change de message 
Console.WriteLine("Les étudiants absents sont :\n");
foreach (var x in etudiantsAbsent)
{
    Console.WriteLine($"- {x}");
}
