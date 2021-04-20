using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Final
{
    class Cours
    {
        private string _code;
        private string _numeroCours;
        private string _titre;

        public string getCode()
        {
            return this._code;
        }

        public void setCode(string code)
        {
            this._code = code;
        }

        public string getNumeroCours()
        {
            return this._numeroCours;
        }

        public void setNumeroCours(string numeroCours)
        {
            this._numeroCours = numeroCours;
        }

        public string getTitre()
        {
            return this._titre;
        }

        public void setTitre(string titre)
        {
            this._titre = titre;
        }

        public Cours(string numero_cours, string titre, string code)
        {
            this._code = code;
            this._numeroCours = numero_cours;
            this._titre = titre;

        }

        public override string ToString()
        {
            return _code + "," + _numeroCours + "," + _titre;
        }

    }
}
