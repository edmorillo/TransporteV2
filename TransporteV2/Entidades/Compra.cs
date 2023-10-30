using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace TransporteV2.Entidades
{
    public partial class Compra
    {
        public int IdCompra { get; set; }
        public int? Cantidad { get; set; }
        public string Detalle { get; set; }
        public decimal? Precio { get; set; }
        [Display(Name = "Forma_Pago")]

        public int IdFormaPago { get; set; }
        [Display(Name = "Fecha_Compra")]
        public DateTime? FechaCompra { get; set; }
        [Display(Name = "Forma_Pago")]
        public virtual FormasPago IdFormaPagoNavigation { get; set; }
    }
}
