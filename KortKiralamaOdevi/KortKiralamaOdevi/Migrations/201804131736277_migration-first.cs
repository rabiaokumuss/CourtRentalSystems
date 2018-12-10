namespace KortKiralamaOdevi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migrationfirst : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.KortGunlukUcrets",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FKKortID = c.Int(nullable: false),
                        Gun = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Korts", t => t.FKKortID, cascadeDelete: true)
                .Index(t => t.FKKortID);
            
            CreateTable(
                "dbo.Korts",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        KortAdi = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Odemes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        OdenecekTutar = c.Double(nullable: false),
                        OdendiMi = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Rezervasyons",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FKUyeID = c.String(maxLength: 128),
                        Ad = c.String(),
                        Soyad = c.String(),
                        TelNo = c.String(),
                        BaslangicTarihi = c.DateTime(nullable: false),
                        BitisTarihi = c.DateTime(nullable: false),
                        FKKortID = c.Int(nullable: false),
                        FKOdemeID = c.Int(nullable: false),
                        EnumRezervasyonDurumu = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Korts", t => t.FKKortID, cascadeDelete: true)
                .ForeignKey("dbo.Odemes", t => t.FKOdemeID, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.FKUyeID)
                .Index(t => t.FKUyeID)
                .Index(t => t.FKKortID)
                .Index(t => t.FKOdemeID);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Ad = c.String(),
                        Soyad = c.String(),
                        TelNo = c.String(),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.Rezervasyons", "FKUyeID", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Rezervasyons", "FKOdemeID", "dbo.Odemes");
            DropForeignKey("dbo.Rezervasyons", "FKKortID", "dbo.Korts");
            DropForeignKey("dbo.KortGunlukUcrets", "FKKortID", "dbo.Korts");
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.Rezervasyons", new[] { "FKOdemeID" });
            DropIndex("dbo.Rezervasyons", new[] { "FKKortID" });
            DropIndex("dbo.Rezervasyons", new[] { "FKUyeID" });
            DropIndex("dbo.KortGunlukUcrets", new[] { "FKKortID" });
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.Rezervasyons");
            DropTable("dbo.Odemes");
            DropTable("dbo.Korts");
            DropTable("dbo.KortGunlukUcrets");
        }
    }
}
