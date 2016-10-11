namespace SIS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PersonalTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Personals",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        empId = c.Int(nullable: false),
                        appId = c.Int(nullable: false),
                        title = c.String(maxLength: 4),
                        firstName = c.String(nullable: false, maxLength: 30),
                        lastName = c.String(nullable: false, maxLength: 30),
                        gender = c.String(maxLength: 3),
                        birthDate = c.DateTime(),
                        contactNo = c.String(maxLength: 12),
                        email = c.String(maxLength: 40),
                        street = c.String(maxLength: 30),
                        suburb = c.String(maxLength: 30),
                        state = c.String(maxLength: 30),
                        postCode = c.String(maxLength: 4),
                        kinName = c.String(maxLength: 50),
                        kinRelationship = c.String(maxLength: 30),
                        kinContactNo = c.String(maxLength: 12),
                        userId = c.Int(nullable: false),
                        dateCreated = c.DateTime(nullable: false),
                        dateUpdated = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Personals");
        }
    }
}
