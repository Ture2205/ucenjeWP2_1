using IbanNet;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("E07")]
   public class E07Metode : ControllerBase
    {
        [HttpGet]
        [Route("zad1")]
        public int Zad1(int PrviBroj, int DrugiBroj)
        {
            // Napišite metodu koja za dva primljena cijela
            // broj vraća njihov zbroj
            // Neka ova metoda Zad1 vrati rezultat napisane metode zadatka

            return Zbroji(PrviBroj, DrugiBroj);

        }

        [HttpGet]
        [Route("iban")]
        public bool provjeri(string iban)
        {
            return new IbanValidator().Validate(iban).IsValid;


       }

        private int Zbroji(int prviBroj, int drugiBroj)
        {
            return prviBroj + drugiBroj;
        }


        // DZ
        // Krierati rutu zad2 koja prima 4 cijela broja
        // i vraća razliku prvi+drugi i treći+četvrti
        // Koristite kreiranu metodu za zbroj dvaju brojeva

        public class Program
        {
            static void Main(string[] args)
            {
                // Unos četiri cijela broja
                Console.WriteLine("Unesite prvi broj:");
                int prvi = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Unesite drugi broj:");
                int drugi = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Unesite treći broj:");
                int treci = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Unesite četvrti broj:");
                int cetvrti = Convert.ToInt32(Console.ReadLine());

                // Pozivanje rute zadatka 2 i ispis rezultata
                int rezultat = Zad2(prvi, drugi, treci, cetvrti);
                Console.WriteLine("Razlika prvi+drugi i treći+četvrti je: " + rezultat);

                Console.ReadLine(); // čekanje na Enter prije zatvaranja prozora
            }


            static int Zad2(int prvi, int drugi, int treci, int cetvrti)
            {
                // Zbroj prva dva broja i zbroj druga dva broja
                int zbrojPrvogIDrugog = Zbroji(prvi, drugi);
                int zbrojTrecegICetvrtog = Zbroji(treci, cetvrti);

                // Vraćanje razlike zbrojeva
                return zbrojPrvogIDrugog - zbrojTrecegICetvrtog;
            }

            // Kreirana metoda za zbroj dvaju brojeva
            private static int Zbroji(int prviBroj, int drugiBroj)
            {
                return prviBroj + drugiBroj;
            }
        }




        // Krierati rutu zad3 koja prima ime grada i slovo.
        // Ruta vraća broj pojavljivanja slova u primljenom imenu grada
        // Koristiti metode


    }
    class Program
    {
        static void Main(string[] args)
        {
            // Unos imena grada i slova
            Console.WriteLine("Unesite ime grada:");
            string imeGrada = Console.ReadLine();

            Console.WriteLine("Unesite slovo:");
            char slovo = Console.ReadKey().KeyChar; // čitanje samo prvog unesenog znaka

            // Pozivanje rute zadatka 3 i ispis rezultata
            int brojPojavljivanja = Zad3(imeGrada, slovo);
            Console.WriteLine("\nBroj pojavljivanja slova '" + slovo + "' u imenu grada '" + imeGrada + "' je: " + brojPojavljivanja);

            Console.ReadLine(); // čekanje na Enter prije zatvaranja prozora
        }

        // Kreiranje rute zadatka 3 koja vraća broj pojavljivanja slova u imenu grada
        static int Zad3(string imeGrada, char slovo)
        {
            int brojPojavljivanja = 0;

            // Prolazak kroz svako slovo u imenu grada i brojanje pojavljivanja željenog slova
            foreach (char c in imeGrada)
            {
                if (char.ToLower(c) == char.ToLower(slovo)) // ignoriranje veličine slova
                    brojPojavljivanja++;
            }

            return brojPojavljivanja;

        }
    }
}
