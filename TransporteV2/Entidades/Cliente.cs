using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace TransporteV2.Entidades
{
    public partial class Cliente
    {
        public Cliente()
        {
            Viajes = new HashSet<Viaje>();
        }

        public int IdCliente { get; set; }
        [RegularExpression("[a-z A-Z]{0,30}", ErrorMessage = "Primera letra Mayuscula y Solo ingrese texto")]
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        [Display(Name = "Razón_Social")]
        public string RazonSocial { get; set; }
        [StringLength(maximumLength: 11, MinimumLength = 11, ErrorMessage = "La logintud del campo {0} debe contener {1} digitos")]
        [RegularExpression("[0-9]{11,11}", ErrorMessage = "En el campo {0} solo ingrese números")]
        public string Cuit { get; set; }
        [Display(Name = "Provincia")]
        public int IdProvincia { get; set; }
        public string Direccion { get; set; }
        [Display(Name = "Código_Postal")]
        public int CodigoPostal { get; set; }
        [EmailAddress(ErrorMessage = "El campo debe ser un correo electrónico válido")]
        public string Email { get; set; }
        public int Telefono { get; set; }
        [Display(Name = "Condición_Iva")]
        public int IdCondicionIva { get; set; }
        [Display(Name = "Ingresos_Brutos")]
        public string IngresosBrutos { get; set; }
        [Display(Name = "Condición_Iva")]
        public virtual CondicionIva IdCondicionIvaNavigation { get; set; }
        [Display(Name = "Provincia")]
        public virtual Provincium IdProvinciaNavigation { get; set; }
        public virtual ICollection<Viaje> Viajes { get; set; }
    }
}
