using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppVacunas.Server.DTOs.Vacuna {
    public class VacunaCreacionDTO {
        public string Nombre { get; set; }
        public string NombreOrganizacion { get; set; }
        public int? CantidadDias { get; set; }
        public int? CantidadVacuna { get; set; }
        public int? PaisId { get; set; }
    }
}
