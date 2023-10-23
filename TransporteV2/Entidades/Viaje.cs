using System;
using System.Collections.Generic;

namespace TransporteV2.Entidades
{
    public partial class Viaje
    {
        public int IdViajes { get; set; }
        public string? Viajes { get; set; }
        public string? Origen { get; set; }
        public string? Destino { get; set; }
        public int? IdChofer { get; set; }
        public int? IdCliente { get; set; }
        public decimal? Tarifa { get; set; }
        public DateTime? FormaDeCobro { get; set; }
        public string? Escobrado { get; set; }
        public string? Detalle { get; set; }
        public string? Remito { get; set; }
        public int? Ncontenedor { get; set; }
        public string? EsFacturado { get; set; }
        public string? Entidad { get; set; }
        public string? Nfactura { get; set; }
        public int? IdProvincia { get; set; }
        public int? IdLocalidad { get; set; }

        public virtual Chofere? IdChoferNavigation { get; set; }
        public virtual Cliente? IdClienteNavigation { get; set; }
        public virtual Localidade? IdLocalidadNavigation { get; set; }
        public virtual Provincium? IdProvinciaNavigation { get; set; }
    }
}
