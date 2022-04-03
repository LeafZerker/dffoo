using Microsoft.AspNetCore.Identity;

namespace dffoo.Shared
{
    public class User
    {
        public string Username { get; set; } = string.Empty;
        [PersonalData]
        public string Name { get; set; } = string.Empty;
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; } 
    }
}
