namespace GiftoftheGiversFoundationApp.Models
{
    public class Donation
    {
        public int Id { get; set; }               // Unique identifier
        public string DonorName { get; set; }     // Name of the donor
        public string Item { get; set; }          // Item being donated
        public DateTime DateDonated { get; set; } // Date when the donation was made
        public int Quantity { get; set; }         // Quantity of the item donated
        // Add any other properties you may need
    }
}


