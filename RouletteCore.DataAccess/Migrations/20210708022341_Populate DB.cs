using Microsoft.EntityFrameworkCore.Migrations;

namespace RouletteCore.DataAccess.Migrations
{
    public partial class PopulateDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"SET IDENTITY_INSERT [Roulette].[Colors] ON;");
            migrationBuilder.Sql("insert into [Roulette].[Colors] (Id, Name,CreatedByUserId,UpdateDate,UpdatedByUserId,CreateDate) Values(1,'Red','Dev',GETDATE(),'Dev',GETDATE())");
            migrationBuilder.Sql("insert into [Roulette].[Colors] (Id, Name,CreatedByUserId,UpdateDate,UpdatedByUserId,CreateDate) Values(2,'Black','Dev',GETDATE(),'Dev',GETDATE())");
            migrationBuilder.Sql("insert into [Roulette].[Colors] (Id, Name,CreatedByUserId,UpdateDate,UpdatedByUserId,CreateDate) Values(3,'Green','Dev',GETDATE(),'Dev',GETDATE())");
            migrationBuilder.Sql(@"SET IDENTITY_INSERT [Roulette].[Colors] OFF;");
            migrationBuilder.Sql(@"SET IDENTITY_INSERT [Roulette].[Numbers] ON;");
            migrationBuilder.Sql("insert into [Roulette].[Numbers] (Id, Number,ColorId,OddEvenFactor,CreatedByUserId,UpdateDate,UpdatedByUserId,CreateDate) Values(0,'0',3,'NA','Dev',GETDATE(),'Dev',GETDATE())");
            migrationBuilder.Sql("insert into [Roulette].[Numbers] (Id, Number,ColorId,OddEvenFactor,CreatedByUserId,UpdateDate,UpdatedByUserId,CreateDate) Values(1,'1',1,'Odd','Dev',GETDATE(),'Dev',GETDATE())");
            migrationBuilder.Sql("insert into [Roulette].[Numbers] (Id, Number,ColorId,OddEvenFactor,CreatedByUserId,UpdateDate,UpdatedByUserId,CreateDate) Values(2,'2',2,'Even','Dev',GETDATE(),'Dev',GETDATE())");
            migrationBuilder.Sql("insert into [Roulette].[Numbers] (Id, Number,ColorId,OddEvenFactor,CreatedByUserId,UpdateDate,UpdatedByUserId,CreateDate) Values(3,'3',1,'Odd','Dev',GETDATE(),'Dev',GETDATE())");
            migrationBuilder.Sql("insert into [Roulette].[Numbers] (Id, Number,ColorId,OddEvenFactor,CreatedByUserId,UpdateDate,UpdatedByUserId,CreateDate) Values(4,'4',2,'Even','Dev',GETDATE(),'Dev',GETDATE())");
            migrationBuilder.Sql("insert into [Roulette].[Numbers] (Id, Number,ColorId,OddEvenFactor,CreatedByUserId,UpdateDate,UpdatedByUserId,CreateDate) Values(5,'5',1,'Odd','Dev',GETDATE(),'Dev',GETDATE())");
            migrationBuilder.Sql("insert into [Roulette].[Numbers] (Id, Number,ColorId,OddEvenFactor,CreatedByUserId,UpdateDate,UpdatedByUserId,CreateDate) Values(6,'6',2,'Even','Dev',GETDATE(),'Dev',GETDATE())");
            migrationBuilder.Sql("insert into [Roulette].[Numbers] (Id, Number,ColorId,OddEvenFactor,CreatedByUserId,UpdateDate,UpdatedByUserId,CreateDate) Values(7,'7',1,'Odd','Dev',GETDATE(),'Dev',GETDATE())");
            migrationBuilder.Sql("insert into [Roulette].[Numbers] (Id, Number,ColorId,OddEvenFactor,CreatedByUserId,UpdateDate,UpdatedByUserId,CreateDate) Values(8,'8',2,'Even','Dev',GETDATE(),'Dev',GETDATE())");
            migrationBuilder.Sql("insert into [Roulette].[Numbers] (Id, Number,ColorId,OddEvenFactor,CreatedByUserId,UpdateDate,UpdatedByUserId,CreateDate) Values(9,'9',1,'Odd','Dev',GETDATE(),'Dev',GETDATE())");
            migrationBuilder.Sql("insert into [Roulette].[Numbers] (Id, Number,ColorId,OddEvenFactor,CreatedByUserId,UpdateDate,UpdatedByUserId,CreateDate) Values(10,'10',2,'Even','Dev',GETDATE(),'Dev',GETDATE())");
            migrationBuilder.Sql("insert into [Roulette].[Numbers] (Id, Number,ColorId,OddEvenFactor,CreatedByUserId,UpdateDate,UpdatedByUserId,CreateDate) Values(11,'11',2,'Odd','Dev',GETDATE(),'Dev',GETDATE())");
            migrationBuilder.Sql("insert into [Roulette].[Numbers] (Id, Number,ColorId,OddEvenFactor,CreatedByUserId,UpdateDate,UpdatedByUserId,CreateDate) Values(12,'12',1,'Even','Dev',GETDATE(),'Dev',GETDATE())");
            migrationBuilder.Sql("insert into [Roulette].[Numbers] (Id, Number,ColorId,OddEvenFactor,CreatedByUserId,UpdateDate,UpdatedByUserId,CreateDate) Values(13,'13',2,'Odd','Dev',GETDATE(),'Dev',GETDATE())");
            migrationBuilder.Sql("insert into [Roulette].[Numbers] (Id, Number,ColorId,OddEvenFactor,CreatedByUserId,UpdateDate,UpdatedByUserId,CreateDate) Values(14,'14',1,'Even','Dev',GETDATE(),'Dev',GETDATE())");
            migrationBuilder.Sql("insert into [Roulette].[Numbers] (Id, Number,ColorId,OddEvenFactor,CreatedByUserId,UpdateDate,UpdatedByUserId,CreateDate) Values(15,'15',2,'Odd','Dev',GETDATE(),'Dev',GETDATE())");
            migrationBuilder.Sql("insert into [Roulette].[Numbers] (Id, Number,ColorId,OddEvenFactor,CreatedByUserId,UpdateDate,UpdatedByUserId,CreateDate) Values(16,'16',1,'Even','Dev',GETDATE(),'Dev',GETDATE())");
            migrationBuilder.Sql("insert into [Roulette].[Numbers] (Id, Number,ColorId,OddEvenFactor,CreatedByUserId,UpdateDate,UpdatedByUserId,CreateDate) Values(17,'17',2,'Odd','Dev',GETDATE(),'Dev',GETDATE())");
            migrationBuilder.Sql("insert into [Roulette].[Numbers] (Id, Number,ColorId,OddEvenFactor,CreatedByUserId,UpdateDate,UpdatedByUserId,CreateDate) Values(18,'18',1,'Even','Dev',GETDATE(),'Dev',GETDATE())");
            migrationBuilder.Sql("insert into [Roulette].[Numbers] (Id, Number,ColorId,OddEvenFactor,CreatedByUserId,UpdateDate,UpdatedByUserId,CreateDate) Values(19,'19',2,'Odd','Dev',GETDATE(),'Dev',GETDATE())");
            migrationBuilder.Sql("insert into [Roulette].[Numbers] (Id, Number,ColorId,OddEvenFactor,CreatedByUserId,UpdateDate,UpdatedByUserId,CreateDate) Values(20,'20',2,'Even','Dev',GETDATE(),'Dev',GETDATE())");
            migrationBuilder.Sql("insert into [Roulette].[Numbers] (Id, Number,ColorId,OddEvenFactor,CreatedByUserId,UpdateDate,UpdatedByUserId,CreateDate) Values(21,'21',1,'Odd','Dev',GETDATE(),'Dev',GETDATE())");
            migrationBuilder.Sql("insert into [Roulette].[Numbers] (Id, Number,ColorId,OddEvenFactor,CreatedByUserId,UpdateDate,UpdatedByUserId,CreateDate) Values(22,'22',2,'Even','Dev',GETDATE(),'Dev',GETDATE())");
            migrationBuilder.Sql("insert into [Roulette].[Numbers] (Id, Number,ColorId,OddEvenFactor,CreatedByUserId,UpdateDate,UpdatedByUserId,CreateDate) Values(23,'23',1,'Odd','Dev',GETDATE(),'Dev',GETDATE())");
            migrationBuilder.Sql("insert into [Roulette].[Numbers] (Id, Number,ColorId,OddEvenFactor,CreatedByUserId,UpdateDate,UpdatedByUserId,CreateDate) Values(24,'24',2,'Even','Dev',GETDATE(),'Dev',GETDATE())");
            migrationBuilder.Sql("insert into [Roulette].[Numbers] (Id, Number,ColorId,OddEvenFactor,CreatedByUserId,UpdateDate,UpdatedByUserId,CreateDate) Values(25,'25',1,'Odd','Dev',GETDATE(),'Dev',GETDATE())");
            migrationBuilder.Sql("insert into [Roulette].[Numbers] (Id, Number,ColorId,OddEvenFactor,CreatedByUserId,UpdateDate,UpdatedByUserId,CreateDate) Values(26,'26',2,'Even','Dev',GETDATE(),'Dev',GETDATE())");
            migrationBuilder.Sql("insert into [Roulette].[Numbers] (Id, Number,ColorId,OddEvenFactor,CreatedByUserId,UpdateDate,UpdatedByUserId,CreateDate) Values(27,'27',1,'Odd','Dev',GETDATE(),'Dev',GETDATE())");
            migrationBuilder.Sql("insert into [Roulette].[Numbers] (Id, Number,ColorId,OddEvenFactor,CreatedByUserId,UpdateDate,UpdatedByUserId,CreateDate) Values(28,'28',2,'Even','Dev',GETDATE(),'Dev',GETDATE())");
            migrationBuilder.Sql("insert into [Roulette].[Numbers] (Id, Number,ColorId,OddEvenFactor,CreatedByUserId,UpdateDate,UpdatedByUserId,CreateDate) Values(29,'29',2,'Odd','Dev',GETDATE(),'Dev',GETDATE())");
            migrationBuilder.Sql("insert into [Roulette].[Numbers] (Id, Number,ColorId,OddEvenFactor,CreatedByUserId,UpdateDate,UpdatedByUserId,CreateDate) Values(30,'30',1,'Even','Dev',GETDATE(),'Dev',GETDATE())");
            migrationBuilder.Sql("insert into [Roulette].[Numbers] (Id, Number,ColorId,OddEvenFactor,CreatedByUserId,UpdateDate,UpdatedByUserId,CreateDate) Values(31,'31',2,'Odd','Dev',GETDATE(),'Dev',GETDATE())");
            migrationBuilder.Sql("insert into [Roulette].[Numbers] (Id, Number,ColorId,OddEvenFactor,CreatedByUserId,UpdateDate,UpdatedByUserId,CreateDate) Values(32,'32',1,'Even','Dev',GETDATE(),'Dev',GETDATE())");
            migrationBuilder.Sql("insert into [Roulette].[Numbers] (Id, Number,ColorId,OddEvenFactor,CreatedByUserId,UpdateDate,UpdatedByUserId,CreateDate) Values(33,'33',2,'Odd','Dev',GETDATE(),'Dev',GETDATE())");
            migrationBuilder.Sql("insert into [Roulette].[Numbers] (Id, Number,ColorId,OddEvenFactor,CreatedByUserId,UpdateDate,UpdatedByUserId,CreateDate) Values(34,'34',1,'Even','Dev',GETDATE(),'Dev',GETDATE())");
            migrationBuilder.Sql("insert into [Roulette].[Numbers] (Id, Number,ColorId,OddEvenFactor,CreatedByUserId,UpdateDate,UpdatedByUserId,CreateDate) Values(35,'35',2,'Odd','Dev',GETDATE(),'Dev',GETDATE())");
            migrationBuilder.Sql("insert into [Roulette].[Numbers] (Id, Number,ColorId,OddEvenFactor,CreatedByUserId,UpdateDate,UpdatedByUserId,CreateDate) Values(36,'36',1,'Even','Dev',GETDATE(),'Dev',GETDATE())");
            migrationBuilder.Sql(@"SET IDENTITY_INSERT [Roulette].[Numbers] OFF;");
            migrationBuilder.Sql("Update [Roulette].[Numbers] set [OddEvenFactor]=NULL where Number='0'");
            migrationBuilder.Sql("insert into [Roulette].[RouletteEvents] (EventName,MinValue,MaxValue,CreatedByUserId,UpdateDate,UpdatedByUserId,CreateDate) Values('RA 01 (Min 2 \u20AC Max 20 \u20AC)',2,20,'Dev',GETDATE(),'Dev',GETDATE())");
            migrationBuilder.Sql("insert into [Roulette].[RouletteEvents] (EventName,MinValue,MaxValue,CreatedByUserId,UpdateDate,UpdatedByUserId,CreateDate) Values('RA 02 (Min 5 \u20AC Max 50 \u20AC)',5,50,'Dev',GETDATE(),'Dev',GETDATE())");
            migrationBuilder.Sql("insert into [Roulette].[RouletteEvents] (EventName,MinValue,MaxValue,CreatedByUserId,UpdateDate,UpdatedByUserId,CreateDate) Values('RA 11 (Min 2 \u20AC Max 20 \u20AC)',2,20,'Dev',GETDATE(),'Dev',GETDATE())");
            migrationBuilder.Sql("insert into [Roulette].[RouletteEvents] (EventName,MinValue,MaxValue,CreatedByUserId,UpdateDate,UpdatedByUserId,CreateDate) Values('RA 12 (Min 5 \u20AC Max 50 \u20AC)',5,50,'Dev',GETDATE(),'Dev',GETDATE())");
            migrationBuilder.Sql("INSERT INTO [Roulette].[Users]([UserName],[Password],[PasswordSalt],[CreatedByUserId],[CreateDate],[UpdateDate],[UpdatedByUserId])VALUES('Admin','An++BolmP6iz0YBhXIskQI9wO0Y8n1mr48sdfKIbkPE=','49f791f0d073468585861c79d5ccd0b3','Dev',GETDATE(),GETDATE(),'Dev')");


        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
