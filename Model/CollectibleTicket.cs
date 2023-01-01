namespace CollectibleMovieTicketDB.Model
{
    /// <summary>
    /// Represents a template for a collectible ticket
    /// </summary>
    public class CollectibleTicket
    {
        public int Id { get; set; }

        public string MovieTitle { get; set; }

        public string CollectorNumber { get; set; }

        public string ReleaseDate { get; set; }

        public string Variation { get; set; }

        public double EstimatedEbaySalePrice { get; set; }

        public string ImageUrl { get; set; }
    }
}