namespace Kyh_Annons.Dtos
{
    public class UserDTO
    {
        
        public string UserName { get; set; } = string.Empty;
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }


    }
}
