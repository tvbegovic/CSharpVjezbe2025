bool nastavi = true;

do
{
    Console.Write("Unesite broj elemenata polja (1-100): ");
    string unos = Console.ReadLine();
    if (string.IsNullOrEmpty(unos))
    {
        break;
    }
    bool ok = int.TryParse(unos, out int brojElemenata);
    if(!ok)
    {
        Console.WriteLine("Pogrešan format");
        continue;
    }
    if(brojElemenata > 100 || brojElemenata < 1)
    {
        Console.WriteLine("Broj je izvan raspona");
        continue;
    }
    int[] brojevi = new int[brojElemenata];
    int i = 0;
    while (i< brojElemenata)
    {
        Console.Write($"Element {i + 1}: ");
        unos = Console.ReadLine();
        ok = int.TryParse(unos, out brojevi[i]);
        if(!ok)
        {
            Console.WriteLine("Pogrešan format");
            continue;
        }
        i++;
    }
    //Sortiraj polje upotrebom Array.Sort
    Array.Sort(brojevi);
    //Ispiši elemente polja
    Console.WriteLine("Unijeli ste sljedeće polje");
    foreach (var broj in brojevi)
    {
        Console.Write($"{broj} ");
    }
    Console.WriteLine();
    int zbroj = 0;
    int najmanji = brojevi[0];
    int najveci = brojevi[0];
    foreach (var broj in brojevi)
    {
        zbroj += broj;
        if (broj < najmanji)
            najmanji = broj;
        if (broj > najveci)
            najveci = broj;
    }
    double prosjek = zbroj * 1.0 / brojElemenata;
    Console.WriteLine($"Zbroj je {zbroj:N0}, najmanji element je {najmanji}, najveći je {najveci} i prosjek je {prosjek:N2}");

}
while (nastavi);
