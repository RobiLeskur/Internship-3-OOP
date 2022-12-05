using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internship_3_OOP_Calendar_2._0.Classes
{
    public class Osoba

    {
        public string ime;
        public string prezime;
        public string email { get; }
        public Dictionary<Guid, bool> prisutnost = new Dictionary<Guid, bool>();

        public Osoba(string aIme, string aPrezime, string aEmail, Dictionary<Guid, bool> aPrisutnost)
        {
            ime = aIme;
            prezime = aPrezime;
            email = aEmail;
            prisutnost = aPrisutnost;
        }
    }
}

