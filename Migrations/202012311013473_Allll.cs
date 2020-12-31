namespace HesapRehberi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Allll : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Firma",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        firmaAdi = c.String(nullable: false, maxLength: 100),
                        firmaTelefon = c.String(maxLength: 11),
                        firmaAdresi = c.String(nullable: false, maxLength: 200),
                        birimfiyat = c.Double(nullable: false),
                        YaklasikMaliyet_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.YaklasikMaliyet", t => t.YaklasikMaliyet_ID)
                .Index(t => t.YaklasikMaliyet_ID);
            
            CreateTable(
                "dbo.IsTanimi",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        dosyaNo = c.String(nullable: false, maxLength: 15),
                        isinAdi = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.KanitlayiciBelgeler",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        belgeAdi = c.String(nullable: false, maxLength: 100),
                        IsTanimi_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.IsTanimi", t => t.IsTanimi_ID)
                .Index(t => t.IsTanimi_ID);
            
            CreateTable(
                "dbo.YaklasikMaliyet",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        birimFiyat = c.Double(nullable: false),
                        BirimOrtalama = c.Double(nullable: false),
                        ToplamOrtalama = c.Double(nullable: false),
                        IsTanimi_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.IsTanimi", t => t.IsTanimi_ID)
                .Index(t => t.IsTanimi_ID);
            
            CreateTable(
                "dbo.Kisiler",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        adSoyad = c.String(nullable: false, maxLength: 50),
                        unvan = c.String(nullable: false, maxLength: 50),
                        YaklasikMaliyet_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.YaklasikMaliyet", t => t.YaklasikMaliyet_ID)
                .Index(t => t.YaklasikMaliyet_ID);
            
            CreateTable(
                "dbo.Malzeme",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        malzemeAdi = c.String(nullable: false, maxLength: 100),
                        malzemeOzelligi = c.String(maxLength: 200),
                        miktari = c.Int(nullable: false),
                        olcuBirimi = c.String(nullable: false, maxLength: 15),
                        kdvOrani = c.Int(nullable: false),
                        YaklasikMaliyet_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.YaklasikMaliyet", t => t.YaklasikMaliyet_ID)
                .Index(t => t.YaklasikMaliyet_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Malzeme", "YaklasikMaliyet_ID", "dbo.YaklasikMaliyet");
            DropForeignKey("dbo.Kisiler", "YaklasikMaliyet_ID", "dbo.YaklasikMaliyet");
            DropForeignKey("dbo.YaklasikMaliyet", "IsTanimi_ID", "dbo.IsTanimi");
            DropForeignKey("dbo.Firma", "YaklasikMaliyet_ID", "dbo.YaklasikMaliyet");
            DropForeignKey("dbo.KanitlayiciBelgeler", "IsTanimi_ID", "dbo.IsTanimi");
            DropIndex("dbo.Malzeme", new[] { "YaklasikMaliyet_ID" });
            DropIndex("dbo.Kisiler", new[] { "YaklasikMaliyet_ID" });
            DropIndex("dbo.YaklasikMaliyet", new[] { "IsTanimi_ID" });
            DropIndex("dbo.KanitlayiciBelgeler", new[] { "IsTanimi_ID" });
            DropIndex("dbo.Firma", new[] { "YaklasikMaliyet_ID" });
            DropTable("dbo.Malzeme");
            DropTable("dbo.Kisiler");
            DropTable("dbo.YaklasikMaliyet");
            DropTable("dbo.KanitlayiciBelgeler");
            DropTable("dbo.IsTanimi");
            DropTable("dbo.Firma");
        }
    }
}
