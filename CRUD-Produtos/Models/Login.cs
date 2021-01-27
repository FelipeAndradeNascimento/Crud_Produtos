using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUD_Produtos.Models
{
    [Table("Login")]
    public class Login
    {
        [Required]
        [Display(Name = "Nome")]
        public string Lg_nome { get; set; }
        [Required]
        [Display(Name = "Senha")]
        public string Lg_senha { get; set; }
    }
}