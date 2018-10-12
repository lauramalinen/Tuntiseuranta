using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;

namespace Tuntiseuranta
{
    class Program
    {
        static void Main(string[] args)
        {
        Start:
            Console.WriteLine(@"Tervetuloa! Mit‰ haluat tehd‰?
            A  Lis‰‰ uusi k‰ytt‰j‰
            B  Lis‰‰ uusi tuntikirjaus
            C  Tarkastele tuntikirjauksia");
            string vastaus = Console.ReadLine();
            vastaus = vastaus.ToUpper();
            switch (vastaus)
            {
                case "A":
                    Kayttaja kayttaja = new Kayttaja();
                    kayttaja.LisaaKayttaja();
                    break;

                case "B":
                    Tehtava tehtava = new Tehtava();
                    tehtava.LisaaTehtava();
                    break;

                //case "C":
                //    Katsele katsele = new Katsele();
                //    katsele.TarkasteleTunteja();
                //    break;

                //default:
                //    Console.WriteLine("Virheellinen valinta. Tee valinta uudelleen.");
                //    break;

                case "TAULUKOT":
                Taulukot taulukot = new Taulukot();
                taulukot.PaivitaTaulukot();
                break;
            default:
                Console.WriteLine("Ep‰kelpo valinta! Kokeilehan uudelleen.");
            goto Start;

            }
            Console.ReadLine();
        }
    }
}
