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



   
    // Načtení prvního čísla řady
    Console.Write("Zadejte první číslo řady (celé číslo): ");
    int first;
    while (!int.TryParse(Console.ReadLine(), out first)) 
    {
        Console.Write("Nezadali jste celé číslo. Zadejte první číslo řady znovu: ");
    }




    // Načtení koncového čísla řady
    Console.Write("Zadejte poslední číslo řady (celé číslo): ");
    int last;
    while (!int.TryParse(Console.ReadLine(), out last)) 
    {
        Console.Write("Nezadali jste celé číslo. Zadejte poslední číslo řady znovu: ");
    }


    // Načtení diference s kontorlou kladného čísla
    Console.Write("Zadejte diferenci (kladné celé číslo): ");
    int step;
    while (!int.TryParse(Console.ReadLine(), out step) || step <=0 ) 
    {
        Console.Write("Nezadali jste kladné celé číslo. Zadejte diferenci znovu: ");
    }



    // Dotaz směrem k užiivateli na opakování
    Console.WriteLine();
    Console.Write("Pro opakování programu stikněte klávesu a. Následně potvrďte klávesou Enter");
    again = Console.ReadLine() ?? "";
}