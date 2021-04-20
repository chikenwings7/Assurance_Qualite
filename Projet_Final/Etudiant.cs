using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Final
{
    class Etudiant

    {
        private string _numeroEtudiant;
        private string _nom;
        private string _prenom;

        public string getNumeroEtudiant()
        {
            return this._numeroEtudiant;
        }

        public void setNumeroEtudiant(string numeroEtudiant)
        {
            this._numeroEtudiant = numeroEtudiant;
        }

        public string getNom()
        {
            return this._nom;
        }

        public void setNom(string nom)
        {
            this._nom = nom;
        }

        public string getPrenom()
        {
            return this._prenom;
        }

        public void setPrenom(string prenom)
        {
            this._prenom = prenom;
        }

        public Etudiant()
        {
            this._prenom = "null";
            this._nom = "null";
            this._numeroEtudiant = "000000";

        }

        public Etudiant(string prenom, string nom, string numeroEtudiant)
        {
            this._prenom = prenom;
            this._nom = nom;
            this._numeroEtudiant = numeroEtudiant;

        }

        public override string ToString()
        {
            return _prenom + "," + _nom + "," + _numeroEtudiant;
        }

    }
}
