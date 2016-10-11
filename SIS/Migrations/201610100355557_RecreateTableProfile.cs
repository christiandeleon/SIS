namespace SIS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RecreateTableProfile : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Personals", "DateCreated", c => c.DateTime(defaultValue: DateTime.Now));
            AlterColumn("dbo.Personals", "DateUpdated", c => c.DateTime(defaultValue: DateTime.Now));
        }
        
        public override void Down()
        {
        }
    }
}
