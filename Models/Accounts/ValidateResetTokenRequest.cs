using System.ComponentModel.DataAnnotations;

namespace WorCout_API.Models.Accounts
{
    public class ValidateResetTokenRequest
    {
        [Required]
        public string Token { get; set; }
    }
}