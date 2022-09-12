

using Tårta;

public class Program
{
    static void Inmätning(Choklad c)
    {
        Console.WriteLine("Chokladnamn: ");
        c.chokladnamn = Console.ReadLine();
        Console.WriteLine("Pris på choklad: ");
        c.pris = Convert.ToDouble(Console.ReadLine());
    }
    static void Registrering(Tårtan t)
    {
        Console.WriteLine("Tårtans namn: ");
        t.namn = Console.ReadLine();
    }
    static void TårtansPris(Tårtan t, Choklad[] c, int n)
    {
        double PrisT;
        PrisT = t.MinPris(c, n) * 10;
        Console.WriteLine("Priset på tårtan när man väljer den billigaste chokladen är {0}", PrisT);
        PrisT = t.GenomsnittligtPris(c, n) * 10;
        Console.WriteLine("Priset på tårtan vid val av choklad är medelpriset {0}", PrisT);
    }
    static void Main(string[] args)
    {
        int n, i;
        Console.WriteLine("Ange antal choklad: ");
        n = int.Parse(Console.ReadLine());
        Choklad[] c = new Choklad[n];
        Tårtan t = new Tårtan();

        Console.WriteLine("----------------------------------------");
        // Inmatning av data
        for (i = 0; i < n; i++)
        {
            c[i] = new Choklad();
            Console.WriteLine();
            Inmätning(c[i]);
        }
        Console.WriteLine("----------------------------------------");
        Console.WriteLine();
        Console.WriteLine("Ange namnet på tårtan");
        Registrering(t);
        TårtansPris(t, c, n);
        Console.ReadKey();
    }
}