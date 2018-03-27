namespace ProjetoMenu.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Produtos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Codigo = c.Guid(nullable: false),
                        Marca = c.String(nullable: false, maxLength: 50, unicode: false),
                        Modelo = c.String(nullable: false, maxLength: 50, unicode: false),
                        Descricao = c.String(nullable: false, maxLength: 150, unicode: false),
                        EntryDate = c.DateTime(nullable: false),
                        Quantidade = c.Int(nullable: false),
                        Valor = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Produtos");
        }
    }
}
