
var brojevi = new List<int>();
Console.WriteLine("Unesite cijele brojeve, svaki u novi red. Pritisnite Enter na praznom redu za završetak.");
int index = 1;
while (true)
{
    Console.Write($"Element {index}: ");
    string? unos = Console.ReadLine();
    if (string.IsNullOrEmpty(unos))
        break; // empty entry ends input

    if (!int.TryParse(unos, out int vrijednost))
    {
        Console.WriteLine("Pogrešan format, pokušajte ponovno.");
        continue;
    }

    brojevi.Add(vrijednost);
    index++;
}

if (brojevi.Count == 0)
{
    Console.WriteLine("Nijedan broj nije unesen.");
}
else
{
    Console.WriteLine("Unijeli ste sljedeće brojeve:");
    foreach (var b in brojevi)
        Console.Write($"{b} ");
    Console.WriteLine();

    int zbroj = 0;
    int najmanji = brojevi[0];
    int najveci = brojevi[0];
    foreach (var b in brojevi)
    {
        zbroj += b;
        if (b < najmanji) najmanji = b;
        if (b > najveci) najveci = b;
    }

    double prosjek = (double)zbroj / brojevi.Count;
    Console.WriteLine($"Zbroj je {zbroj:N0}, najmanji element je {najmanji}, najveći je {najveci} i prosjek je {prosjek:N2}");
}