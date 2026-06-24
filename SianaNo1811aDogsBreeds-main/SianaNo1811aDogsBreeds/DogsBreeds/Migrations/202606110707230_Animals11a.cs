namespace DogsBreeds.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Animals11a : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Breeds",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Dogs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.Int(nullable: false),
                        Age = c.Int(nullable: false),
                        BreedID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Breeds", t => t.BreedID, cascadeDelete: true)
                .Index(t => t.BreedID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Dogs", "BreedID", "dbo.Breeds");
            DropIndex("dbo.Dogs", new[] { "BreedID" });
            DropTable("dbo.Dogs");
            DropTable("dbo.Breeds");
        }
    }
}
