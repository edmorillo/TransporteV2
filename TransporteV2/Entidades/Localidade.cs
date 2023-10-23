using System;
using System.Collections.Generic;

namespace TransporteV2.Entidades
{
    public partial class Localidade
    {
        public Localidade()
        {
            Viajes = new HashSet<Viaje>();
        }

        public int IdLocalidad { get; set; }
        public int? IdProvincia { get; set; }
        public string? Localidad { get; set; }

        public virtual Provincium? IdProvinciaNavigation { get; set; }
        public virtual ICollection<Viaje> Viajes { get; set; }
    }
}
