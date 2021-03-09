using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppVacunas.Shared {
    public class Provincia {
        public string NombreProvincia { get; set; }
        public int? PaisId { get; set; }
        public int Id { get; set; }
        public virtual Pais Pais { get; set; }
        public virtual ICollection<Direccion> Direcciones { get; set; }
    }
}
