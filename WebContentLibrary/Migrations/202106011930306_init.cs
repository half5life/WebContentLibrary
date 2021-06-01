namespace WebContentLibrary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        User = c.String(),
                        Title = c.String(nullable: false),
                        Description = c.String(),
                        Images = c.String(),
                        File = c.String(),
                        Tags = c.String(),
                        Extensions = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Items");
            DropTable("dbo.FileExtensions");
        }
    }
}
