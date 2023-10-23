using System;
using System.Collections.Generic;

namespace TransporteV2.Entidades
{
    public partial class Cliente
    {
        public Cliente()
        {
            Viajes = new HashSet<Viaje>();
        }

        public int IdCliente { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? RazonSocial { get; set; }
        public string? Cuit { get; set; }
        public int? IdProvincia { get; set; }
        public string? Direccion { get; set; }
        public int? CodigoPostal { get; set; }
        public string? Email { get; set; }
        public int? Telefono { get; set; }
        public int? IdCondicionIva { get; set; }
        public string? IngresosBrutos { get; set; }

        public virtual CondicionIva? IdCondicionIvaNavigation { get; set; }
        public virtual Provincium? IdProvinciaNavigation { get; set; }
        public virtual ICollection<Viaje> Viajes { get; set; }
    }
}
