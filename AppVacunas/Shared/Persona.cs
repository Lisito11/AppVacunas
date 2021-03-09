using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppVacunas.Shared {
    public class Persona {
        public int Id { get; set; }
        public virtual Direccion Direccion { get; set; }
        public virtual Vacuna Vacuna { get; set; }
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
