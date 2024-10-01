namespace GiftoftheGiversFoundationApp.Models
{
    public class AdminDashboardViewModel
    {
        public int TotalReportedDisasters { get; set; }
        public int TotalDonatedGoods { get; set; }
        public int TotalVolunteers { get; set; }

        // You can use these properties to store lists or counts related to disasters, donations, and volunteers
        public List<Disaster> Disasters { get; set; } = new List<Disaster>(); // Assuming you have a Disaster class
        public List<Donation> Donations { get; set; } = new List<Donation>(); // Assuming you have a Donation class
        public List<Volunteer> Volunteers { get; set; } = new List<Volunteer>(); // Assuming you have a Volunteer class
    }

    // Define the classes for Disaster, Donation, and Volunteer if you haven't done so

}


