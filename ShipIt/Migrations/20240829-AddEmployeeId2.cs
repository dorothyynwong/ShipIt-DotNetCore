using FluentMigrator;

namespace ShipIt.Migrations
{
    [Migration(20240829154900)]
    public class AddEmployeeId2 : Migration
    {
        public override void Up()
        {
            Alter.Table("em").AddColumn("em_id").AsInt32().NotNullable().PrimaryKey().Identity();
            // Delete.PrimaryKey("em_pkey").FromTable("em");
        }

        public override void Down()
        {
            Delete.Column("em_id").FromTable("em");
            Alter.Table("em").AlterColumn("name").AsString().PrimaryKey().Identity();
            //Create.PrimaryKey("PK_tableName_Id").OnTable("tableName").Column("Id");
        }
    }
}