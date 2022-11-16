using System.Text.Json.Serialization;

namespace veterinaria.yara.domain.entities
{
    public partial class Mascota
    {
        public int IdMascota { get; set; }
        public string? Nombre { get; set; }
        public string? Mote { get; set; }
        public int? Edad { get; set; }
        public double? Peso { get; set; }
        public int? IdRaza { get; set; }

        [JsonIgnore]
        public virtual Raza? IdRazaNavigation { get; set; }
        [JsonIgnore]
        public virtual ICollection<Persona>? Personas { get; set; }
    }
}
