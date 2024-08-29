using FluentMigrator;

namespace ShipIt.Migrations
{
    [Migration(20240829142900)]
    public class AddEmployeeId : Migration
    {
        public override void Up()
        {
            Alter.Table("em").AddColumn("em_id").AsInt32().NotNullable().PrimaryKey().Identity();
            Delete.PrimaryKey("name").FromTable("em");
        }

        public override void Down()
        {
            Delete.Column("em_id").FromTable("em");
            Alter.Table("em").AlterColumn("name").AsString().PrimaryKey().Identity();
            //Create.PrimaryKey("PK_tableName_Id").OnTable("tableName").Column("Id");
        }
    }
}