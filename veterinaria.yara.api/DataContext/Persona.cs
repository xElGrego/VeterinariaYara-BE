using System;
using System.Collections.Generic;

namespace veterinaria.yara.api.DataContext
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

        public virtual Mascotum? IdMascotaNavigation { get; set; }
    }
}
