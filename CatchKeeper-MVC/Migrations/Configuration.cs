using System;
using System.Data.Entity.Migrations;
using CatchKeeperMVC.Models;

internal sealed class Configuration : DbMigrationsConfiguration<CatchKeeperMVC.Models.CatchKeeperContext>
{
    public Configuration()
    {
        AutomaticMigrationsEnabled = false;
    }

    protected override void Seed(CatchKeeperMVC.Models.CatchKeeperContext context)
    {
        context.Catches.AddOrUpdate(c => c.Id,
            new Catch
            {
                CatchDate = new DateTime(2025, 5, 1),
                Species = "Largemouth Bass",
                LengthInInches = 18.5,
                WeightInPounds = 3.2,
                BaitUsed = "Green Pumpkin Jig",
                LocationName = "Nimisila Reservoir – Main Point",
                Weather = "Overcast, light wind",
                Technique = "Dragging jig along weed edge",
                PhotoUrl = "",
                Notes = "Crushed it on the fall near submerged timber."
            },
            new Catch
            {
                CatchDate = new DateTime(2025, 5, 3),
                Species = "Saugeye",
                LengthInInches = 21,
                WeightInPounds = 4.1,
                BaitUsed = "Chartreuse Swimbait",
                LocationName = "Atwood – Current Seam",
                Weather = "Clear evening",
                Technique = "Slow steady retrieve across seam",
                PhotoUrl = "",
                Notes = "Hit right at sunset, strong fight."
            }
        );
    }
}
