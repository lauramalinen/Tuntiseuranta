using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuntiseuranta
{
    class Kayttaja
    {
        public void LisaaKayttaja()
        {
            Console.WriteLine("Lisää nimi: (etunimi sukunimi) ");
            string nimi = Console.ReadLine();

            Console.WriteLine("Lisää osasto: ");
            string osasto = Console.ReadLine();

            Console.WriteLine("Lisää tehtävänimike: ");
            string tehtavanimike = Console.ReadLine();



        }
    }
}
