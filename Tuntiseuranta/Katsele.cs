using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Tuntiseuranta
{
    class Katsele
    {
        public void TarkasteleTunteja()
        {
            using (SqlConnection c = new SqlConnection())
            {
                c.ConnectionString = "server=localhost;database=Tuntiseuranta;trusted_connection=true";

                c.Open();

                SqlCommand cmd = c.CreateCommand();

                cmd.CommandText = "select k.kayttaja_id, nimi, osasto tehtavanro, pvm, tunnit, tehtavakuvaus from Kayttaja k inner join Tunnit t on k.kayttaja_id = t.tehtavanro";

                SqlDataReader r = cmd.ExecuteReader(); Console.Write(r["k.kayttaja_id"]); Console.Write("\t");

                Console.Write(r["nimi"]); Console.Write("\t");

                Console.Write(r["osasto"]); Console.Write("\t");

                Console.Write(r["tehtavanro"]); Console.Write("\t");

                Console.Write(r["pvm"]); Console.Write("\t");

                Console.Write(r["tunnit"]); Console.Write("\t");

                Console.Write(r["tehtavakuvaus"]); Console.Write("\t");
            }
        }
    }
}
