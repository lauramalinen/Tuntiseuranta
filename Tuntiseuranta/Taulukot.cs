using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuntiseuranta
{
    class Taulukot
    {
        public void PaivitaTaulukot()
        {
            Console.WriteLine("Valitse toiminto");
            Console.WriteLine("A: Päivitä primary ja secondary keyt");
            string vastaus = Console.ReadLine();
            vastaus = vastaus.ToUpper();
            switch (vastaus)
            {
                case "A":
                    using (SqlConnection c = new SqlConnection())
                    {
                        c.ConnectionString = "server=localhost;database=Tuntiseuranta;trusted_connection=true";
                        c.Open();
                        SqlCommand a1 = c.CreateCommand();
                        a1.CommandText = $"ALTER TABLE Kayttaja ALTER COLUMN kayttaja_id int NOT NULL";
                        SqlCommand a2 = c.CreateCommand();
                        a2.CommandText = $"ALTER TABLE Tunnit ALTER COLUMN tehtavanro int NOT NULL";
                        SqlCommand c1 = c.CreateCommand();
                        c1.CommandText = $"ALTER TABLE Kayttaja ADD PRIMARY KEY (kayttaja_id);";
                        SqlCommand c2 = c.CreateCommand();
                        c2.CommandText = $"ALTER TABLE Tunnit ADD PRIMARY KEY (tehtavanro);";
                        SqlCommand c3 = c.CreateCommand();
                        c3.CommandText = $"ALTER TABLE Tunnit ADD FOREIGN KEY(kayttaja_id) REFERENCES Kayttaja(kayttaja_id);";
                        a1.ExecuteNonQuery();
                        a2.ExecuteNonQuery();
                        c1.ExecuteNonQuery();
                        c2.ExecuteNonQuery();
                        c3.ExecuteNonQuery();
                    }
                break;
                case "B":
                    using (SqlConnection c = new SqlConnection())
                    {
                        c.ConnectionString = "server=localhost;database=Tuntiseuranta;trusted_connection=true";
                        c.Open();
                        SqlCommand a1 = c.CreateCommand();
                        a1.CommandText = $"ALTER TABLE Kayttaja ALTER COLUMN kayttaja_id int NOT NULL";
                        SqlCommand a2 = c.CreateCommand();
                        a2.CommandText = $"ALTER TABLE Tunnit ALTER COLUMN tehtavanro int NOT NULL";
                    }
                        break;
                default:
                    Console.WriteLine("Epäkelpo valinta!");
                    PaivitaTaulukot();
                    break;
            }
            Console.WriteLine("OK!");
        }
    }
}
