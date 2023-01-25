using CollectibleMovieTicketDB.Model;

namespace CollectibleMovieTicketDB.Data;

public static class SeedData
{
    public static void Initialize(CmtdbContext db)
    {
        var tickets = new CollectibleTicket[]
        {
            new CollectibleTicket {
                MovieTitle = "Avatar: The Way of Water",
                Rerelease = false,
                CollectorNumber = 85,
                ShowingDate = new DateTime(2022, 12, 14),
                Variant = 1,
                EstimatedEbaySalePrice = 100,
                ImageUrl = "images/tickets/Avatar-The-Way-of-Water_1.jpg"
            },
            new CollectibleTicket {
                MovieTitle = "Avatar: The Way of Water",
                Rerelease = false,
                CollectorNumber = 85,
                ShowingDate = new DateTime(2022, 12, 14),
                Variant = 2,
                EstimatedEbaySalePrice = 100,
                ImageUrl = "images/tickets/Avatar-The-Way-of-Water_2.jpg"
            },
            new CollectibleTicket {
                MovieTitle = "Birds of Prey",
                Rerelease = false,
                CollectorNumber = 14,
                ShowingDate = new DateTime(2020, 02, 05),
                Variant = 1,
                EstimatedEbaySalePrice = 80,
                ImageUrl = "images/tickets/Birds-of-Prey-Harley-Quinn_1.jpg"
            },
            new CollectibleTicket {
                MovieTitle = "Birds of Prey",
                Rerelease = false,
                CollectorNumber = 14,
                ShowingDate = new DateTime(2020, 02, 05),
                Variant = 2,
                EstimatedEbaySalePrice = 80,
                ImageUrl = "images/tickets/Birds-of-Prey-Harley-Quinn_2.jpg"
            },
            new CollectibleTicket {
                MovieTitle = "Tenet",
                Rerelease = false,
                CollectorNumber = 19,
                ShowingDate = new DateTime(2020, 08, 26),
                Variant = 1,
                EstimatedEbaySalePrice = 60,
                ImageUrl = "images/tickets/Tenet_1.jpg"
            },
            new CollectibleTicket {
                MovieTitle = "Tenet",
                Rerelease = false,
                CollectorNumber = 19,
                ShowingDate = new DateTime(2020, 08, 26),
                Variant = 2,
                EstimatedEbaySalePrice = 60,
                ImageUrl = "images/tickets/Tenet_2.jpg"
            },
            new CollectibleTicket {
                MovieTitle = "The Batman",
                Rerelease = false,
                CollectorNumber = 48,
                ShowingDate = new DateTime(2022, 03, 01),
                Variant = 1,
                EstimatedEbaySalePrice = 100,
                ImageUrl = "images/tickets/The-Batman_1.jpg"
            },
            new CollectibleTicket {
                MovieTitle = "The Batman",
                Rerelease = false,
                CollectorNumber = 48,
                ShowingDate = new DateTime(2022, 03, 01),
                Variant = 2,
                EstimatedEbaySalePrice = 100,
                ImageUrl = "images/tickets/The-Batman_2.jpg"
            },
            new CollectibleTicket {
                MovieTitle = "Thor: Love and Thunder",
                Rerelease = false,
                CollectorNumber = 57,
                ShowingDate = new DateTime(2022, 07, 06),
                Variant = 1,
                EstimatedEbaySalePrice = 90,
                ImageUrl = "images/tickets/Thor-Love-and-Thunder_1.jpg"
            },
            new CollectibleTicket {
                MovieTitle = "Thor: Love and Thunder",
                Rerelease = false,
                CollectorNumber = 57,
                ShowingDate = new DateTime(2022, 07, 06),
                Variant = 2,
                EstimatedEbaySalePrice = 90,
                ImageUrl = "images/tickets/Thor-Love-and-Thunder_2.jpg"
            },
            new CollectibleTicket {
                MovieTitle = "Your Name",
                Rerelease = true,
                CollectorNumber = 7,
                ShowingDate = new DateTime(2021, 09, 09),
                EstimatedEbaySalePrice = 120,
                ImageUrl = "images/tickets/Your-Name.jpg"
            }
        };
        db.CollectibleTickets.AddRange(tickets);
        db.SaveChanges();
    }
}