namespace CollectibleMovieTicketDB.Model
{
    /// <summary>
    /// Represents a template for a collectible ticket
    /// </summary>
    public class CollectibleTicket
    {
        public int Id { get; set; }

        public string MovieTitle { get; set; } = "Movie Title";

        public int CollectorNumber { get; set; } = 0;

        public bool Rerelease { get; set; } = false;

        public DateOnly ShowingDate { get; set; }

        public int? Variant { get; set; }

        public int EstimatedEbaySalePrice { get; set; } = 0;

        public string ImageUrl { get; set; }
    }
}