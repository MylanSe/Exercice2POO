using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice_3_Poo
{
    class Employe
    {
        private int matricule;
        private string nom;
        private string prenom;
        private string dateNaissance;
        private string dateEmbauche;
        private int salaire;

        public Employe(int matricule, string nom, string prenom, string dateNaissance, string dateEmbauche, int salaire)
        {
            this.matricule = matricule;
            this.nom = nom;
            this.prenom = prenom;
            this.dateNaissance = dateNaissance;
            this.dateEmbauche = dateEmbauche;
            this.salaire = salaire;
        }

        public int Matricule
        {

            get
            {
                return matricule;
            }
            set
            {
                matricule = value;
            }
        }
        public string Nom
        {

            get
            {
                return nom;
            }
            set
            {
                nom = value;
            }
        }
        public string Prenom
        {

            get
            {
                return prenom;
            }
            set
            {
                prenom = value;
            }
        }

        public string DateNaissance
        {

            get
            {
                return dateNaissance;
            }
            set
            {
                dateNaissance = value;
            }
        }

        public string DateEmbauche
        {

            get
            {
                return dateEmbauche;
            }
            set
            {
                dateEmbauche = value;
            }
        }

        public int Salaire
        {
            get
            {
                return salaire;
            }
            set
            {
                salaire = value;
            }
        }

        public void Afficher()
        {
            Console.WriteLine("Matricule: " + this.matricule + "| Nom: " + this.nom + "| Prénom: " + this.prenom + "| Date de naissasnce: " + dateNaissance + "| Date d'embauche" + dateEmbauche + "| Salaire:" + salaire);
        }
        public int Age()
        {
            string dateString = this.dateNaissance;
            DateTime dateDateTime = DateTime.Parse(dateString);

        }
    }
}