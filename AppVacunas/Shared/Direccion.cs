using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppVacunas.Shared {
    public class Direccion {
        public decimal? Latitud { get; set; }
        public decimal? Logitud { get; set; }
        public string Calle { get; set; }
        public string Sector { get; set; }
        public int? ProvinciaId { get; set; }
        public int? PaisId { get; set; }
        public int Id { get; set; }
        public virtual Pais Pais { get; set; }
        public virtual Provincia Provincia { get; set; }
        public virtual ICollection<Persona> Personas { get; set; }
    }
}
