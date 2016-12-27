namespace Tax_Reminder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFieldToTaxInformationModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TaxInformationModels", "IsAgree", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.TaxInformationModels", "IsAgree");
        }
    }
}
