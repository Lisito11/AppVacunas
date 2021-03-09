using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppVacunas.Shared {
    public class Pais {
        public int Id { get; set; }
        public string NombrePais { get; set; }
        public virtual ICollection<Direccion> Direcciones { get; set; }
        public virtual ICollection<Provincia> Provincia { get; set; }
        public virtual ICollection<Vacuna> Vacunas { get; set; }
    }
}

