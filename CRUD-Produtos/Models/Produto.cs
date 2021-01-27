using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUD_Produtos.Models.Produto
{
    [Table("Produtos")]
    public class Produto
    {
        public int IdProduto { get; set; }
        [Required(ErrorMessage ="Infome o nome do produto", AllowEmptyStrings = false)]
        public string Prd_nome { get; set; }
        public string Prd_descricao { get; set; }

        [Required(ErrorMessage ="Informe o preço do produto", AllowEmptyStrings = false)]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = true)]
        public decimal Prd_preco { get; set; }
        public string Prd_imagem { get; set; }
        public int IdCategoria { get; set; }

        public virtual Categoria Categoria { get; set; }

    }
}