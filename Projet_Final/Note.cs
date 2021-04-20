using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Final
{
    class Note

    {
        private string _numeroEtudiant;
        private string _numeroCours;
        private string _note;

        public string getNumeroEtudiant()
        {
            return this._numeroEtudiant;
        }

        public void setNumeroEtudiant(string numeroEtudiant)
        {
            this._numeroEtudiant = numeroEtudiant;
        }

        public string getNumeroCours()
        {
            return this._numeroCours;
        }

        public void setNumeroCours(string numeroCours)
        {
            this._numeroCours = numeroCours;
        }

        public string getNote()
        {
            return this._note;
        }

        public void setNote(string note)
        {
            this._note = note;
        }

        public Note(string numeroEtudiant, string numeroCours, string note)
        {
            this._numeroEtudiant = numeroEtudiant;
            this._numeroCours = numeroCours;
            this._note = note;

        }
    }
}
