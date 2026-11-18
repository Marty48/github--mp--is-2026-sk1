string again = "a";

while (again.ToLower() == "a")
{
    Console.Clear();
    Console.WriteLine("**************************************");
    Console.WriteLine("*** Generátor pseudonáhodných čísel ***");
    Console.WriteLine("**************************************");
    Console.WriteLine("*********** Martin Podaný ************");
    Console.WriteLine("**************************************");
    Console.WriteLine();

    // Počet načtených čísel (větší jak 0)
    Console.Write("Zadejte počeet generovaných čísel (přirozenné číslo): ");
    int n;
    while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
    {
        Console.Write("Nezadali jste přirozenné číslo. Zadejte počet čísel znovu: ");
    }

    // Načtení dolní meze
    Console.Write("Zadejte dolní mez (celé číslo): ");
    int lowerBound;
    while (!int.TryParse(Console.ReadLine(), lowerBound ))
    {
        Console.Write("Nezadali sjte celé číslo. Zadejte dolní mez znovu: ");
    }

    // Načtení horní meze
    Console.Write("Zadejte horní mez (celé číslo větší nebo rovno hodnotě dolní meze): ");
    int upperBound;
    while (!int.TryParse(Console.ReadLine(), upperBound) || upperBound < lowerBound )
    {
        Console.Write("Nezadali sjte celé číslo. Zadejte horní mez znovu: ");
    }


    Console.WriteLine();
    Console.WriteLine("********************************");
    Console.WriteLine($"Počet čísel : {n}; Dolní mez: {lowerBound}; Horní mez : {upperBound}; ");
    Console.WriteLine("********************************");
    Console.WriteLine();


    // 4. Dotaz na opakování
    Console.WriteLine();
    Console.Write("Pro opakování programu stiskněte 'a' a potvrďte Enterem: ");
    again = Console.ReadLine() ?? "";
    
}