using System.ComponentModel.Design;

class Program
{



    static void Main(string[] args)
    {
        
    start:
        Console.WriteLine("Podaj liczbę: ");
        int liczba = int.Parse(Console.ReadLine());
        Console.WriteLine();
        if (liczba == 0)
        {
            goto koniec;
        }
        
        Console.WriteLine($"Podałeś {liczba}");
        Console.WriteLine();
        goto start;

    koniec:
        Console.WriteLine("Koniec programu");
    }
}