namespace CollectibleMovieTicketDB.Model
{
    /// <summary>
    /// Represents a template for a collectible ticket
    /// </summary>
    public class CollectibleTicket
    {
        public int Id { get; set; }

        public string MovieTitle { get; set; }

        public int CollectorNumber { get; set; }

        public bool Rerelease { get; set; }

        public string ShowingDate { get; set; }

        public int? Variant { get; set; }

        public int EstimatedEbaySalePrice { get; set; }

        public string ImageUrl { get; set; }
    }
}