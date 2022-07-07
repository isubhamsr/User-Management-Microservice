using System.Text.Json;
using System.Text.Json.Serialization;
namespace User_Management_Microservice.Model

{
    public class AppUser
    {
        public int Id { get;set; }
        
        public string? Name { get;set; }

    
        public string? Email { get; set; }
        public long Mobile { get; set; }
        public DateTime  Registrationdate { get; set; } = DateTime.Now;
        public  string? Password { get; set; }
            
        }
    }

