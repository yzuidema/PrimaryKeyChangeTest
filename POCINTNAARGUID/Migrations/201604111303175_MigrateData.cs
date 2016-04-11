namespace POCINTNAARGUID.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrateData : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Lorems SET UniqueIdentifier = NEWID ()");
            Sql("UPDATE Ipsums SET UniqueIdentifier = NEWID ()");
            Sql(@"UPDATE 
                    ipsums
                SET
                    LoremUniqueIdentifier = lor.UniqueIdentifier
                FROM
                    Lorems lor
                JOIN
                    ipsums ips ON lor.id = ips.LoremId");
        }
        
        public override void Down()
        {
        }
    }
}
