using System.ComponentModel.DataAnnotations;

namespace BackEndActividadUsuarios.Entidades
{
    public class CredencialesUsuarioModel
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "el campo {0} es requerido")]
        [StringLength(maximumLength: 50, ErrorMessage = "El campo {0} no debe de tener mas de {1} caracter")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "el campo {0} es requerido")]
        [StringLength(maximumLength: 50, ErrorMessage = "El campo {0} no debe de tener mas de {1} caracter")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "el campo {0} es requerido")]
        [EmailAddress]
        public string CorreoElectronico { get; set; }

        [Required(ErrorMessage = "el campo {0} es requerido")]
        public DateTime FechaNacimiento { get; set; }

        public int Telefono { get; set; }

        [Required(ErrorMessage = "el campo {0} es requerido")]
        [StringLength(maximumLength: 50, ErrorMessage = "El campo {0} no debe de tener mas de {1} caracter")]
        public string PaisResidencia { get; set; }

        [Required(ErrorMessage = "el campo {0} es requerido")]
        public bool InformacionContacto { get; set; }
    }
}
