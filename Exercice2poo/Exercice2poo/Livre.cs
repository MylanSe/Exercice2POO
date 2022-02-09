using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Livre
    {
        private string titre;
        private string auteur;
        private float prix;
        public Livre(string titre, string auteur, float prix)
        {
            this.titre = titre;
            this.auteur = auteur;
            this.prix = prix;
        }
        public string Titre
        {

            get
            {
                return titre;
            }
            set
            {
                titre = value;
            }
        }
        public string Auteur
        {

            get
            {
                return auteur;
            }
            set
            {
                auteur = value;
            }
        }
        public float Prix
        {

            get
            {
                return prix;
            }
            set
            {
                prix = value;
            }
        }
        public void Afficher()
        {
            Console.WriteLine("Titre: " + this.titre + "| Auteur: " + this.auteur + "| Prix: " + this.prix);
        }
    }
}