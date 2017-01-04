namespace Tax_Reminder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDiscDesignModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DiscDesignModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        VehicleName = c.String(),
                        TaxDateTime = c.DateTime(nullable: false),
                        MotDateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.DiscDesignModels");
        }
    }
}
