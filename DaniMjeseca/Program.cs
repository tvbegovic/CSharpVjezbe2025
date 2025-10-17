Console.Write("Mjesec (1-12): ");
string unos = Console.ReadLine();
bool ok = int.TryParse(unos, out int mjesec);
if (!ok)
{
    Console.WriteLine("Pogrešan format broja");
    return;
}
if(mjesec < 1 ||  mjesec > 12)
{
    Console.WriteLine("Mjesec je izvan raspona");
    return;
}
int brojDanaUMjesecu;
string dani = "dana";
switch(mjesec)
{
    case 2:
        if (DateTime.IsLeapYear(DateTime.Now.Year))
            brojDanaUMjesecu = 29;
        else
            brojDanaUMjesecu = 28;
        break;
    case 4:
    case 6:
    case 9:
    case 11:
        brojDanaUMjesecu = 30;
        break;
    default:
        brojDanaUMjesecu = 31;
        dani = "dan";
        break;
}    
Console.WriteLine($"{mjesec}. mjesec ima {brojDanaUMjesecu} {dani}.");
