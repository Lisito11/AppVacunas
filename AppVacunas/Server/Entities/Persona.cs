using AppVacunas.Server.Helpers;
using System;
using System.Collections.Generic;

#nullable disable

namespace AppVacunas.Server
{
    public partial class Persona : IId {
        public int Id { get; set; }
        public string Cedula { get; set; }
        public string Nombres { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public string Telefono { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public int EstatusVacuna { get; set; }
        public DateTime? FechaDosis1 { get; set; }
        public DateTime? FechaDosis2 { get; set; }
        public int? DireccionId { get; set; }
        public int? VacunaId { get; set; }

        public virtual Direccion Direccion { get; set; }
        public virtual Vacuna Vacuna { get; set; }
    }
}
