using AppVacunas.Server.DTOs.Direccion;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppVacunas.Server.Controllers {
    [ApiController]
    [Route("api/direcciones")]
    public class DireccionController : CustomBaseController {
        public DireccionController(dfd2guu5v5usvlContext context, IMapper mapper) : base(context, mapper) { }

        //Metodo Get
        [HttpGet]
        public async Task<ActionResult<List<DireccionDTO>>> Get() {
            return await Get<Direccion, DireccionDTO>();
        }

        //Metodo Get(id)
        [HttpGet("{id:int}", Name = "obtenerDireccion")]
        public async Task<ActionResult<DireccionDTO>> Get(int id) {
            return await Get<Direccion, DireccionDTO>(id);
        }

        //Metodo Post
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] DireccionCreacionDTO direccionCreacionDTO) {
            return await Post<DireccionCreacionDTO, Direccion, DireccionDTO>(direccionCreacionDTO, "obtenerDireccion");
        }

        //Metodo Put
        [HttpPut("{id:int}")]
        public async Task<ActionResult> Put(int id, [FromBody] DireccionCreacionDTO direccionCreacionDTO) {
            return await Put<DireccionCreacionDTO, Direccion>(id, direccionCreacionDTO);
        }

        //Metodo Patch
        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Patch(int id) {
            return await Patch<Direccion, DireccionDTO>(id);
        }


    }
}
