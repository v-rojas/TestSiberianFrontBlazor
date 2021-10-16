using System.ComponentModel.DataAnnotations;

namespace BlazorFront.Data
{
    public class CiudadModelo
    {
        public string Token { get; set; }
        public string Codigo { get; set; }
        public string IDCiudad { get; set; }
        [Required(ErrorMessage = "Nombre de ciudad es requerido")]
        public string NombreCiudad { get; set; }
        public string FechaCreacion { get; set; }
    }
}
