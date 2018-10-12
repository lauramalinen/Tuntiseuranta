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
            Console.WriteLine("Tervetuloa!\nMitä haluat tehdä?");
            Console.ReadLine();

            using (SqlConnection c = new SqlConnection())
            {
                //c.ConnectionString = "server=localhost;database=Tuntiseuranta;trusted_connection=true";
                //c.Open();
                //SqlCommand cmd = c.CreateCommand();
                //cmd.CommandText = $"create table Kayttaja (kayttaja_id int, nimi varchar(50), osasto varchar(50), tehtavanimike varchar(50));";
                //cmd.ExecuteNonQuery();

                //SqlCommand cmd2 = c.CreateCommand();
                //cmd2.CommandText = $"create table Tunnit (tehtavanro int, kayttaja_id int, pvm date, tunnit decimal(4,2), tehtavakuvaus varchar(255), laskutettava int);";
                //cmd2.ExecuteNonQuery();

                //Kommentti
            }
        }
    }
}
