using System;
using System.Collections.Generic;


namespace HairSalon.Models
{
  
    public class Stylist
    {
      
       

        public string Name { get; set; }
        public int Number { get; set; }
        public int Id { get; set; }
      

        private List<Client> _clients = new List<Client> { };
        
        private static List<Stylist> _instances = new List<Stylist> { };
        

        public Stylist(string name, int number)
        {
          

            Name = name;
            Description = description;
            

            Id = _instances.Count;
         
            _instances.Add(this);
          
        }
     public static void ClearAll()
    {
      _instances.Clear();
    }
     public static List<Stylist> GetAll()
    {
      return _instances;
    } 
    public static Stylist Find(int searchId)
    {
      return _instances[searchId-1];
    }
    public void AddClient(Client order)
    {
      _orders.Add(client);
    }
     public List<Client> GetClients()
    {
      return _clients;
    }
     public int GetClientCount()
    {
      return _client.Count;
    }
      public static Stylist GetStylistWithId(int id)
    {
      foreach (Stylist stylist in _instances)
      {
        if (stylist.Id == id)
        {
          return stylist;
        }
      }
      return null;
    }
        public Client GetClientWithId(int id)
    {
      foreach (Client item in _clients)
      {
        if (item.Id == id)
        {
          return item;
        }
      }
      return null;
    }
    public static Stylist SearchStylist(string stylistSearch)
    {
      foreach (Stylist stylist in _instances)
      {
        if (stylist.Name == stylistSearch)
        {
          return stylist;
        }
      }
      return null;
    }
   
    
  }
}