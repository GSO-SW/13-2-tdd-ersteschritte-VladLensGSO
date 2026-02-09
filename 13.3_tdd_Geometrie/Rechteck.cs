using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._3_tdd_Geometrie
{
    // Klasse muss public sein, sonst kann sie das 
    // externe Testprojekt nicht nutzen.
    public class Rechteck 
    {
        private int breite;
        private int hoehe;

        public int Breite { 
            get { return breite; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Breite darf nicht kleiner als 0 sein ");
                }
                else
                {
                    breite = value;
                }
            }

        }
        public int Hoehe { 
            get { return hoehe; } 
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Höhe darf nicht kleiner als 0 sein ");
                }
                else
                {
                    hoehe = value;
                }
            }
        }

        public void Skalieren(double faktor)
        {
            if (faktor <= 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            breite = Convert.ToInt32(breite * faktor);
            hoehe = Convert.ToInt32(hoehe * faktor);
        }

        public Rechteck(int breite, int hoehe)
        {
            this.breite = breite;
            this.hoehe = hoehe;
        }

        public Rechteck() :this(0,0)
        {

        }



        public int Umfang()
        {
            return ((breite * 2) + (hoehe * 2));
        }
        public int Flaeche()
        {
            return breite*hoehe;
        }

    }
}
