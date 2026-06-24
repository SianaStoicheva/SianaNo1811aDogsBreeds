using static System.Data.Entity.Infrastructure.Design.Executor;

namespace DogsBreeds.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Animals",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Age = c.Int(nullable: false),
                        BreedID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Breeds", t => t.BreedID, cascadeDelete: true)
                .Index(t => t.BreedID);
            
            CreateTable(
                "dbo.Breeds",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Animals", "BreedID", "dbo.Breeds");
            DropIndex("dbo.Animals", new[] { "BreedID" });
            DropTable("dbo.Breeds");
            DropTable("dbo.Animals");
        }
    }
}
