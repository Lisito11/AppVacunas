using AppVacunas.Server.Helpers;
using System;
using System.Collections.Generic;

#nullable disable

namespace AppVacunas.Server
{
    public partial class Provincia : IId {
        public Provincia()
        {
            Direcciones = new HashSet<Direccion>();
        }

        public int Id { get; set; }
        public string NombreProvincia { get; set; }
        public int? PaisId { get; set; }

        public virtual Pais Pais { get; set; }
        public virtual ICollection<Direccion> Direcciones { get; set; }
    }
}
