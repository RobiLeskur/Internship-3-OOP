using System;
using Internship_3_OOP_Calendar;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Tracing;

namespace Internship_3_OOP_Calendar.Classes
{
     class Event
    {
        public Guid id;
        public string naziv;
        public string lokacija;
        public DateTime datumPocetka;
        public DateTime datumKraja;
        public string email;

        public Event(Guid aId, string aNaziv, string aLokacija, DateTime aDatumPocetka, DateTime aDatumKraja, string aEmail)
        {
            id = aId;
            naziv = aNaziv; 
            lokacija = aLokacija;
            datumPocetka = aDatumPocetka;
            datumKraja = aDatumKraja;
            email = aEmail; 

        }

        

    }
}
