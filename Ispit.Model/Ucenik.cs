using System;

namespace Ispit.Model
{
    public class Ucenik
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public double Prosjek { get; set; }

        public int Starost()
        {
            int starost = DateTime.Now.Year - DatumRodjenja.Year;
            if (DateTime.Now.DayOfYear < DatumRodjenja.DayOfYear)
            {
                starost--;
            }
            return starost;
        }

        public string IspisProsjeka()
        {
            if (Prosjek >= 1 && Prosjek <= 1.49)
                return "nedovoljan";
            else if (Prosjek >= 1.50 && Prosjek <= 2.49)
                return "dovoljan";
            else if (Prosjek >= 2.50 && Prosjek <= 3.49)
                return "dobar";
            else if (Prosjek >= 3.50 && Prosjek <= 4.49)
                return "vrlo dobar";
            else if (Prosjek >= 4.50 && Prosjek <= 5.00)
                return "odličan";
            else
                return "Prosjek se zbago!!";
        }


    }


}
