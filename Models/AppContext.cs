using System.Data.Entity;

namespace ODataApiSample.Models
{
    /*public class PessoasController : EntitySetCo
    {
        private List<Pessoa> pessoas;

        public PessoasController()
        {
            pessoas = Enumerable.Range(1, 100).Select(i => new Pessoa { Id = i, Nome = "Pessoa " + i }).ToList();
        }

        [EnableQuery(AllowedQueryOptions = AllowedQueryOptions.All)]
        public IQueryable<Pessoa> Get()
        {
            return pessoas.AsQueryable();
        }
    }*/

    public class AppContext : DbContext
    {
        public DbSet<Pessoa> Pessoas { get; set; }
    }
}