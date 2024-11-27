using System.ComponentModel.DataAnnotations;

namespace MagicVilla_VillaAPI.Models
{
    public class RefreshToken
    {
        [Key]
        public int Id { get; set; }
        public string UserId { get; set; }
        public string JwtTokenId { get; set; }
        public string Refresh_Token { get; set; }
        //We will make sure the refresh token is only valid for one use

        // i can make this 
        // public bool IsExpired => DateTime.UtcNow >= ExpiresAt;
        public bool IsValid { get; set; }
        public DateTime ExpiresAt { get; set; }

        //  IsActive
        //public bool IsActive => !IsExpired && invoked is null ;
    }
}
