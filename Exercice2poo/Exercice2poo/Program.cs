using System;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)

        {
            Console.WriteLine("Titre");
            string Titre = Console.ReadLine();
            Console.WriteLine("Auteur");
            string Auteur = Console.ReadLine();
            Console.WriteLine("Prix");
            float Prix = int.Parse(Console.ReadLine());
            Livre unLivre = new Livre(Titre, Auteur, Prix);
            Console.WriteLine("Titre");
            Titre = Console.ReadLine();
            Console.WriteLine("Auteur");
            Auteur = Console.ReadLine();
            Console.WriteLine("Prix");
            Prix = int.Parse(Console.ReadLine());
            Livre unLivre2 = new Livre(Titre, Auteur, Prix);
            unLivre.Afficher();
            unLivre2.Afficher();
        }
    }
}