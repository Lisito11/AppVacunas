using AppVacunas.Server.Helpers;
using System;
using System.Collections.Generic;

#nullable disable

namespace AppVacunas.Server
{
    public partial class Vacuna : IId {
        public Vacuna()
        {
            Personas = new HashSet<Persona>();
        }

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
