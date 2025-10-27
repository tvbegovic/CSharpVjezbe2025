void IzracunParametara(double iznos, double stopa,int brojGodina, out double anuitet, out double iznosKamata)
{
    if (iznos < 0 || stopa < 0 || brojGodina < 0)
        throw new ArgumentException("Parametri moraju biti pozitivni brojevi");
    double r = Kamatnjak(stopa);
    int n = brojGodina * 12;
    anuitet = iznos * Math.Pow(r,n) * (r - 1) / (Math.Pow(r,n) - 1);
    iznosKamata = anuitet * n - iznos;
}

double Kamatnjak(double stopa)
{
    return 1 + stopa / 100 / 12;
}

bool nastavi = true;
do
{
    Console.Write("Iznos: ");
    string unos = Console.ReadLine();
    if(string.IsNullOrEmpty(unos))
        nastavi = false;
    else
    {
        bool ok = double.TryParse(unos, out double iznos);
        if(!ok)
        {
            Console.WriteLine("Pogrešan format");
            continue;
        }
        Console.Write("Stopa (%): ");
        unos = Console.ReadLine();
        ok = double.TryParse(unos, out double stopa);
        if (!ok)
        {
            Console.WriteLine("Pogrešan format");
            continue;
        }
        Console.Write("Broj godina: ");
        unos = Console.ReadLine();
        ok = int.TryParse(unos, out int brojGodina);
        if (!ok)
        {
            Console.WriteLine("Pogrešan format");
            continue;
        }
        IzracunParametara(iznos,stopa,brojGodina, out double anuitet, out double iznosKamata);
        Console.WriteLine($"Za iznos {iznos:N2}, stopu {stopa} % i broj godina {brojGodina} anuitet je {anuitet:N2} a ukupno plaćena kamata je {iznosKamata:N2}");
    }
}
while (nastavi);
