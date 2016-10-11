namespace SIS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdataReferenceType : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.References", "type", c => c.String(maxLength: 10));
        }
        
        public override void Down()
        {
            DropColumn("dbo.References", "type");
        }
    }
}
