namespace Tax_Reminder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateContactUsModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ContactUsModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Email = c.String(),
                        Message = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ContactUsModels");
        }
    }
}
