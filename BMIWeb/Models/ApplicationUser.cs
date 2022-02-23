namespace BMIWeb.Models
{
    public class ApplicationUser : Microsoft.AspNetCore.Identity.IdentityUser
    {
        public string Lastname { get; set; }
        public string Firstname { get; set; }
        public virtual ICollection<Measurement> Measurements { get; set; }
    }
}