namespace SirRogueTest1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Quests",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        QuestName = c.String(),
                        QuestXp = c.Double(nullable: false),
                        QuestMoneyReward = c.Double(nullable: false),
                        StaminaRequirement = c.Double(nullable: false),
                        Completed = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Quests");
        }
    }
}
