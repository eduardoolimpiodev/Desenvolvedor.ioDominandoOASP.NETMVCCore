using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MinhaDemoMVC.Models
{
    public class Filme
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo Título é obrigatório.")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "O Título precisa ter entre 3 ou 60 caracteres.")]
        public string Titulo { get; set; }

        [DataType(DataType.DateTime, ErrorMessage = "Data em formato incorreto.")]
        [Required(ErrorMessage = "O campo Data é obrigatório.")]
        [Display(Name = "Data de Lançamento")]
        public DateTime DataLancamento { get; set; }

        [Display(Name = "Gênero")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\u00C0-\u00FF""'\w-]*$", ErrorMessage = "Gênero em formato inválido.")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "O Gênero precisa ter entre 3 e 30 caracteres."), Required(ErrorMessage = "O campo Gênero é obrigatório.")]
        public string Genero { get; set; }

        [Range(1, 1000, ErrorMessage = "O Valor precisa ser de R$ 1 a R$ 1000,00")]]
        [Required(ErrorMessage = "O campo Valor é obrigatório.")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Valor { get; set; }

        [Display(Name = "Avaliação")]
        [Required(ErrorMessage = "O campo Avaliação é obrigatório.")]
        [RegularExpression(@"^[0-5]*$", ErrorMessage = "Somente números de zero a cinco.")]
        public int Avaliacao { get; set; }

    }   
}
