using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Naam_10._5._1
{

    public delegate String GetNaamMethod();
    class Persoon
    {

        private string voornaam;
        private string tussenvoegsel;
        private string achternaam;

        public string Voornaam { get { return voornaam; } set { voornaam = value;} }
        public string Tussenvoegesel { get { return tussenvoegsel; } set { tussenvoegsel = value;} }
        public string Achternaam { get { return achternaam; } set { achternaam = value; } }

        public Persoon(string naam, string tussenvoegsel, string achternaam)
        {
            this.voornaam = naam;
            this.tussenvoegsel = tussenvoegsel;
            this.achternaam = achternaam;
        }
        public string NaamTussenAchter()
        {
            string volledigNaam = voornaam + " " + tussenvoegsel + " " + achternaam;
            return volledigNaam;
            
        }

        public string AchterNaamTussen()
        {
            string volledigNaam = achternaam + ", " + voornaam + " " + tussenvoegsel;
            return volledigNaam;
        }

        public string AchterTussenNaam()
        {
            string volledigNaam = achternaam + " " + tussenvoegsel + ", " + voornaam;
            return volledigNaam;
        }

    }
}
