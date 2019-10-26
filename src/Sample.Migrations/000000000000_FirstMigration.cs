using System;
using FluentMigrator;
using FluentMigrator.SqlServer;

namespace Sample.Migrations
{
    [Migration(000000000000)]
    public class _00000000000_FirstMigration : Migration
    {
        public override void Down()
        {
            Delete.Table("BlogPosts");
        }

        public override void Up()
        {
            // Create your first table
            Create.Table("BlogPosts")
                .WithColumn("Id").AsInt64().PrimaryKey().Identity()
                .WithColumn("Title").AsString().NotNullable()
                .WithColumn("Abstract").AsString().Nullable()
                .WithColumn("Body").AsString().Nullable()
                .WithColumn("CreatedDate").AsDateTime().WithDefault(SystemMethods.CurrentUTCDateTime);

            // Let's seed our data
            InitialSeed();
        }

        private void InitialSeed()
        {
            // We have our table, let's apply seed data
            IfDatabase("sqlserver").
            Insert.IntoTable("BlogPosts").WithIdentityInsert()
                .Row(
                new
                {
                    Id = 1,
                    Title = "This is a title 1",
                    Abstract = "This is an abstract",
                    Body = "Your content here, because you know: is an awesome post"
                })
                .Row(
                new
                {
                    Id = 2,
                    Title = "This is a title 2",
                    Abstract = "This is an abstract",
                    Body = "Your content here, because you know: is an awesome post"
                })
                .Row(
                new
                {
                    Id = 3,
                    Title = "This is a title 3",
                    Abstract = "This is an abstract",
                    Body = "Your content here, because you know: is an awesome post"
                })
                .Row(
                new
                {
                    Id = 4,
                    Title = "This is a title 4",
                    Abstract = "This is an abstract",
                    Body = "Your content here, because you know: is an awesome post"
                })
                .Row(
                new
                {
                    Id = 5,
                    Title = "This is a title 5",
                    Abstract = "This is an abstract",
                    Body = "Your content here, because you know: is an awesome post"
                });

            IfDatabase("sqlite").
            Insert.IntoTable("BlogPosts")
               .Row(
               new
               {
                   Id = 1,
                   Title = "This is a title 1",
                   Abstract = "This is an abstract",
                   Body = "Your content here, because you know: is an awesome post"
               })
               .Row(
               new
               {
                   Id = 2,
                   Title = "This is a title 2",
                   Abstract = "This is an abstract",
                   Body = "Your content here, because you know: is an awesome post"
               })
               .Row(
               new
               {
                   Id = 3,
                   Title = "This is a title 3",
                   Abstract = "This is an abstract",
                   Body = "Your content here, because you know: is an awesome post"
               })
               .Row(
               new
               {
                   Id = 4,
                   Title = "This is a title 4",
                   Abstract = "This is an abstract",
                   Body = "Your content here, because you know: is an awesome post"
               })
               .Row(
               new
               {
                   Id = 5,
                   Title = "This is a title 5",
                   Abstract = "This is an abstract",
                   Body = "Your content here, because you know: is an awesome post"
               });
        }
    }
}
