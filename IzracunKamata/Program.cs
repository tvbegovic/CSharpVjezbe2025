double IzracunKamata(double glavnica, double stopa)
{
    if (stopa < 0 || stopa > 20)
        throw new ArgumentOutOfRangeException("Stopa je izvan raspona");
    return glavnica * stopa / 100;
}

bool nastavi = true;
do
{
    try
    {
        Console.Write("Glavnica: ");
        string unos = Console.ReadLine();
        if (string.IsNullOrEmpty(unos))
            nastavi = false;
        else
        {
            bool ok = double.TryParse(unos, out double glavnica);
            if (!ok)
            {
                Console.WriteLine("Pogrešan format");
                continue;
            }
            Console.Write("Stopa (0-20%): ");
            unos = Console.ReadLine();
            ok = double.TryParse(unos, out double stopa);
            if (!ok)
            {
                Console.WriteLine("Pogrešan format");
                continue;
            }
            //if (stopa < 0 || stopa > 20)
            //{
            //    Console.WriteLine("Stopa je izvan raspona");
            //    continue;
            //}
            double kamata = IzracunKamata(glavnica, stopa);
            Console.WriteLine($"Za glavnicu {glavnica:N2} i stopu {stopa} kamata je {kamata:N2}");
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Dogodila se pogreška. Tekst: {ex.Message}");
    }
}
while (nastavi);
