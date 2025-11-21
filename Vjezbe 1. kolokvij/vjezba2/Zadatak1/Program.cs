// Ovdje pisati kod za zadatak 1
(int produkt, double potencija) Izracun(int broj1,  int broj2)
{
    if (broj1 < 0 || broj2 < 0)
        throw new ArgumentException("Brojevi ne smiju biti negativni");
    int produkt = broj1 * broj2;
    double potencija = Math.Pow(broj1, broj2);
    return (produkt, potencija);
}

bool nastavi = true;
do
{
    Console.Write("Broj 1: ");
    string unos = Console.ReadLine();
    if(string.IsNullOrEmpty(unos))
        nastavi = false;
    else
    {
        bool ok = int.TryParse(unos, out int broj1);
        if(!ok)
        {
            Console.WriteLine("Pogrešan format");
            continue;
        }
        Console.Write("Broj 2: ");
        unos = Console.ReadLine();
        ok = int.TryParse(unos, out int broj2);
        if (!ok)
        {
            Console.WriteLine("Pogrešan format");
            continue;
        }
        try
        {
            (int produkt, double potencija) rezultat = Izracun(broj1, broj2);
            Console.WriteLine($"Produkt je {rezultat.produkt} a potencija je {rezultat.potencija:N0}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Dogodila se pogreška. Tekst: {ex.Message}");
        }
    }
}
while (nastavi);

