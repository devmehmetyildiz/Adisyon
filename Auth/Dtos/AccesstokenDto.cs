namespace Auth.Dtos
{
    public class AccesstokenDto
    {
        public string UserID { get; set; }
        public string Accesstoken { get; set; }
        public string Refreshtoken { get; set; }
        public DateTime Expiretime { get; set; }
    }
}
