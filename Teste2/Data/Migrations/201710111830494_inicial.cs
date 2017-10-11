namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.InTask",
                c => new
                    {
                        InTaskId = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 100, unicode: false),
                        Description = c.String(nullable: false, maxLength: 512, unicode: false),
                        TaskStatusId = c.Int(nullable: false),
                        Created = c.DateTime(nullable: false),
                        Updated = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.InTaskId)
                .ForeignKey("dbo.Status", t => t.TaskStatusId)
                .Index(t => t.TaskStatusId);
            
            CreateTable(
                "dbo.Status",
                c => new
                    {
                        TaskStatusId = c.Int(nullable: false, identity: true),
                        Description = c.String(nullable: false, maxLength: 512, unicode: false),
                        Created = c.DateTime(nullable: false),
                        Updated = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.TaskStatusId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.InTask", "TaskStatusId", "dbo.Status");
            DropIndex("dbo.InTask", new[] { "TaskStatusId" });
            DropTable("dbo.Status");
            DropTable("dbo.InTask");
        }
    }
}
