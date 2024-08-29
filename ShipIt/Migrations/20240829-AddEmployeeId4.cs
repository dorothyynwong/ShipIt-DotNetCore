using FluentMigrator;

namespace ShipIt.Migrations
{
    [Migration(20240829155800)]
    public class AddEmployeeId4 : Migration
    {
        public override void Up()
        {
            Alter.Table("em").AddColumn("em_id").AsInt32().NotNullable().Identity();
            Delete.PrimaryKey("em_pkey").FromTable("em");
            Create.PrimaryKey("PK_em_id").OnTable("em").Columns("em_id");
        }

        public override void Down()
        {
            Delete.Column("em_id").FromTable("em");
            Alter.Table("em").AlterColumn("name").AsString().PrimaryKey().Identity();
            //Create.PrimaryKey("PK_tableName_Id").OnTable("tableName").Column("Id");
        }
    }
}