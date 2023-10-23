using System.ComponentModel.DataAnnotations;

namespace TransporteV2.Models
{
    public class RegistroViewModel
    {
        [Required(ErrorMessage = "Porfavor lleves los campos")]
        [EmailAddress(ErrorMessage = "El campo debe ser un correo electrónico Valido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Porfavor lleves los campos")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
