namespace Blog.DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BlogUser",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 30),
                        Surname = c.String(nullable: false, maxLength: 30),
                        Username = c.String(nullable: false, maxLength: 20),
                        Password = c.String(nullable: false, maxLength: 15),
                        Email = c.String(nullable: false, maxLength: 50),
                        IsActive = c.Boolean(nullable: false),
                        GuidActive = c.Guid(nullable: false),
                        IsAdmin = c.Boolean(nullable: false),
                        CreatedOn = c.DateTime(nullable: false),
                        ModifiedOn = c.DateTime(nullable: false),
                        ModifiedUsername = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Comment",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Text = c.String(),
                        CreatedOn = c.DateTime(nullable: false),
                        ModifiedOn = c.DateTime(nullable: false),
                        ModifiedUsername = c.String(),
                        Content_Id = c.Int(),
                        Owner_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Content", t => t.Content_Id)
                .ForeignKey("dbo.BlogUser", t => t.Owner_Id)
                .Index(t => t.Content_Id)
                .Index(t => t.Owner_Id);
            
            CreateTable(
                "dbo.Content",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(maxLength: 50),
                        Text = c.String(),
                        IsDraft = c.Boolean(nullable: false),
                        LikeCount = c.Int(nullable: false),
                        CreatedOn = c.DateTime(nullable: false),
                        ModifiedOn = c.DateTime(nullable: false),
                        ModifiedUsername = c.String(),
                        Category_Id = c.Int(),
                        Owner_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Category", t => t.Category_Id)
                .ForeignKey("dbo.BlogUser", t => t.Owner_Id)
                .Index(t => t.Category_Id)
                .Index(t => t.Owner_Id);
            
            CreateTable(
                "dbo.Category",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 40),
                        Descreption = c.String(maxLength: 200),
                        CreatedOn = c.DateTime(nullable: false),
                        ModifiedOn = c.DateTime(nullable: false),
                        ModifiedUsername = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Images",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Location = c.String(),
                        CreatedOn = c.DateTime(nullable: false),
                        ModifiedOn = c.DateTime(nullable: false),
                        ModifiedUsername = c.String(),
                        Content_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Content", t => t.Content_Id)
                .Index(t => t.Content_Id);
            
            CreateTable(
                "dbo.Likeds",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Content_Id = c.Int(),
                        LikeUser_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Content", t => t.Content_Id)
                .ForeignKey("dbo.BlogUser", t => t.LikeUser_Id)
                .Index(t => t.Content_Id)
                .Index(t => t.LikeUser_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Comment", "Owner_Id", "dbo.BlogUser");
            DropForeignKey("dbo.Content", "Owner_Id", "dbo.BlogUser");
            DropForeignKey("dbo.Likeds", "LikeUser_Id", "dbo.BlogUser");
            DropForeignKey("dbo.Likeds", "Content_Id", "dbo.Content");
            DropForeignKey("dbo.Images", "Content_Id", "dbo.Content");
            DropForeignKey("dbo.Comment", "Content_Id", "dbo.Content");
            DropForeignKey("dbo.Content", "Category_Id", "dbo.Category");
            DropIndex("dbo.Likeds", new[] { "LikeUser_Id" });
            DropIndex("dbo.Likeds", new[] { "Content_Id" });
            DropIndex("dbo.Images", new[] { "Content_Id" });
            DropIndex("dbo.Content", new[] { "Owner_Id" });
            DropIndex("dbo.Content", new[] { "Category_Id" });
            DropIndex("dbo.Comment", new[] { "Owner_Id" });
            DropIndex("dbo.Comment", new[] { "Content_Id" });
            DropTable("dbo.Likeds");
            DropTable("dbo.Images");
            DropTable("dbo.Category");
            DropTable("dbo.Content");
            DropTable("dbo.Comment");
            DropTable("dbo.BlogUser");
        }
    }
}
