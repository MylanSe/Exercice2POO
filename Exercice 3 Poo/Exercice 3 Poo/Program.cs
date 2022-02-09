using System;

namespace Exercice_3_Poo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Matricule");
            int Matricule = int.Parse(Console.ReadLine());
            Console.WriteLine("Nom");
            string Nom = Console.ReadLine();
            Console.WriteLine("Prénom");
            string Prenom = Console.ReadLine();
            Console.WriteLine("Date de Naissance (jj/mm/aaaa)");
            string DateNaissance = Console.ReadLine();
            Console.WriteLine("Date d'Embauche (jj/mm/aaaa)");
            string DateEmbauche = Console.ReadLine();
            Console.WriteLine("Salaire");
            int Salaire = int.Parse(Console.ReadLine());
            Employe employe1 = new Employe(Matricule, Nom, Prenom, DateNaissance, DateEmbauche, Salaire);
            employe1.Afficher();

            Console.WriteLine("Matricule");
            Matricule = int.Parse(Console.ReadLine());
            Console.WriteLine("Nom");
            Nom = Console.ReadLine();
            Console.WriteLine("Prénom");
            Prenom = Console.ReadLine();
            Console.WriteLine("Date de Naissance (jj/mm/aaaa)");
            DateNaissance = Console.ReadLine();
            Console.WriteLine("Date d'Embauche (jj/mm/aaaa)");
            DateEmbauche = Console.ReadLine();
            Console.WriteLine("Salaire");
            Salaire = int.Parse(Console.ReadLine());
            Employe employe2 = new Employe(Matricule, Nom, Prenom, DateNaissance, DateEmbauche, Salaire);
            employe2.Afficher();
        }
    }
}
