string again = "a";

while (again.ToLower() == "a")
{
    Console.Clear();
    Console.WriteLine("********************************");
    Console.WriteLine("***** Vykreslení obdélníku *****");
    Console.WriteLine("********************************");
    Console.WriteLine("********* Martin Podaný **********");
    Console.WriteLine("********************************");
    Console.WriteLine();

    // 1. Bezpečné načtení šířky s kontrolou na kladnou hodnotu
    Console.Write("Zadejte šířku obrazce (celé kladné číslo): ");
    int width;
    while (!int.TryParse(Console.ReadLine(), out width) || width <= 0)
    {

        Console.Write("Nezadali jste celé kladné číslo. Zadejte šířku znovu: ");
    }

    // 2. Bezpečné načtení výšky s kontrolou na kladnou hodnotu
    Console.Write("Zadejte výšku obrazce (celé kladné číslo): ");
    int height;
    while (!int.TryParse(Console.ReadLine(), out height) || height <= 0)
    {
        Console.Write("Nezadali sjte celé kladné číslo. Zadejte výšku znovu: ");
    }

    Console.WriteLine();
    Console.WriteLine("********************************");
    Console.WriteLine($"Šířka: {width}; Výška: {height};");
    Console.WriteLine("********************************");
    Console.WriteLine();



    //Jádro vvykreslovacího algoritmu
    // Vnější cyklus, který bude hlídat počet řádků (shora dolů)
    for (int i = 1; i <= height; i++)
    {
        if (i % 2 == 0)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
        }
            


        // Vnitřní cyklus, který se postará aby se v každém řádku vykreslí zprávný počet hvězdiček (zleva doprava)
        for (int j = 1; j <= width; j++)
        {
            Console.Write("* ");
            System.Threading.Thread.Sleep(System.TimeSpan.FromMilliseconds(5)); // Zpoždění

        }

        Console.WriteLine();
    }
    Console.ResetColor();



    // 4. Dotaz na opakování
    Console.WriteLine();
    Console.Write("Pro opakování programu stiskněte 'a' a potvrďte Enterem: ");
    again = Console.ReadLine() ?? "";
    
}