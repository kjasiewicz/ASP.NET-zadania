namespace Entity_Framework_example.Migrations
{
    using Entity_Framework_example.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Entity_Framework_example.Models.BazaDanychDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Entity_Framework_example.Models.BazaDanychDbContext context)
        {
            context.Adres.Add(
                    new Adres
                    {
                        Ulica = "Partyzantów",
                        Numer = "62",
                        NrIndeksu = 43571,
                        KodPocztowy = "32-650"

                    });
            context.Student.Add(
                new Student
                {
                    Imie = "Katarzyna",
                    Nazwisko = "Jasiewicz",
                    NrIndeksu = 43571

                });
            context.Telefon.Add(
                new Telefony
                {
                    CzyKomorkowy = true,
                    NrIndeksu = 43571,
                    Numer = 506320031,
                    Operator = "play"

                });

            context.SaveChanges();
            base.Seed(context);

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
        }
    }
}
