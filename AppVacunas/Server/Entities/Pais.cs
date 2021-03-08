using AppVacunas.Server.Helpers;
using System;
using System.Collections.Generic;

#nullable disable

namespace AppVacunas.Server
{
    public partial class Pais : IId {
        public Pais()
        {
            Direcciones = new HashSet<Direccion>();
            Provincia = new HashSet<Provincia>();
            Vacunas = new HashSet<Vacuna>();
        }

        public int Id { get; set; }
        public string NombrePais { get; set; }

        public virtual ICollection<Direccion> Direcciones { get; set; }
        public virtual ICollection<Provincia> Provincia { get; set; }
        public virtual ICollection<Vacuna> Vacunas { get; set; }
    }
}
