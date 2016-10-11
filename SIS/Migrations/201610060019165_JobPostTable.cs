namespace SIS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class JobPostTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.JobPost",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        JobCode = c.String(nullable: false, maxLength: 5),
                        JobName = c.String(nullable: false, maxLength: 50),
                        Status = c.String(maxLength: 4),
                        UserId = c.Int(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                        DateUpdated = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.JobPosts");
        }
    }
}
