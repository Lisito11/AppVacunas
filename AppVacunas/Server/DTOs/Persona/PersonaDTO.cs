using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppVacunas.Server.DTOs.Direccion;
using AppVacunas.Server.DTOs.Vacuna;

namespace AppVacunas.Server.DTOs {
    public class PersonaDTO: PersonaCreacionDTO {
        public int Id { get; set; }
        public virtual DireccionDTO Direccion { get; set; }
        public virtual VacunaDTO Vacuna { get; set; }
    }
}
