using System;
using System.Collections.Generic;

namespace veterinaria.yara.api.DataContext
{
    public partial class Mascotum
    {
        public Mascotum()
        {
            Personas = new HashSet<Persona>();
        }

        public int IdMascota { get; set; }
        public string? Nombre { get; set; }
        public string? Mote { get; set; }
        public int? Edad { get; set; }
        public double? Peso { get; set; }
        public int? IdRaza { get; set; }

        public virtual Raza? IdRazaNavigation { get; set; }
        public virtual ICollection<Persona> Personas { get; set; }
    }
}
