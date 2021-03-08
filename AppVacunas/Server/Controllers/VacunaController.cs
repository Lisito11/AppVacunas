using AppVacunas.Server.DTOs.Vacuna;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppVacunas.Server.Controllers {
    [ApiController]
    [Route("api/vacuna")]
    public class VacunaController : CustomBaseController {
        public VacunaController(dfd2guu5v5usvlContext context, IMapper mapper) : base(context, mapper) { }

        //Metodo Get
        [HttpGet]
        public async Task<ActionResult<List<VacunaDTO>>> Get() {
            return await Get<Vacuna, VacunaDTO>();
        }

        //Metodo Get(id)
        [HttpGet("{id:int}", Name = "obtenerVacuna")]
        public async Task<ActionResult<VacunaDTO>> Get(int id) {
            return await Get<Vacuna, VacunaDTO>(id);
        }

        //Metodo Post
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] VacunaCreacionDTO vacunaCreacionDTO) {
            return await Post<VacunaCreacionDTO, Vacuna, VacunaDTO>(vacunaCreacionDTO, "obtenerVacuna");
        }

        //Metodo Put
        [HttpPut("{id:int}")]
        public async Task<ActionResult> Put(int id, [FromBody] VacunaCreacionDTO vacunaCreacionDTO) {
            return await Put<VacunaCreacionDTO, Vacuna>(id, vacunaCreacionDTO);
        }

        //Metodo Patch
        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Patch(int id) {
            return await Patch<Vacuna, VacunaDTO>(id);
        }


    }
}
