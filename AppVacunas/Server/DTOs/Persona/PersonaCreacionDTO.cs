using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppVacunas.Server.DTOs {
    public class PersonaCreacionDTO {

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
    }
}
