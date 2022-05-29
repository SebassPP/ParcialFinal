using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ClaseTerserCorte.Data
{
    public class Doctor
    {
        [Key]
        public int IdDoctor { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Departamento { get; set; }
        public int Descripcion { get; set; }
        public string FechaNacimiento { get; set; }
    }
}
