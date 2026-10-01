namespace FinanceApp.DTOs.User
{
    public class UserRegisterDto
    {
        public required string Name { get; set; }
        public required string UserName { get; set; }
        public required string Password { get; set; }
    }
}
