using System;
using System.Collections.Generic;

namespace veterinaria.yara.api.DataContext
{
    public partial class Raza
    {
        public Raza()
        {
            Mascota = new HashSet<Mascotum>();
        }


        public int IdRaza { get; set; }
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }
        public bool? Estado { get; set; }

        public virtual ICollection<Mascotum> Mascota { get; set; }
    }
}
