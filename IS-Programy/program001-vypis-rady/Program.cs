string again = "a";

// Řídící cyklus programu
// ToLower() převede vstup na malá písmena, takže program pokračuje při zadání "a" i "A"
// Jakýkoliv jiný vstup program ukončí

while(again, ToLower() == "a") {
    



    // Dotaz směrem k užiivateli na opakování
    Console.WriteLine();
    Console.Write("Pro opakování programu stikněte klávesu a. Následně potvrďte klávesou Enter");
    again = Console.ReadLine() ?? "";
}