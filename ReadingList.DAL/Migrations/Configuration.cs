namespace TeamManager.DAL.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using TeamManager.DAL;
    using TeamManager.Domain;

    internal sealed class Configuration : DbMigrationsConfiguration<TeamManagerContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TeamManagerContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Teams.AddOrUpdate(
                  p => p.Name,
                  new Team
                  {
                      Name = "MMDCOM",
                      Members = new List<Member>()
                      {
                          new Member{ FirstName="Ninad", LastName="Sakhadev", Gender= Gender.Male,Bio="Short Bio For Ninad", ProfilePicture="Test.jpg"},
                          new Member{ FirstName="Amar", LastName="Gehani", Gender= Gender.Male,Bio="Short Bio For Amar", ProfilePicture="Test1.jpg"}
                      }
                  },
                  new Team
                  {
                      Name = "Acento" ,
                      Members = new List<Member>()
                      {
                          new Member{ FirstName="Ganesh", LastName="N", Gender= Gender.Male,Bio="Short Bio For Ganesh", ProfilePicture="Test2.jpg"},
                          new Member{ FirstName="Gopal", LastName="A", Gender= Gender.Male,Bio="Short Bio For Gopal", ProfilePicture="Test3.jpg"}
                      }
                  },
                  new Team
                  {
                      Name = "Test" ,
                      Members = new List<Member>()
                      {
                          new Member{ FirstName="Ganesh", LastName="N", Gender= Gender.Male,Bio="Short Bio For Ganesh", ProfilePicture="Test2.jpg"},
                          new Member{ FirstName="Gopal", LastName="A", Gender= Gender.Male,Bio="Short Bio For Gopal", ProfilePicture="Test3.jpg"}
                      }
                  }
                );
        }
    }
}
