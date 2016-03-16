using Domain.People;

namespace DAL.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class MigrationsConfiguration : DbMigrationsConfiguration<StoreItDbContext>
    {
        public MigrationsConfiguration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(StoreItDbContext context)
        {
            //TODO!! Complete creation of testdata seed
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

            /*
            context.ContactTypes.AddOrUpdate(p => p.ContactTypeId, 
                new ContactType {ContactTypeId = 0, ContactTypeValue = "Mobiiltelefon", ContactTypeActive = true, Contacts = null},
                new ContactType {ContactTypeId = 1, ContactTypeValue = "E-mail", ContactTypeActive = true, Contacts = null},
                new ContactType {ContactTypeId = 2, ContactTypeValue = "Skype", ContactTypeActive = true, Contacts = null});

            context.PersonTypes.AddOrUpdate(p => p.PersonTypeId,
                new PersonType {PersonTypeId = 0, PersonTypeValue = "T��taja", PersonTypeActive = true, PersonTypeDescription = "Ettev�tte t��tajad", Persons = null},
                new PersonType {PersonTypeId = 1,PersonTypeValue = "Juhtkond",PersonTypeActive = true,PersonTypeDescription = "Ettev�tte juhtiv personal",Persons = null},
                new PersonType {PersonTypeId = 2, PersonTypeValue = "Klient", PersonTypeActive = true, PersonTypeDescription = "Ettev�tte kliendid", Persons = null});
            */
            //TODO J�TKATA!!!
        }
    }
}
