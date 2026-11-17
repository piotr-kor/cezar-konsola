using System;

public class Program
{
    public static string SzyfrCezara(string tekst, int klucz)
    {
        string wynik = "";

        klucz = klucz % 26;

        foreach (char znak in tekst)
        {
            if (znak == ' ')
            {
                wynik += ' ';
            }
            else
            {
                char nowyZnak = (char)('a' + (znak - 'a' + klucz + 26) % 26);
                wynik += nowyZnak;
            }
        }

        return wynik;
    }

    static void Main()
    {
        Console.Write("Podaj tekst: ");
        string tekst = Console.ReadLine();

        Console.Write("Podaj klucz: ");
        int klucz = int.Parse(Console.ReadLine());

        string wynik = SzyfrCezara(tekst, klucz);

        Console.WriteLine("Tekst zaszyfrowany: " + wynik);
    }
}