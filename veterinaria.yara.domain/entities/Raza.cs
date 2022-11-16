using System.Text.Json.Serialization;

namespace veterinaria.yara.domain.entities
{
    public partial class Raza
    {

        public int IdRaza { get; set; }
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }
        public bool? Estado { get; set; }

        [JsonIgnore]
        public virtual ICollection<Mascota>? Mascota { get; set; }

    }
}
