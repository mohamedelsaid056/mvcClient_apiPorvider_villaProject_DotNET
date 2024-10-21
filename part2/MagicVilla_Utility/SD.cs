namespace MagicVilla_Utility
{
    public static class SD
    {
        public enum ApiType
        {
            GET,
            POST,
            PUT,
            DELETE
        }
        public static string AccessToken = "JWTToken"; //session  token 
        public static string RefreshToken = "RefreshToken";
        public static string CurrentAPIVersion = "v2";// to make dynamic version of API in url 
        public const string Admin = "admin";
        public const string Customer = "customer";
        public enum ContentType
        {
            Json,
            MultipartFormData,// if i have image in request data i need to  replace application/json with multipart/form-data in the header 
        }
    }
}