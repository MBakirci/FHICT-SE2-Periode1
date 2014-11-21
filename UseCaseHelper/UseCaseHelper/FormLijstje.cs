using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCaseHelper
{
    public class FormLijstje
    {
        string naam;
        string samenvatting;
        string actoren;
        string aannamen;
        string beschrijving;
        string uitzonderingen;
        string resultaat;

        public string Naam
        {
            get
            {
                return naam;
            }
        }

        public string Samenvatting
        {
            get
            {
                return samenvatting;
            }
        }

        public string Actoren
        {
            get
            {
                return actoren;
            }
        }

        public string Aannamen
        {
            get
            {
                return aannamen;
            }
        }

        public string Beschrijving
        {
            get
            {
                return beschrijving;
            }
        }

        public string Uitzonderingen
        {
            get
            {
                return uitzonderingen;
            }
        }

        public string Resultaat
        {
            get
            {
                return resultaat;
            }
        }

        public FormLijstje(string Naam, string Samenvatting, string Actoren,string Aannamen, string Beschrijving,
            string Uitzonderingen, string Resultaat )
        {
            this.naam = Naam;
            this.samenvatting = Samenvatting;
            this.actoren = Actoren;
            this.aannamen = Aannamen;
            this.beschrijving = Beschrijving;
            this.uitzonderingen = Uitzonderingen;
            this.resultaat = Resultaat;
        }


    }
}
