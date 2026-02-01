namespace Art2026.Models
{
    public class Registration
    {
        public int Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? Profession { get; set; }

        public string Address1 { get; set; }
        public string? Address2 { get; set; }

        public string PostalCode { get; set; }
        public string Place { get; set; }
        public string Country { get; set; }

        public string Email { get; set; }
        public bool EmailConfirmed { get; set; }

        public int NumberOfPersons { get; set; }

        public string AccessToken { get; set; }
        public DateTime CreatedAt { get; set; }

        public enum Status
        {
            Active,
            Cancelled
        }

        public int? UsedPromoCodeId { get; set; }
        public PromoCode? UsedPromoCode { get; set; }

        public List<RegistrationDay> RegistrationDays { get; set; }
        public PromoCode? GeneratedPromoCode { get; set; }
    }
}
