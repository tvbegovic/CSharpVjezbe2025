Console.WriteLine("Zamislio sam broj od 1-10. Probaj ga pogoditi.");
Console.Write("Unesi broj: ");
string unos = Console.ReadLine();
bool ok = int.TryParse(unos, out int broj);
if(!ok)
{
    Console.WriteLine("Pogrešan format");
    return;
}
if(broj < 1 ||  broj > 10)
{
    Console.WriteLine("Broj je izvan raspona");
    return;
}
Random random = new Random();
int zamisljeniBroj = random.Next(1, 11);
int razlika = Math.Abs(zamisljeniBroj - broj);
switch(razlika)
{
    case 0:
        Console.WriteLine("Sjajno, pogodili ste broj. Imate čokoladu");
        break;
    case 1:
    case 2:
    case 3:
        Console.WriteLine($"Broj je {zamisljeniBroj}. Jako dobro. Osvajate pola čokolade");
        break;
    case 4:
    case 5:
    case 6:
        Console.WriteLine($"Broj je {zamisljeniBroj}. Solidno. Dobili ste jedno rebro čokolade");
        break;
    default:
        Console.WriteLine("Više sreće drugi put");
        break;
}
    
