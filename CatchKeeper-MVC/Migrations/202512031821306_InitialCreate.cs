using System;
using System.Data.Entity.Migrations;

public partial class InitialCreate : DbMigration
{
    public override void Up()
    {
        CreateTable(
            "dbo.Catches",
            c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    CatchDate = c.DateTime(nullable: false),
                    Species = c.String(nullable: false, maxLength: 50),
                    LengthInInches = c.Double(),
                    WeightInPounds = c.Double(),
                    BaitUsed = c.String(maxLength: 50),
                    LocationName = c.String(maxLength: 100),
                    Weather = c.String(maxLength: 100),
                    Technique = c.String(maxLength: 100),
                    PhotoUrl = c.String(),
                    Notes = c.String(),
                })
            .PrimaryKey(t => t.Id);
        
    }
    
    public override void Down()
    {
        DropTable("dbo.Catches");
    }
}
