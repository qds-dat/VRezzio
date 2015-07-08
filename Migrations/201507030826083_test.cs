namespace VRezzio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Account",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Email = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        Role = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.PhotoVideos",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        StudentId = c.Int(nullable: false),
                        Second = c.Int(nullable: false),
                        PhotoUrl = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Students", t => t.StudentId)
                .Index(t => t.StudentId);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        FullName = c.String(),
                        UniversityId = c.Int(nullable: false),
                        HighSchool = c.String(),
                        PhoneNunber = c.String(),
                        SATScore = c.Single(nullable: false),
                        Address = c.String(),
                        City = c.String(),
                        Introduction = c.String(),
                        Activity1 = c.String(),
                        ActivityPhoto1 = c.String(),
                        Activity2 = c.String(),
                        ActivityPhoto2 = c.String(),
                        Activity3 = c.String(),
                        ActivityPhoto3 = c.String(),
                        Conclusion = c.String(),
                        Video = c.String(),
                        Rate = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Account", t => t.UserId)
                .ForeignKey("dbo.University", t => t.UniversityId)
                .Index(t => t.UserId)
                .Index(t => t.UniversityId);
            
            CreateTable(
                "dbo.University",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        OfficePhone = c.String(nullable: false, maxLength: 20),
                        MobilePhone = c.String(nullable: false, maxLength: 20),
                        UniversityName = c.String(nullable: false, maxLength: 100),
                        Address = c.String(nullable: false, maxLength: 100),
                        PrincipalTitle = c.Int(nullable: false),
                        PrincipalFirstName = c.String(nullable: false),
                        PrincipalLastName = c.String(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        ActiveStatus = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Account", t => t.UserId)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "UniversityId", "dbo.University");
            DropForeignKey("dbo.University", "UserId", "dbo.Account");
            DropForeignKey("dbo.PhotoVideos", "StudentId", "dbo.Students");
            DropForeignKey("dbo.Students", "UserId", "dbo.Account");
            DropIndex("dbo.University", new[] { "UserId" });
            DropIndex("dbo.Students", new[] { "UniversityId" });
            DropIndex("dbo.Students", new[] { "UserId" });
            DropIndex("dbo.PhotoVideos", new[] { "StudentId" });
            DropTable("dbo.University");
            DropTable("dbo.Students");
            DropTable("dbo.PhotoVideos");
            DropTable("dbo.Account");
        }
    }
}
