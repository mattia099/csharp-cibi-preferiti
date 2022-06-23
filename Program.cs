// See https://aka.ms/new-console-template for more information

string[] cibi = { "Lasagna", "Tiramisù", "Arancino", "Pizza", "Gelato" };

Console.WriteLine(cibi.Length);

for (int i = 0; i < cibi.Length; i++)
{
    Console.WriteLine($"{i + 1}. {cibi[i]}");
}

Console.WriteLine($"Primo cibo in calssifica: {cibi[0]}");

Console.WriteLine($"Ultimo cibo in calssifica: {cibi[cibi.Length - 1]}");

if (cibi.Length % 2 == 0)
{
    Console.WriteLine($"Cibo di metà classifica: {cibi[cibi.Length / 2]} {cibi[cibi.Length / 2 - 1]}");
}
else {
    Console.WriteLine($"Cibo di metà classifica: {cibi[cibi.Length / 2]}");
}


