﻿using System;
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
        [RegularExpression("[a-z A-Z]{0,30}", ErrorMessage = "Primera letra Mayuscula y Solo ingrese texto")]
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Fecha Nacimiento")]
        public DateTime? FechaNacimiento { get; set; }
        [Display(Name = "Tipo Documento")]
        public int? IdTdocuC { get; set; }
        [Display(Name = "N° Documento")]
        [StringLength(maximumLength: 8, MinimumLength = 8, ErrorMessage = "La logintud del campo {0} debe contener {1} digitos")]
        [RegularExpression("[0-9]{8,8}", ErrorMessage = "En el campo {0} solo ingrese números")]
        public string Ndocumento { get; set; }
        [Display(Name = "N° Trámite")]
        [StringLength(maximumLength: 11, MinimumLength = 11, ErrorMessage = "La logintud del campo {0} debe contener {1} digitos")]
        [RegularExpression("[0-9]{11,11}", ErrorMessage = "En el campo {0} solo ingrese números")]
        public string NuTramite { get; set; }
        
        [StringLength(maximumLength: 11, MinimumLength = 11, ErrorMessage = "La logintud del campo {0} debe contener {1} digitos")]
        [RegularExpression("[0-9]{11,11}", ErrorMessage = "En el campo {0} solo ingrese números")]
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
