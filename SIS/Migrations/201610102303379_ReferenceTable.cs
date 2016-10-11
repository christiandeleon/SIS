namespace SIS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ReferenceTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.References",
                c => new
                    {
                        id = c.Byte(nullable: false, identity: true),
                        code = c.String(maxLength: 4),
                        name = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.References");
        }
    }
}
