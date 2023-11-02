using System.ComponentModel.DataAnnotations;
using Portfolio.Data;

namespace Portfolio.Authentication
{
    public class UserSession
    {
        public int SessionId { get; set; }
        public string Username { get; set; }
        public string Role { get; set; }
        public DateTime Login { get; set; } = DateTime.Now;
    }
}
