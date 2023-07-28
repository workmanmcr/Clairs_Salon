using System.Collections.Generic;
using MySqlConnector;

namespace HairSalon.Models
{
    public class Stylist
    {
        public Stylist()
        {
            this.Clients = new HashSet<Client>();
        }

        public int StylistId { get; set; }
        public string Name { get; set; }
        public string Number { get; set; }
        public virtual ICollection<Client> Clients { get; set; }

        // Update the GetAll method to fetch data from the database
        public static List<Stylist> GetAll()
        {
            List<Stylist> allStylists = new List<Stylist>();

            using (MySqlConnection conn = new MySqlConnection(DBConfiguration.ConnectionString))
            {
                conn.Open();

                string query = "SELECT * FROM stylists;";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                using (MySqlDataReader rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        int stylistId = rdr.GetInt32(0);
                        string name = rdr.GetString(1);
                        string number = rdr.GetString(2);

                        Stylist newStylist = new Stylist
                        {
                            StylistId = stylistId,
                            Name = name,
                            Number = number
                        };

                        allStylists.Add(newStylist);
                    }
                }
            }

            return allStylists;
        }
    }
}
