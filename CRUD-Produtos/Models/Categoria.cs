using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUD_Produtos.Models.Categoria
{
    [Table("Categorias")]
    public class Categoria
    {
        public int IdCategoria { get; set; }
        
        [Display(Name = "Nome da Categoria")]
        public string Ctg_nome { get; set; }
        public string Ctg_descricao { get; set; }
        public DateTime Ctg_dtCadastro { get; set; }
        
        public List<ProdutoContext> Produtos { get; set; }

    }
}