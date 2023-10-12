
// Liste des étudiants
List<string> listeEtudiants = new List<string>() { "Brice", "Amine", "Oussama", "Khalil", "Emna", "Mouadhafer", "Claudia" };

// Liste des étudiants absents
List<string> listeEtudiantsAbsents = new List<string>();

Console.WriteLine(@"
  _____       __                           _____ _               _      __  __  _____ ___  _____  
 |  __ \     /_/                          / ____| |             | |    |  \/  |/ ____|__ \|  __ \ 
 | |__) | __ ___  ___  ___ _ __   ___ ___| |    | |__   ___  ___| | __ | \  / | (___    ) | |  | |
 |  ___/ '__/ _ \/ __|/ _ \ '_ \ / __/ _ \ |    | '_ \ / _ \/ __| |/ / | |\/| |\___ \  / /| |  | |
 | |   | | |  __/\__ \  __/ | | | (_|  __/ |____| | | |  __/ (__|   <  | |  | |____) |/ /_| |__| |
 |_|   |_|  \___||___/\___|_| |_|\___\___|\_____|_| |_|\___|\___|_|\_\ |_|  |_|_____/|____|_____/ 
                                                                                                  
");


// Vérification de la présence des étudiants
foreach (var etudiant in listeEtudiants)
{
    Console.WriteLine($"Est-ce que {etudiant} est présent(e) ? O/N");
    var reponse = Console.ReadLine().ToLower();
    Console.Clear();
    // en cas d'erreur de saisie on demande a l'utilisateur de choisir O ou N
    while (reponse != "n" && reponse != "o")
    {
        Console.WriteLine("La réponse est incorrecte, veuillez choisir O ou N comme réponse.");
        Console.WriteLine($"Est-ce que {etudiant} est présent(e) ? O/N");
        reponse = Console.ReadLine().ToLower();
        Console.Clear();
    }
    // si l'utilisateur saisie n on rajoute l'étudiant concerné a listeEtudiantsAbsents
    if (reponse == "n")
    {
        listeEtudiantsAbsents.Add(etudiant);
    }
}

Console.WriteLine(@"                                                                                                                                                                                                                                                                              
 _______  _______  _______  _______  
/\______\/\______\/\______\/\______\
\/______/\/______/\/______/\/______/                                                                                                                                                  
");
// Affichage des étudiants absents
Console.WriteLine("Les étudiants absents sont :\n");

foreach (var etudiantAbsent in listeEtudiantsAbsents)
{
    Console.WriteLine($"\t- {etudiantAbsent}");
}

Console.WriteLine(@"                                                                                                                                                                                                                                                                              
 _______  _______  _______  _______  
/\______\/\______\/\______\/\______\
\/______/\/______/\/______/\/______/                                                                                                                                                      
");

Console.ReadLine();
