using Microsoft.VisualBasic.ApplicationServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ArtisanMarketAdmin.Models
{
    
    public class PendingArtisan : User
    {
        public int ArtisanId { get; set; }
        public string ApprovalStatus { get; private set; }

        public PendingArtisan(int artisanId, string name, string email, string contact)
            : base(name, email, contact, status: "Pending")
        {
            ArtisanId = artisanId;
            ApprovalStatus = "Pending";
        }
   
        public void Approve()
        {
            ApprovalStatus = "Approved";
            Status = "Active";
        }

        public void Reject()
        {
            ApprovalStatus = "Rejected";
            Status = "Rejected";
        }
        public string GetCurrentStatus() => Status;
    }
}