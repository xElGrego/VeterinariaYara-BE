using System.Text.Json.Serialization;

namespace veterinaria.yara.domain.entities
{
    public partial class Persona
    {
        public int IdPersona { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? Descripcion { get; set; }
        public int? Edad { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public bool? Estado { get; set; }
        public int? IdMascota { get; set; }

        [JsonIgnore]
        public virtual Mascota? IdMascotaNavigation { get; set; }
    }
}
