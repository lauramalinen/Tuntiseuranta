using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

            using (SqlConnection c = new SqlConnection())
            {
                c.ConnectionString = "server=localhost;database=Tuntiseuranta;trusted_connection=true";
                c.Open();
                SqlCommand k1 = c.CreateCommand();
                k1.CommandText = $"insert into Kayttaja values({nimi}, {osasto}, {tehtavanimike}";

                k1.ExecuteNonQuery();


            }
        }
    }
}
