using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace TransporteV2.Entidades
{
    public partial class Chofere
    {
        public Chofere()
        {
            LicenciaChofers = new HashSet<LicenciaChofer>();
            Viajes = new HashSet<Viaje>();
        }

        public int IdChofer { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Fecha Nacimiento")]
        public DateTime? FechaNacimiento { get; set; }
        [Display(Name = "Tipo Documento")]
        public int? IdTdocuC { get; set; }
        [Display(Name = "N° Documento")]
        [RegularExpression("[0-9]{8,8}", ErrorMessage = "EL campo {0} debe tener 8 digitos")]
        public string Ndocumento { get; set; }
        [Display(Name = "N° Trámite")]
        public string NuTramite { get; set; }
        [RegularExpression("[0-9]{11,11}", ErrorMessage = "EL campo solo debe contener números y 11 digitos")]
        public string Cuil { get; set; }
        [Display(Name = "Provincia")]
        public int? IdProvincia { get; set; }
        public string Direccion { get; set; }
        [EmailAddress(ErrorMessage = "El campo debe ser un correo electrónico válido")]
        public string Email { get; set; }
        public string Celular { get; set; }
        [Display(Name = "Fecha Alta")]
        [DataType(DataType.Date)]
        public DateTime? FechaAlta { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Fecha Baja")]
        public DateTime? FechaBaja { get; set; }
        [Display(Name = "Provincia")]
        public virtual Provincium IdProvinciaNavigation { get; set; }
        [Display(Name = "Tipo Documento")]
        public virtual TdocumentoC IdTdocuCNavigation { get; set; }
        public virtual ICollection<LicenciaChofer> LicenciaChofers { get; set; }
        public virtual ICollection<Viaje> Viajes { get; set; }
    }
}
