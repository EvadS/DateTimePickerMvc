namespace DateTimePickerMvc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPassAndPasswConfField : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.People", "Password", c => c.String());
            AddColumn("dbo.People", "PasswordConfirm", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.People", "PasswordConfirm");
            DropColumn("dbo.People", "Password");
        }
    }
}
