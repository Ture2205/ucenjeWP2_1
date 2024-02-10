using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("E08")]
    public class E08Subota1:ControllerBase
    {
        [HttpGet]
        [Route("zad1")]
        public int Zad1(int PrviBroj, int DrugiBroj)
        {
            // Napišite metodu koja za dva primljena cijela
            // broj vraća njihov zbroj
            // Neka ova metoda Zad1 vrati rezultat napisane metode zadatka
            
            return Zbroji(PrviBroj,DrugiBroj);
            
        }

        private int Zbroji(int prviBroj, int drugiBroj)
        {
            return prviBroj + drugiBroj;
        }

        // DZ
        // Krierati rutu zad2 koja prima 4 cijela broja
        // i vraća razliku prvi+drugi i treći+četvrti
        // Koristite kreiranu metodu za zbroj dvaju brojeva
        [HttpGet]
        [Route("zad2")]
        public int Zad2(int PrviBroj, int DrugiBroj, int TreciBroj,int CetvrtiBroj)
        {
            return Razlika(PrviBroj, DrugiBroj, TreciBroj, CetvrtiBroj);
        }
        private int Razlika(int a,int b , int c , int d)
        {
            return (a + b) - (c + d);
        }


        // Krierati rutu zad3 koja prima ime grada i slovo.
        // Ruta vraća broj pojavljivanja slova u primljenom imenu grada
        // Koristiti metode
        [HttpGet]
        [Route("zad3")]
        public int Zad3(string ImeGrada , string Slovo)
        {
            return Brojac(ImeGrada, Slovo);
        }

        private int Brojac(string imeGrada, string slovo)
        {
            int Ukupno = 0;
            foreach (char c in imeGrada)
            {
                
                if (c == slovo[0])
                {
                    Ukupno++;

                }
            }
            return Ukupno;
            
        }
    }
}
