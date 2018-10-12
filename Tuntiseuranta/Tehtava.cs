using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuntiseuranta
{
    class Tehtava
    {
        public void LisaaTehtava()
        {
            try
            {
                Console.WriteLine("Anna työntekijä-ID: ");
                int id = int.Parse(Console.ReadLine());

                Console.WriteLine("Lisää päivämäärä (YYYYMMDD): ");
                int pvm = int.Parse(Console.ReadLine());

                Console.WriteLine("Lisää tehdyt tunnit: ");
                int tunnit = int.Parse(Console.ReadLine());

                Console.WriteLine("Anna Tehtävän kuvaus: ");
                string tehtava = Console.ReadLine();

                Console.WriteLine("Onko laskutettava? (K=1, E=0): ");
                int laskutettava = int.Parse(Console.ReadLine());


                using (SqlConnection c = new SqlConnection())
                {
                    c.ConnectionString = "server=localhost;database=Tuntiseuranta;trusted_connection=true";
                    c.Open();
                    SqlCommand k1 = c.CreateCommand();
                    k1.CommandText = $"insert into Tunnit (kayttaja_id, pvm, tunnit, tehtavakuvaus, laskutettava) values({id}, {pvm}, {tunnit}, '{tehtava}', {laskutettava})";

                    k1.ExecuteNonQuery();
                }

                Console.WriteLine("Kiitos!");
            }
            catch
            {
                Console.WriteLine("Joku meni pieleen!\nKokeile uudestaan? K/E");
                string vastaus = Console.ReadLine();
                vastaus = vastaus.ToUpper();
                switch (vastaus)
                {
                    case "K":
                        LisaaTehtava();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
