using Internship_3_OOP_Calendar;
using Internship_3_OOP_Calendar_2._0.Classes;
using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Internship_3_OOP_Calendar
{
    internal class Program
    {


        static Guid EventToGuidParser(string eventInput)
        {
            Guid eventOutput;
            var isValidInput = false;
            do
            {


                isValidInput = Guid.TryParse(eventInput, out eventOutput);
                if (isValidInput == false)
                    Console.WriteLine("\nKrivi unos, pokusaj ponovo:");


                if (isValidInput == true)
                    break;
                eventInput = Console.ReadLine();


            } while (isValidInput != true);

            return eventOutput;
        }




        static void Main(string[] args)
        {

            
            Event event1 = new Event(Guid.NewGuid(), "Karlov rodendan", "Jesenice", new DateTime(2022, 11, 26, 22, 0, 0), new DateTime(2022, 11, 27, 22, 0, 0), new List<string>{ "ivo.karlovic@dump.hr", "leo.stipicic@dump.hr", "robert.leskur@dump.hr", "maminjo@dump.hr", "pero.peric@dump.hr", "luce.stipancic@dump.hr", "marko.markovic@dump.hr", "josko.gvardiol@dump.hr" });
            Event event2 = new Event(Guid.NewGuid(), "Rucak", "Split", new DateTime(2022, 11, 10, 10, 0, 0), new DateTime(2022, 11, 10, 10, 30, 0), new List<string> { "leo.stipicic@dump.hr", "robert.leskur@dump.hr", "maminjo@dump.hr", "daliborko@dump.hr", "pero.peric@dump.hr", "luce.stipancic@dump.hr", "marko.markovic@dump.hr", "duje.saric@dump.hr" });
            Event event3 = new Event(Guid.NewGuid(), "Godina", "Svijet", new DateTime(2022, 1, 1, 0, 0, 0), new DateTime(2023, 1, 1, 0, 0, 0), new List<string> { "ivo.karlovic@dump.hr", "leo.stipicic@dump.hr", "maminjo@dump.hr", "daliborko@dump.hr", "pero.peric@dump.hr", "duje.saric@dump.hr" });
            Event event4 = new Event(Guid.NewGuid(), "Bozic", "Zemlja", new DateTime(2024, 12, 25, 0, 0, 0), new DateTime(2024, 12, 26, 0, 0, 0), new List<string> { "ivo.karlovic@dump.hr", "robert.leskur@dump.hr", "maminjo@dump.hr", "luce.stipancic@dump.hr", "josko.gvardiol@dump.hr", "duje.saric@dump.hr" });
            Event event5 = new Event(Guid.NewGuid(), "Robijevo rodenje", "Split", new DateTime(2005, 10, 10, 23, 54, 12), new DateTime(2005, 10, 10, 23, 54, 12), new List<string> { "ivo.karlovic@dump.hr", "robert.leskur@dump.hr", "daliborko@dump.hr", "pero.peric@dump.hr", "luce.stipancic@dump.hr", "marko.markovic@dump.hr", "josko.gvardiol@dump.hr" } );

            Dictionary<string, Event> events = new Dictionary<string, Event>()
            {
                {"Karlov rodendan", event1},
                {"Rucak", event2},
                {"Godina", event3},
                {"Bozic", event4},
                {"Robijevo rodenje", event5},
            };






            Osoba osoba1 = new Osoba("Ivo", "Karlovic", "ivo.karlovic@dump.hr", new Dictionary<Guid, bool>(){
            {event1.id, true},
            {event3.id, false},
            {event4.id, false},
            {event5.id, false}
            });

            Osoba osoba2 = new Osoba("Leo", "Stipicic", "leo.stipicic@dump.hr", new Dictionary<Guid, bool>(){
            {event1.id, false},
            {event2.id, false},
            {event3.id, true},
            });

            Osoba osoba3 = new Osoba("Robert", "Leskur", "robert.leskur@dump.hr", new Dictionary<Guid, bool>(){
            {event1.id, true},
            {event2.id, true},
            {event4.id, false},
            {event5.id, true}
            });

            Osoba osoba4 = new Osoba("Zdravko", "Mamic", "maminjo@dump.hr", new Dictionary<Guid, bool>(){
            {event1.id, false},
            {event2.id, true},
            {event3.id, true},
            {event4.id, false}

            });

            Osoba osoba5 = new Osoba("Dalibor", "Borkovic", "daliborko@dump.hr", new Dictionary<Guid, bool>(){
            {event2.id, false},
            {event3.id, true},
            {event5.id, true}
            });
            Osoba osoba6 = new Osoba("Pero", "Peric", "pero.peric@dump.hr", new Dictionary<Guid, bool>(){
            {event1.id, false},
            {event2.id, true},
            {event3.id, true},
            {event5.id, false}
            });

            Osoba osoba7 = new Osoba("Lucija", "Stipancic", "luce.stipancic@dump.hr", new Dictionary<Guid, bool>(){
            {event1.id, false},
            {event2.id, false},
            {event4.id, false},
            {event5.id, false}
            });

            Osoba osoba8 = new Osoba("Marko", "Markovic", "marko.markovic@dump.hr", new Dictionary<Guid, bool>(){
            {event1.id, false},
            {event2.id, true},
            {event5.id, true}
            });

            Osoba osoba9 = new Osoba("Josko", "Gvardiol", "josko.gvardiol@dump.hr", new Dictionary<Guid, bool>(){
            {event1.id, false},
            {event4.id, false},
            {event5.id, true}
            });

            Osoba osoba10 = new Osoba("Duje", "Saric", "duje.saric@dump.hr", new Dictionary<Guid, bool>()
            {
            {event2.id, true},
            {event3.id, true},
            {event4.id, false}

            });


            Dictionary<string, Osoba> osobe = new Dictionary<string, Osoba>()
            {
                {"Ivo", osoba1},
                {"Leo", osoba2},
                {"Robert", osoba3},
                {"Zdravko", osoba4},
                {"Dalibor", osoba5},
                {"Pero", osoba6},
                {"Lucija", osoba7},
                {"Marko", osoba8},
                {"Josko", osoba9},
                {"Duje", osoba10},
            };






            var naredba = "";



            do
            {


                Console.Clear();

                List<string> newEventParticipants = new List<string>();


                Console.WriteLine("---------------IZBORNIK--------------- \n");

                Console.WriteLine("1 - Aktivni eventi");
                Console.WriteLine("2 - Nadolazeci eventi");
                Console.WriteLine("3 - Eventi koji su zavrsili");
                Console.WriteLine("4 - Kreiraj event");
                Console.WriteLine("0 - Izlaz iz programa");

                Console.Write("\nUnesi broj naredbe: ");
                naredba = Console.ReadLine();

                switch (naredba)
                {

                    default:
                        //---------------------------------------------------------------------------------------------- defaut start
                        Console.Clear();
                        Console.WriteLine("---------------IZBORNIK--------------- \n");

                        Console.WriteLine("1 - Aktivni eventi");
                        Console.WriteLine("2 - Nadolazeci eventi");
                        Console.WriteLine("3 - Eventi koji su zavrsili");
                        Console.WriteLine("4 - Kreiraj event");
                        Console.WriteLine("0 - Izlaz iz programa");

                        Console.Write("\nUnesi broj naredbe: ");
                        naredba = Console.ReadLine();
                        break;

                    case "0":
                        return;


                    case "1":
                        //---------------------------------------------------------------------------------------------- aktivni elementi start

                        var konacanOdabir1 = "";
                        do
                        {
                            var odabir1 = "";
                            do
                            {
                                Console.Clear();
                                Console.WriteLine("---------------AKTIVNI EVENTI--------------- \n");

                                Console.WriteLine("Eventi: ");
                                foreach (var item in events)
                                {
                                    if (item.Value.datumPocetka < DateTime.Now && item.Value.datumKraja > DateTime.Now)
                                    {
                                        Console.WriteLine("---------------------------------------------------");
                                        Console.WriteLine($"Id - {item.Value.id}" +
                                            $"\nNaziv - {item.Value.naziv}" +
                                            $"\nLokacija - {item.Value.lokacija}" +
                                            $"\nEnds in - {item.Value.datumKraja}\n");

                                        Console.WriteLine("Prisutni: ");


                                        foreach (var covjek in osobe)
                                        {
                                            foreach (var prisutnostOsobe in covjek.Value.prisutnost)
                                            {
                                                if (prisutnostOsobe.Key == item.Value.id)
                                                    Console.WriteLine(covjek.Value.ime + "  " + covjek.Value.prezime + " - " + covjek.Value.email);


                                            }
                                        }
                                        Console.WriteLine("---------------------------------------------------");
                                    }



                                }


                                Console.WriteLine("\n1 - Zabiljezi neprisutnost");
                                Console.WriteLine("0 - Povratak na glavni menu");

                                odabir1 = Console.ReadLine();
                            } while (odabir1 != "1" && odabir1 != "0");



                            if (odabir1 == "1")
                            {
                                Console.WriteLine("---------------ZABILJEZI NEPRISUTNOST--------------- \n");

                                Console.WriteLine("Unesi id eventa: ");

                                var eventIdInput = Console.ReadLine();
                                var eventIdOutput = EventToGuidParser(eventIdInput);
                                Console.WriteLine("");

                                string personsEmail;
                                do
                                {
                                    Console.WriteLine("Unesi e-mail osobe koji nisu bili prisutni(unesi 0 za prestati): ");
                                    personsEmail = Console.ReadLine();

                                    foreach (var item in osobe)
                                    {
                                        if (item.Value.email == personsEmail)
                                        {
                                            if (item.Value.prisutnost[eventIdOutput] == false)
                                            {
                                                Console.WriteLine("\nOsoba nije prisutna eventu...\n");
                                                Console.ReadLine();

                                            }
                                            else
                                            {
                                                item.Value.prisutnost[eventIdOutput] = false;
                                                Console.WriteLine("\nOsoba zabiljezena! \n");


                                            }
                                        }
                                    }

                                } while (personsEmail != "0");

                                konacanOdabir1 = "";
                            }
                            else
                            {
                                naredba = "";
                                konacanOdabir1 = "1";
                                continue;
                            }
                        } while (konacanOdabir1 != "1");



                        break;
                    //---------------------------------------------------------------------------------------------- aktivni elementi end
                    case "2":
                        //---------------------------------------------------------------------------------------------- nadolazeci elementi start

                        konacanOdabir1 = "";
                        do
                        {
                            var odabir2 = "";
                            do
                            {
                                Console.Clear();
                                Console.WriteLine("---------------NADOLAZECI EVENTI--------------- \n");

                                Console.WriteLine("Eventi:\n ");
                                foreach (var item in events)
                                {

                                    if (item.Value.datumPocetka > DateTime.Now)
                                    {
                                        Console.WriteLine("----------------------------------------------------");
                                        Console.WriteLine($"Id - {item.Value.id}" +
                                            $"\nNaziv - {item.Value.naziv}" +
                                            $"\nPocinje za - {Math.Round((item.Value.datumPocetka-DateTime.Now).TotalDays, 1)} d" +
                                            $"\nTrajanje - {Math.Round((item.Value.datumPocetka - item.Value.datumKraja).TotalHours, 1)} h \n");

                                      

                                        Console.WriteLine("Prisutni: ");
                                        foreach (var covjek in osobe)
                                        {
                                            foreach (var prisutnostOsobe in covjek.Value.prisutnost)
                                            {
                                                if (prisutnostOsobe.Key == item.Value.id)
                                                    Console.WriteLine(covjek.Value.ime + "  " + covjek.Value.prezime + " - " + covjek.Value.email);


                                            }

                                        }
                                        Console.WriteLine("----------------------------------------------------");
                                    }



                                }




                                Console.WriteLine("--------SUBMENU--------");
                                Console.WriteLine("1 - Izbrisi event");
                                Console.WriteLine("2 - Ukloni osobe s eventa");
                                Console.WriteLine("0 - Povratak na glavni menu");

                                odabir2 = Console.ReadLine();

                            } while (odabir2 != "1" && odabir2 != "2" && odabir2 != "0");



                            if (odabir2 == "1")
                            {
                                Console.WriteLine("---------------IZBRISI EVENT--------------- \n");

                                Console.WriteLine("Unesi id eventa(0 - povratak): ");
                                var unosEventa2 = "";
                                bool isValidInput = false;
                                Guid iznosEventa = Guid.Empty;

                                do
                                {
                                    unosEventa2 = Console.ReadLine();
                                    if (unosEventa2 == "0")
                                        break;


                                    isValidInput = Guid.TryParse(unosEventa2, out iznosEventa);
                                    if (isValidInput == false)
                                        Console.WriteLine("\nKrivi unos, pokusaj ponovo:");
                                    else
                                    {


                                        foreach (var item in events)
                                        {
                                            if (item.Value.id == iznosEventa)
                                                events.Remove(item.Key);
                                        }


                                    }

                                } while (isValidInput != true);



                                konacanOdabir1 = "";
                            }
                            else if (odabir2 == "2")
                            {
                                Console.WriteLine("-------UKLONI OSOBE S EVENTA------- \n");

                                Console.WriteLine("Unesi id eventa(0 - povratak): ");

                                var eventIdInput = Console.ReadLine();

                                if (eventIdInput == "0")
                                    continue;
                                var eventIdOutput = EventToGuidParser(eventIdInput);


                                string personsEmail;
                                do
                                {
                                    Console.WriteLine("Unesi e-mail osobe koji nisu bili prisutni(unesi 0 za prestati): ");
                                    personsEmail = Console.ReadLine();

                                    foreach (var item in osobe)
                                    {
                                        if (item.Value.email == personsEmail)
                                        {
                                            if (!item.Value.prisutnost.ContainsKey(eventIdOutput))
                                            {
                                                Console.WriteLine("\nOsoba nije sudionik eventa...\n");

                                            }
                                            else
                                            {

                                                item.Value.prisutnost.Remove(eventIdOutput);
                                                Console.WriteLine("\nOsoba uklonjena! \n");


                                            }
                                        }
                                    }

                                } while (personsEmail != "0");


                            }
                            else
                            {
                                naredba = "";
                                konacanOdabir1 = "1";
                                continue;
                            }
                        } while (konacanOdabir1 != "1");



                        break;
                    //---------------------------------------------------------------------------------------------- eventi koji su zavrsili start
                    case "3":





                        Console.Clear();
                        Console.WriteLine("---------------ZAVRSENI EVENTI--------------- \n");

                        Console.WriteLine("Eventi: ");
                        foreach (var item in events)
                        {
                            if (item.Value.datumKraja < DateTime.Now)
                            {
                                Console.WriteLine("--------------------------------------------------------------");
                                Console.WriteLine($"Id - {item.Value.id}" +
                                    $"\nNaziv - {item.Value.naziv}" +
                                    $"\nZavrsio prije - {Math.Round((DateTime.Now - item.Value.datumKraja).TotalDays, 1)} d" +
                                    $"\nTrajanje - {Math.Round((item.Value.datumKraja - item.Value.datumPocetka).TotalHours, 1)} h \n");



                                foreach (var covjek in osobe)
                                {
                                    foreach (var prisutnostOsobe in covjek.Value.prisutnost)
                                    {
                                        if (prisutnostOsobe.Key == item.Value.id && prisutnostOsobe.Value == true)
                                            Console.WriteLine(covjek.Value.ime + "  " + covjek.Value.prezime + " - " + covjek.Value.email + " - Bio je prisutan");
                                        else if (prisutnostOsobe.Key == item.Value.id && prisutnostOsobe.Value == false)
                                            Console.WriteLine(covjek.Value.ime + "  " + covjek.Value.prezime + " - " + covjek.Value.email + " - Nije bio je prisutan");
                                    }
                                }
                                Console.WriteLine("--------------------------------------------------------------");


                            }


                        }

                        Console.WriteLine("\nPovratak...");
                        Console.ReadLine();







                        break;
                    //---------------------------------------------------------------------------------------------- eventi koji su zavrsili end


                    case "4":


                       


                        Console.Clear();
                        Console.WriteLine("---------------KREIRAJ EVENT--------------- \n");

                        Console.WriteLine("Unesite naziv eventa: ");
                        var eventName = Console.ReadLine();
                        Console.WriteLine("Unesite lokaciju eventa: ");
                        var eventLocation = Console.ReadLine();
                        Console.WriteLine("Unesite datum pocetka eventa(dd.mm.yyyy)(*datum mora biti u buducnosti): ");
                        bool isDateValid = false;
                        DateTime newEventStart = new DateTime();
                        DateTime newEventEnd = new DateTime();

                        do {                           
                            DateTime userDateTime;
                            isDateValid = DateTime.TryParse(Console.ReadLine(), out userDateTime);

                            if (userDateTime < DateTime.Now) {
                                Console.WriteLine("Nesipravan unos, pokusaj ponovo: ");
                                isDateValid = false;
                                continue;
                            }                  

                            if (isDateValid == true)
                            {
                                newEventStart = userDateTime;
                                Console.WriteLine("");
                            }
                            else
                            {
                                Console.WriteLine("Krivi unos, unesi ponovo: ");
                            }

                            

                        } while (isDateValid == false);

                        Console.WriteLine("Unesite datum kraja eventa(mm.dd.yyyy): ");
                        isDateValid = false;
                        do
                        {
                            

                            DateTime userDateTime;
                            isDateValid = DateTime.TryParse(Console.ReadLine(), out userDateTime);
                            
                            if (newEventStart > userDateTime)
                            {
                                Console.WriteLine("Datum kraja mora biti poslje datuma pocetka, unesi ponovo: ");
                                isDateValid= false;
                                continue;

                            }

                            if (isDateValid == true)
                            {
                                newEventStart = userDateTime;
                                Console.WriteLine("");
                            }
                            else
                            {
                                Console.WriteLine("Krivi unos, unesi ponovo: ");
                            }
                        } while (isDateValid == false);

                        

                        
                        Console.WriteLine("----------------------------------------");
                        foreach (var item in osobe)
                        {
                            Console.WriteLine($"{item.Value.ime} {item.Value.prezime} - {item.Value.email}");
                        }
                        Console.WriteLine("----------------------------------------");
                      
                        var personsEmailInput = "";
                        do
                        {
                            Console.WriteLine("Unesi e-mail sudionika kojeg zelis dodati na event(0 - povratak): ");
                            personsEmailInput = Console.ReadLine();
                            newEventParticipants.Add(personsEmailInput);

                            if (personsEmailInput == "0")
                            {
                                naredba = "";
                                continue;
                            }
                            newEventParticipants.Add(personsEmailInput);


                        } while (personsEmailInput != "0");


                        Event newEvent = new Event(Guid.NewGuid(), eventName, eventLocation, newEventStart, newEventEnd, newEventParticipants);
                        events.Add(newEvent.naziv, newEvent);




                        break;


                }

            } while (naredba != "1" && naredba != "2" && naredba != "3" && naredba != "4" && naredba != "0");




        }
    }
}