using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dffoo.Shared
{
    public class User
    {
        public string Username { get; set; } = string.Empty;
        [PersonalData]
        [Key]
        public string Email { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public byte[] PasswordHash { get; set; } = new byte[32];
        public byte[] PasswordSalt { get; set; } = new byte[32];
        public DateTime birthday { get; set; } = DateTime.Today;
    }
}
