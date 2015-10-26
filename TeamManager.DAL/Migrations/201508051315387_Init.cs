namespace TeamManager.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Certifications",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 256),
                        IssuedBy = c.String(maxLength: 256),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Members",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 256),
                        LastName = c.String(nullable: false, maxLength: 256),
                        Gender = c.Int(nullable: false),
                        Bio = c.String(maxLength: 1024),
                        ProfilePicture = c.String(maxLength: 1024),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Leaves",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Reason = c.String(nullable: false, maxLength: 256),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        MemberId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Members", t => t.MemberId, cascadeDelete: true)
                .Index(t => t.MemberId);
            
            CreateTable(
                "dbo.Skills",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Teams",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MemberCertifications",
                c => new
                    {
                        Member_Id = c.Int(nullable: false),
                        Certification_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Member_Id, t.Certification_Id })
                .ForeignKey("dbo.Members", t => t.Member_Id, cascadeDelete: true)
                .ForeignKey("dbo.Certifications", t => t.Certification_Id, cascadeDelete: true)
                .Index(t => t.Member_Id)
                .Index(t => t.Certification_Id);
            
            CreateTable(
                "dbo.MemberSkills",
                c => new
                    {
                        Member_Id = c.Int(nullable: false),
                        Skill_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Member_Id, t.Skill_Id })
                .ForeignKey("dbo.Members", t => t.Member_Id, cascadeDelete: true)
                .ForeignKey("dbo.Skills", t => t.Skill_Id, cascadeDelete: true)
                .Index(t => t.Member_Id)
                .Index(t => t.Skill_Id);
            
            CreateTable(
                "dbo.TeamMembers",
                c => new
                    {
                        TeamId = c.Int(nullable: false),
                        MemberId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.TeamId, t.MemberId })
                .ForeignKey("dbo.Teams", t => t.TeamId, cascadeDelete: true)
                .ForeignKey("dbo.Members", t => t.MemberId, cascadeDelete: true)
                .Index(t => t.TeamId)
                .Index(t => t.MemberId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TeamMembers", "MemberId", "dbo.Members");
            DropForeignKey("dbo.TeamMembers", "TeamId", "dbo.Teams");
            DropForeignKey("dbo.MemberSkills", "Skill_Id", "dbo.Skills");
            DropForeignKey("dbo.MemberSkills", "Member_Id", "dbo.Members");
            DropForeignKey("dbo.Leaves", "MemberId", "dbo.Members");
            DropForeignKey("dbo.MemberCertifications", "Certification_Id", "dbo.Certifications");
            DropForeignKey("dbo.MemberCertifications", "Member_Id", "dbo.Members");
            DropIndex("dbo.TeamMembers", new[] { "MemberId" });
            DropIndex("dbo.TeamMembers", new[] { "TeamId" });
            DropIndex("dbo.MemberSkills", new[] { "Skill_Id" });
            DropIndex("dbo.MemberSkills", new[] { "Member_Id" });
            DropIndex("dbo.MemberCertifications", new[] { "Certification_Id" });
            DropIndex("dbo.MemberCertifications", new[] { "Member_Id" });
            DropIndex("dbo.Leaves", new[] { "MemberId" });
            DropTable("dbo.TeamMembers");
            DropTable("dbo.MemberSkills");
            DropTable("dbo.MemberCertifications");
            DropTable("dbo.Teams");
            DropTable("dbo.Skills");
            DropTable("dbo.Leaves");
            DropTable("dbo.Members");
            DropTable("dbo.Certifications");
        }
    }
}
