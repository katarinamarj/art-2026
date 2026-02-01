namespace Art2026.Models
{
    public class ManifestationDay
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }
        public string DayType { get; set; } 
        public string Title { get; set; }

        public int ManifestationId { get; set; }
        public Manifestation? Manifestation { get; set; }

        public List<Exhibition> Exhibitions { get; set; }
        public List<RegistrationDay> RegistrationDays { get; set; }
    }
}
