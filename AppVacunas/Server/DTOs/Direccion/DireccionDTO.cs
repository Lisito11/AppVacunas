using AppVacunas.Server.DTOs.Pais;
using AppVacunas.Server.DTOs.Persona;
using AppVacunas.Server.DTOs.Provincia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppVacunas.Server.DTOs.Direccion {
    public class DireccionDTO: DireccionCreacionDTO {
        public int Id { get; set; }
        public virtual PaisDireccionDTO Pais { get; set; }
        public virtual ProvinciaDireccionDTO Provincia { get; set; }
        public virtual ICollection<PersonaDireccionDTO> Personas { get; set; }
    }
}
