using Sostenes.MyApi.Dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sostenes.MyApi.AcessoDados.Entity.Context
{
    class MyApiDbContext : DbContext
    {
        public DbSet<Aluno> Alunos { get; set; }

        public MyApiDbContext()
        {
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
        }
    }
}
