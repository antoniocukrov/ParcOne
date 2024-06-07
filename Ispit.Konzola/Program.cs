using Ispit.Model;
using System;

namespace Ispit.Konzola
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Ucenik[] ucenici = new Ucenik[3];

            for (int u = 0; u < 3; u++)
            {
                ucenici[u] = new Ucenik();

                Console.Write("Unesite ime: ");
                ucenici[u].Ime = Console.ReadLine();

                Console.Write("Unesite prezime: ");
                ucenici[u].Prezime = Console.ReadLine();

                Console.Write("Unesite datum rođenja(yyyy-mm-dd): ");
                ucenici[u].DatumRodjenja = DateTime.Parse(Console.ReadLine());

                Console.Write("Unesite prosjek: ");
                ucenici[u].Prosjek = double.Parse(Console.ReadLine());
                
                Console.WriteLine();
            }

            Console.WriteLine("Ime,Prezime,Starost i prosjek ocjena");
            foreach (var ucenik in ucenici)
            {
                Console.WriteLine($"{ucenik.Ime}, {ucenik.Prezime}, {ucenik.Starost()}, {ucenik.IspisProsjeka()}");
            }
            Console.ReadLine();
        }
    }
} 
        
    
