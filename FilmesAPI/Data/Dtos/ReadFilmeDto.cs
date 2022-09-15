using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FilmesAPI.Data.Dtos
{
    public class ReadFilmeDto
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo titulo é obrigatório")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "O campo diretor é obrigatório")]
        public string Diretor { get; set; }

        [StringLength(30, ErrorMessage = "Gero não pode passar de 30 caracteres")]
        public string Genero { get; set; }

        [Range(1, 180, ErrorMessage = "A duração máxima é de 180 minutos")]
        public int Duracao { get; set; }

        public DateTime HoraDaConsulta { get; set; }

    }
}
