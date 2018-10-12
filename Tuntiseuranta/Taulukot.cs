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
            Console.WriteLine("B: Pyyhi taulukot, päivitä Auto-identity");
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
                        c.ConnectionString = "server=localhost;database=tuntiseuranta;trusted_connection=true";
                        c.Open();
                        SqlCommand a1 = c.CreateCommand();
                        a1.CommandText = $"DROP TABLE Kayttaja";
                        SqlCommand a2 = c.CreateCommand();
                        a2.CommandText = $"DROP TABLE Tunnit";
                        a2.ExecuteNonQuery();
                        a1.ExecuteNonQuery();

                        SqlCommand cmd = c.CreateCommand();
                        cmd.CommandText = $"create table kayttaja (kayttaja_id int identity(1,1) primary key, nimi varchar(50) not null, osasto varchar(50), tehtavanimike varchar(50));";
                        cmd.ExecuteNonQuery();

                        SqlCommand cmd2 = c.CreateCommand();
                        cmd2.CommandText = $"create table tunnit (tehtavanro int identity(1,1) primary key, kayttaja_id int not null, pvm int not null, tunnit decimal(4,2) not null, tehtavakuvaus varchar(255), laskutettava int not null);";
                        cmd2.ExecuteNonQuery();

                        SqlCommand c3 = c.CreateCommand();
                        c3.CommandText = $"ALTER TABLE Tunnit ADD FOREIGN KEY(kayttaja_id) REFERENCES Kayttaja(kayttaja_id);";
                        c3.ExecuteNonQuery();
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
