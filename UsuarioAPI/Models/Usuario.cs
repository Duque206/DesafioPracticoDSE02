using System.ComponentModel.DataAnnotations;

namespace UsuarioAPI.Models
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; } = string.Empty;
        public string? Apellido { get; set; }
        public string? Edad { get; set; }
    }
}

