namespace Art2026.Models
{
    public class PromoCode
    {
        public int Id { get; set; }

        public string Code { get; set; }
        public enum Status
        {
            New,
            Used,
            Invalid
        }

        public int RegistrationId { get; set; }
        public Registration? Registration { get; set; }

        public int? UsedByRegistrationId { get; set; }
        public Registration? UsedByRegistration { get; set; }

        public DateTime? UsedAt { get; set; }
        public DateTime? InvalidatedAt { get; set; }
    }
}
