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
        class Kayttaja
        {
            public void LisaaTehtava()
            {
                Console.WriteLine("Anna työntekijä-ID: ");
                string id = Console.ReadLine();

                Console.WriteLine("Lisää päivämäärä (YYYY-MM-DD): ");
                DateTime pvm = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("Lisää tehdyt tunnit: ");
                int tunnit = int.Parse(Console.ReadLine());

                Console.WriteLine("Anna Tehtävän kuvaus: ");
                string tehtava = Console.ReadLine();

                Console.WriteLine("Onko laskutettava? (K=1, E=0): ");
                int laskutettava = int.Parse(Console.ReadLine());


                //using (SqlConnection c = new SqlConnection())
                //{
                //    c.ConnectionString = "server=localhost;database=Tuntiseuranta;trusted_connection=true";
                //    c.Open();
                //    SqlCommand k1 = c.CreateCommand();
                //    k1.CommandText = $"insert into Kayttaja values({nimi}, {osasto}, {tehtavanimike}";

                //    k1.ExecuteNonQuery();


                //}
            }
        }
    }
}
