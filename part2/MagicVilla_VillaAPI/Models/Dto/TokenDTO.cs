namespace MagicVilla_VillaAPI.Models.Dto
{
    // this is logindDTO 
    public class TokenDTO
    {
        //  i can inclued this property public UserDTO user { get; set; }  
        // but i need to send only the token 
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
    }
}
