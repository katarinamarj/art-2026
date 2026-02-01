namespace Art2026.Models
{
    public class Manifestation
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string City { get; set; }
        public string Location { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public string? AdditionalInfo { get; set; }

        public int MaxVisitorsPerDay { get; set; }

        public decimal PricePainting { get; set; }
        public decimal PricePhotography { get; set; }

        public DateTime DiscountEndDate { get; set; }

        public List<ManifestationDay> Days { get; set; }
    }
}
