namespace POCINTNAARGUID.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveFkInt : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Ipsums", "LoremId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Ipsums", "LoremId", c => c.Int(nullable: false));
        }
    }
}
