namespace Art2026.Models
{
    public class RegistrationDay
    {
        public int RegistrationId { get; set; }
        public Registration? Registration { get; set; }

        public int ManifestationDayId { get; set; }
        public ManifestationDay? ManifestationDay { get; set; }
    }
}
