using System.ComponentModel.DataAnnotations;

namespace Biblioteca.Api.Modelo
{
    public class Paciente
    {
        [Key]
        public int IdPaciente { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Departamento { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaNacimiento { get; set; } 


    }
}
