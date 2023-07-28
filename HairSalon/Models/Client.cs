
namespace HairSalon.Models
{
  public class Client
  {
    public int ClientId { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public string Number { get; set; }
    public string Email { get; set; }
    public string ReferredBy { get; set; }
    public int StylistId { get; set; }
    
    public virtual Stylist Stylist { get; set; }
  }
}