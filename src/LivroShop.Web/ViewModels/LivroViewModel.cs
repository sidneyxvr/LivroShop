using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LivroShop.Web.ViewModels
{
    public class LivroViewModel
    {
        [Key]
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Digite o nome do livro")]
        [StringLength(maximumLength: 50, ErrorMessage = "No Máximo 50 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Digite o ISBN do livro")]
        [StringLength(maximumLength: 10, ErrorMessage = "No Máximo 10 caracteres")]
        public string ISBN { get; set; }
    }
}
