using System.ComponentModel.DataAnnotations;

namespace BackEndActividadUsuarios.DTOs
{
    public class ActividadesUsuarioDTO
    {
        [Required(ErrorMessage = "el campo {0} es requerido")]
        public DateTime Create_date { get; set; }
        [Required(ErrorMessage = "el campo {0} es requerido")]
        public int Id_usuario { get; set; }
        [Required(ErrorMessage = "el campo {0} es requerido")]
        [StringLength(maximumLength: 80, ErrorMessage = "El campo {0} no debe de tener mas de {1} caracter")]
        public string Actividad { get; set; }
    }
}
