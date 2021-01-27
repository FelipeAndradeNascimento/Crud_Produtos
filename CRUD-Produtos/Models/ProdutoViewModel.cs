using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace CRUD_Produtos.Models
{
    public class ProdutoViewModel
    {
        public Int32 IdProduto { get; set; }
        [Required(ErrorMessage = "Infome o nome do produto", AllowEmptyStrings = false)]
        [Display(Name = "Nome do produto")]
        public string Prd_nome { get; set; }
        [Display(Name = "Descrição do produto")]
        public string Prd_descricao { get; set; }

        [Required(ErrorMessage = "Informe o preço do produto", AllowEmptyStrings = false)]
        [Display(Name = "Preço")]
        public decimal Prd_preco { get; set; }

        [Required(ErrorMessage = "Selecione uma Categoria", AllowEmptyStrings = false)]
        [Display(Name = "Categoria")]
        public int IdCategoria { get; set; }

        [Required]
        [DataType(DataType.Upload)]
        [Display(Name = "Imagem")]
        public HttpPostedFileBase Imagempload { get; set; }
    }
}