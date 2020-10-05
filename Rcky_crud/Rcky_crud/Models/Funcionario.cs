using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Rcky_crud.Models
{
    public class Funcionario
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "O nome deve ser preenchido.")]
        [MaxLength(100, ErrorMessage = "O nome pode conter até 100 caracteres.")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O endereço deve ser preenchido.")]
        [MaxLength(200, ErrorMessage = "O endereço deve conter até 200 caracteres")]
        public string Endereco { get; set; }
        [Required(ErrorMessage = "A data de nascimento deve ser preenchida.")]
        [DisplayFormat(DataFormatString = "dd/mm/yyyy")]
        public DateTime DataNascimento { get; set; }
        [Required(ErrorMessage = "Salario deve ser preenchido.")]
        public float Salario { get; set; }
        [Required(ErrorMessage = "O gênero deve ser preenchido")]
        [JsonConverter(typeof(StringEnumConverter))]
        public Genero Genero { get; set; }
    }
}
