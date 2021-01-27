using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace CRUD_Produtos.Models
{
    public class ProdutoContext : DbContext
    {
        public DbSet<ProdutoContext> Produtos { get; set; }
        public DbSet<DbContext> Categorias { get; set; }
    }
}