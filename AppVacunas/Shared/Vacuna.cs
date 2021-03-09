using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppVacunas.Shared {
    public class Vacuna {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string NombreOrganizacion { get; set; }
        public int? CantidadDias { get; set; }
        public int? CantidadVacuna { get; set; }
        public int? PaisId { get; set; }
        public virtual Pais Pais { get; set; }
        public virtual ICollection<Persona> Personas { get; set; }
    }
}
