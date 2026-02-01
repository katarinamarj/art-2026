namespace Art2026.Models
{
    public class Exhibition
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public TimeSpan OpensAt { get; set; }
        public TimeSpan ClosesAt { get; set; }

        public string Artists { get; set; }

        public int ManifestationDayId { get; set; }
        public ManifestationDay? ManifestationDay { get; set; }
    }
}
