using System.ComponentModel.DataAnnotations;

namespace GiftoftheGiversFoundationApp.Models
{
    public class NewsletterSignup
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
    public class DisasterReport
    {
        public int Id { get; set; }
        public string IncidentType { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public string Photo { get; set; }

        // New Properties
        public string Province { get; set; }
        public string City { get; set; }
        public string StreetName { get; set; }
    }

    public class ErrorViewModel
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
