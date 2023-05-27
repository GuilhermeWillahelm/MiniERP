namespace MiniERP.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? LastName { get; set; }
        public string? CPF { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? Street { get; set; }
        public string? District { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public int AccessLevel { get; set; }
        public string? Situation { get; set; }
        public DateTime RegistrationDate { get; set; }
    }
}
