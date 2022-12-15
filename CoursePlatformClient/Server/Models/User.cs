namespace CoursePlatformClient.Server.Models
{
    public class User : BaseEntity
    {
        public int Id { get; set; }
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }
}
