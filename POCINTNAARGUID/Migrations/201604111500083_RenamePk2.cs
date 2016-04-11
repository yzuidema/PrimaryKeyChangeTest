namespace POCINTNAARGUID.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenamePk2 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Lorems", name: "UniqueIdentifier", newName: "Id");
        }

        public override void Down()
        {
            RenameColumn(table: "dbo.Lorems", name: "Id", newName: "UniqueIdentifier");

        }
    }
}
