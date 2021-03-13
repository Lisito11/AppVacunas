using AppVacunas.Server.DTOs.Direccion;
using AppVacunas.Server.DTOs.Vacuna;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppVacunas.Server.DTOs.Pais {
    public class PaisDTO : PaisCreacionDTO {
        public int Id { get; set; }
        public virtual ICollection<ProvinciaDTO> Provincia { get; set; }
        public virtual ICollection<VacunaDTO> Vacunas { get; set; }
    }
}
