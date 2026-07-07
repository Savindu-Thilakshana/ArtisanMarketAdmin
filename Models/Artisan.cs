using Microsoft.VisualBasic.ApplicationServices;

namespace ArtisanMarketAdmin.Models
{
    public class Artisan : User
    {
        public int ArtisanId { get; set; }

        public Artisan(int artisanId, string name, string email, string contact, string status)
            : base(name, email, contact, status)
        {
            ArtisanId = artisanId;
        }
    }
}