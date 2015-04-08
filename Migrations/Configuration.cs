using System.Data.Entity.Migrations;
using System.Linq;
using ODataApiSample.Models;

namespace ODataApiSample.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<AppContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(AppContext context)
        {
            if (!context.Pessoas.Any())
            {
                context.Pessoas.AddOrUpdate(Enumerable.Range(1, 100).Select(i => new Pessoa { Id = i, Nome = "Pessoa " + i }).ToArray());
                context.SaveChanges();
            }
        }
    }
}
