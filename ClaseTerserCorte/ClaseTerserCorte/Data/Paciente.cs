using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ClaseTerserCorte.Data
{
    public class Paciente
    {
        [Key]
        public int IdPaciente { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Departamento { get; set; }
        public string Descripcion { get; set; }
        public string FechaNacimiento { get; set; }
    }
}
