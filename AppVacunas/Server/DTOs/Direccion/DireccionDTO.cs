using AppVacunas.Server.DTOs.Pais;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppVacunas.Server.DTOs.Direccion {
    public class DireccionDTO: DireccionCreacionDTO {
        public int Id { get; set; }
        public virtual PaisDTO Pais { get; set; }
        public virtual ProvinciaDTO Provincia { get; set; }
        public virtual ICollection<PersonaDTO> Personas { get; set; }
    }
}
