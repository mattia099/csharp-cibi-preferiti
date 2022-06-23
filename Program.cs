// See https://aka.ms/new-console-template for more information




string[] cibi = { "Lasagna", "Tiramisù", "Arancino", "Pizza", "Gelato" };
//cibo utente
string myCibo;
do
{
    Console.WriteLine("Qaul è il tuo cibo preferito?");
    myCibo = Console.ReadLine();
} while (!Array.Exists(cibi, x => x == myCibo));
//cibo pc
Random nRand = new Random();

string pcCibo = cibi[nRand.Next(cibi.Length)];
Console.WriteLine(pcCibo);
Console.WriteLine(cibi.Length);

for (int i = 0; i < cibi.Length; i++)
{
    if(myCibo == pcCibo)
    {
        if(myCibo == cibi[i])
        {
            Console.WriteLine($"{i + 1}. {cibi[i]} -> Abbiamo lo stesso cibo preferito");
        }
        else
        {
            Console.WriteLine($"{i + 1}. {cibi[i]}");
        }
    }
    else if (myCibo == cibi[i]) {
        Console.WriteLine($"{i + 1}. {cibi[i]} ->Il mio cibo preferito");
    }else if (pcCibo == cibi[i]) 
    {
        Console.WriteLine($"{i + 1}. {cibi[i]} ->Il cibo preferito dal pc");
    }else
    {
        Console.WriteLine($"{i + 1}. {cibi[i]}");
    }
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

