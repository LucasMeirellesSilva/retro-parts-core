namespace RetroPecasAPI.Domain.Entities;

public sealed class MarketplaceListingOffer
{
    {
        public int Id { get; set; }

        public int MarketplaceListingId { get; set; }
        
        public decimal OriginalPrice { get; set; }

        public decimal OfferPrice { get; set; }

        public DateTime StartsAt { get; set; }
        
        public DateTime EndsAt { get; set; }
    }
}
