namespace MovieStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCustomerValidation : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.CustomerModels", "Birthdate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.CustomerModels", "Birthdate", c => c.DateTime());
        }
    }
}
