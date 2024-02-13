namespace EntityFrameworkCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Produto1 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Pedidoes", newName: "Produtos");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Produtos", newName: "Pedidoes");
        }
    }
}
