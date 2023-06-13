namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_titlewriter_add : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Writers", "TitleWriter", c => c.String(maxLength: 60));
        }
        
        public override void Down()
        {
            AddColumn("dbo.Writers", "WriterTitle", c => c.String(maxLength: 50));
        }
    }
}
