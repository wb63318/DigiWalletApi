using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace DigiWalletApi.Models
{
    public class User:IdentityUser<Guid>
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public DateTime DateOfBirth { get; set; }

        [Phone]
        public string PhoneNumber { get; set; } = string.Empty;

        public ICollection<Wallet> Wallets { get; set; }
    }
}
