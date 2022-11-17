using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace phasmo
{
    class DaneZbazy
    {
        private SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["baza"].ConnectionString.ToString());
       
        public List<string> wczytajnazwy()
        {
            List<string> nazwa = new List<string>();
            conn.Open();
            var query = new SqlCommand("SELECT Nazwa FROM Duchy",conn);
            SqlDataReader reader;
            reader = query.ExecuteReader();

            while (reader.Read())
            {
                nazwa.Add(reader["Nazwa"].ToString());
            }

            conn.Close();
            return nazwa;
        }

        public List<Dane> szukaj_poDowodach(List<string>dowody)
        {
            List<Dane> duchy=new List<Dane>();
            string kwerenda="";
            if (dowody.Count == 1)
                kwerenda = $"SELECT Nazwa,Dowody FROM Duchy WHERE Dowody LIKE '%{dowody[0]}%'";
            else if (dowody.Count == 2)
            {
                kwerenda = $"SELECT Nazwa,Dowody FROM Duchy WHERE Dowody LIKE '%{dowody[0]}%' AND Dowody LIKE '%{dowody[1]}%'";
            }
            else if(dowody.Count==3)
            {
                kwerenda = $"SELECT Nazwa,Dowody FROM Duchy WHERE Dowody LIKE '%{dowody[0]}%' AND Dowody LIKE '%{dowody[1]}%' AND Dowody LIKE '%{dowody[2]}%'";
            }
            else
            {
                kwerenda = "SELECT Nazwa,Dowody FROM Duchy";
            }
            conn.Open();
            var query = new SqlCommand(kwerenda, conn);
            SqlDataReader reader;
            reader = query.ExecuteReader();
            while (reader.Read())
            {
                duchy.Add(new Dane
                {
                    nazwa = reader["Nazwa"].ToString(),
                    dowody = reader["Dowody"].ToString()
                });
            }
            conn.Close();
            return duchy;
        }
        public List<Dane> szukaj_poNazwie(string nazwa)
        {
            List<Dane> dane = new List<Dane>();
            conn.Open();
            var query = new SqlCommand($"SELECT Nazwa,Dowody,Opis,Slabosc,Moc FROM Duchy WHERE Nazwa LIKE '{nazwa}'", conn);
            SqlDataReader reader;
            reader = query.ExecuteReader();

            while (reader.Read())
            {
                dane.Add(new Dane
                {
                    nazwa = reader["Nazwa"].ToString(),
                    opis = reader["Opis"].ToString(),
                    moce = reader["Moc"].ToString(),
                    slabosc = reader["Slabosc"].ToString(),
                    dowody = reader["Dowody"].ToString()
                });
                
            }
            conn.Close();
            return dane;
        }

    }
}
