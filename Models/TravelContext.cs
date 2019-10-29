using Microsoft.EntityFrameworkCore;

namespace ApiExploration.Models
{
    public class TravelContext : DbContext
    {
        public TravelContext(DbContextOptions<TravelContext> options)
            : base(options)
        {
        }

        public DbSet<Destination> Destinations { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
            {
                builder.Entity<Destination>()
                .HasData(
                new Destination { DestinationId = 2, City = "Oakland", Country = "USA", Review = "Sunny, mild, rough", Rating = 2 },
                new Destination { DestinationId = 3, City = "Sayulita", Country = "Mexico", Review = "Crowded and touristy, but still beautiful and warm.", Rating = 4 },
                new Destination { DestinationId = 4, City = "Santiago", Country = "Chile", Review = "Busy, a little smoggy, gorgeous mountains", Rating = 3 },
                new Destination { DestinationId = 5, City = "Lagos", Country = "Nigeria", Review = "Vast, expansive", Rating = 3 },
                new Destination { DestinationId = 6, City = "Cairo", Country = "Eqypt", Review = "So many incredible places to visit", Rating = 5 },
                new Destination { DestinationId = 7, City = "Bangkok", Country = "Thailand", Review = "Humid, noisy, delicious food", Rating = 4 },
                new Destination { DestinationId = 8, City = "Tokyo", Country = "Japan", Review = "Bright, bustling, exciting", Rating = 5 },
                new Destination { DestinationId = 9, City = "Berlin", Country = "Germany", Review = "Excellent vegetarian options", Rating = 4 },
                new Destination { DestinationId = 10, City = "Ashgabat", Country = "Turkmenistan", Review = "Dry, drought, rough", Rating = 2 },
                new Destination { DestinationId = 11, City = "Antananarivo", Country = "Madagascar", Review = "High crime, politically unstable", Rating = 2 },
                new Destination { DestinationId = 12, City = "Brazzaville", Country = "Congo", Review = "Beautiful but corrupt", Rating = 2 },
                new Destination { DestinationId = 13, City = "Melbourne", Country = "Australia", Review = "Gorgeous with fantastic food", Rating = 4 },
                new Destination { DestinationId = 14, City = "Chicago", Country = "USA", Review = "Windy, great pizza", Rating = 4 },
                new Destination { DestinationId = 15, City = "Vancouver", Country = "Canada", Review = "Diverse, denim", Rating = 3 },
                new Destination { DestinationId = 16, City = "Glasgow", Country = "Scotland", Review = "Bland food, gorgeous nature", Rating = 3 },
                new Destination { DestinationId = 17, City = "Mexico City", Country = "Mexico", Review = "Bustling, bright, crowded", Rating = 4 },
                new Destination { DestinationId = 18, City = "Male", Country = "Maldives", Review = "Tropical, prone to flooding", Rating = 3 },
                new Destination { DestinationId = 19, City = "Frankfurt", Country = "Germany", Review = "Sausages everywhere", Rating = 4 },
                new Destination { DestinationId = 20, City = "Sao Paulo", Country = "Brazil", Review = "Big. Good nightlife", Rating = 3 },
                new Destination { DestinationId = 21, City = "Guadalajara", Country = "Mexico", Review = "Lots of markets, great food, good weather", Rating = 4 },
                new Destination { DestinationId = 22, City = "Puerto Vallarta", Country = "Mexico", Review = "Beaches, resorts", Rating = 3 },
                new Destination { DestinationId = 23, City = "Munich", Country = "Germany", Review = "Laderhosen", Rating = 3 },
                new Destination { DestinationId = 24, City = "Shanghai", Country = "China", Review = "Insanely crowded, spicy food", Rating = 3 },
                new Destination { DestinationId = 25, City = "Xi'an", Country = "China", Review = "Crowded", Rating = 2 },
                new Destination { DestinationId = 26, City = "Kyoto", Country = "Japan", Review = "Cherry blossoms, temples, beautiful", Rating = 5 },
                new Destination { DestinationId = 27, City = "Valletta", Country = "Malta", Review = "Cool", Rating = 3 },
                new Destination { DestinationId = 28, City = "Juneau", Country = "USA", Review = "The most beautiful place, ever", Rating = 5 },
                new Destination { DestinationId = 29, City = "Inn Wa", Country = "Burma", Review = "Great food", Rating = 4 },
                new Destination { DestinationId = 30, City = "Kiev", Country = "Ukraine", Review = "Violent, dangerous, terrible", Rating = 1 },
                new Destination { DestinationId = 31, City = "Kingston", Country = "Jamaica", Review = "Mellow, warm, colorful, crowded", Rating = 4 },
                new Destination { DestinationId = 32, City = "Ocho Rios", Country = "Jamaica", Review = "Humid, lively", Rating = 3 },
                new Destination { DestinationId = 33, City = "Limon", Country = "Costa Rica", Review = "Beautiful", Rating = 5 },
                new Destination { DestinationId = 34, City = "San Jose", Country = "Costa Rica", Review = "Lots of people, lots to do", Rating = 1 },
                new Destination { DestinationId = 35, City = "Iquique", Country = "Chile", Review = "Tons of buildings", Rating = 3 },
                new Destination { DestinationId = 36, City = "Pucon", Country = "Chile", Review = "Big mountain", Rating = 2 },
                new Destination { DestinationId = 37, City = "Valparaiso", Country = "Chile", Review = "Beach", Rating = 3 },
                new Destination { DestinationId = 38, City = "Osaka", Country = "Japan", Review = "Cold. So cold", Rating = 2 },
                new Destination { DestinationId = 39, City = "Odesa", Country = "Ukraine", Review = "A little scary. Old and cold", Rating = 2 },
                new Destination { DestinationId = 40, City = "Gothenburg", Country = "Sweden", Review = "Nice bridge", Rating = 4 },
                new Destination { DestinationId = 41, City = "Stockholm", Country = "Sweden", Review = "Expensive and snowy", Rating = 1 },
                new Destination { DestinationId = 42, City = "Kathmandu", Country = "Nepal", Review = "Temples, spiritual", Rating = 5 },
                new Destination { DestinationId = 43, City = "Pokhara", Country = "Nepal", Review = "Expansive natural views", Rating = 4 },
                new Destination { DestinationId = 44, City = "Batman", Country = "Turkey", Review = "Great Bruce Wayne", Rating = 3 },
                new Destination { DestinationId = 45, City = "Istanbul", Country = "Turkey", Review = "Historic, lots of sights to see", Rating = 2 },
                new Destination { DestinationId = 46, City = "Ulaanbaatar", Country = "Mongolia", Review = "Most colorful flag", Rating = 3 },
                new Destination { DestinationId = 47, City = "St Petersburg", Country = "Russia", Review = "Stark. Cold", Rating = 3 },
                new Destination { DestinationId = 48, City = "Moscow", Country = "Russia", Review = "Vast", Rating = 2 },
                new Destination { DestinationId = 49, City = "Kazan", Country = "Russia", Review = "Blue Skies", Rating = 5 },
                new Destination { DestinationId = 50, City = "Tulum", Country = "Mexico", Review = "Beaches, caves to explore", Rating = 5 }
                );
            }
    }
}