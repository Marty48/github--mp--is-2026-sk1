string again = "a";

// Řídící cyklus programu
// ToLower() převede vstup na malá písmena, takže program pokračuje při zadání "a" i "A"
// Jakýkoliv jiný vstup program ukončí

while(again.ToLower() == "a" )
{
    // Vymazání konzole
    Console.Clear();


    // Hlavička programu
    Console.WriteLine("*************************");
    Console.WriteLine("*******Výpis řady********");
    Console.WriteLine("*************************");
    Console.WriteLine("*******Výpis řady********");
    Console.WriteLine("*************************");
    Console.WriteLine("*******Výpis řady********");
    Console.WriteLine("*************************");

    //


    // Dotaz směrem k užiivateli na opakování
    Console.WriteLine();
    Console.Write("Pro opakování programu stikněte klávesu a. Následně potvrďte klávesou Enter");
    again = Console.ReadLine() ?? "";
}