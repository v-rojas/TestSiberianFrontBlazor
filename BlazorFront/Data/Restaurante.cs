

using System.ComponentModel.DataAnnotations;

namespace BlazorFront.Data
{
    public class Restaurante
    {
        public string Token { get; set; }
        public string Codigo { get; set; }
        public string IDRestaurante { get; set; }
        [Required (ErrorMessage = "Nombre de restaurante es requerido")]
        public string NombreRestaurante { get; set; }
        [Required(ErrorMessage = "Ciudad es requerido")]
        public string IDCiudad { get; set; }
        public string NombreCiudad { get; set; }
        [Required(ErrorMessage = "Número de aforo es requerido")]
        public string NumeroAforo { get; set; }
        [Required(ErrorMessage = "Teléfono es requerido")]
        public string Telefono { get; set; }
        public string FechaCreacion { get; set; }
    }
}
