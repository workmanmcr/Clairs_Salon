using System.Collections.Generic;

namespace HairSalon.Models
{
    public class Client
    {
      
       
        
       
        public string ClientName { get; set; }
        public int Number { get; set; }
        public int Id { get; }
        private static List<Client> _instances = new List<Client> { };
        private static int _idCounter = 1;

        public Client( string clientName, int number, int id)
        {
           
            ClientName = clientName;
            Number = number;
            Id = _idCounter;
            _idCounter++;
            _instances.Add(this);
        }

        public static List<Client> GetAll()
        {
            return _instances;
        }

        public static void ClearAll()
        {
            _instances.Clear();
            _idCounter = 1; 
        }
    }
}