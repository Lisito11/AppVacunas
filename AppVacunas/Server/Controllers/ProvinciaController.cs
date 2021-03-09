using AppVacunas.Server.DTOs;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppVacunas.Server.Controllers {
    [ApiController]
    [Route("api/provincias")]
    public class ProvinciaController : CustomBaseController {
        public ProvinciaController(dfd2guu5v5usvlContext context, IMapper mapper) : base(context, mapper) { }

        //Metodo Get
        [HttpGet]
        public async Task<ActionResult<List<ProvinciaDTO>>> Get() {
            return await Get<Provincia, ProvinciaDTO>();
        }

        //Metodo Get(id)
        [HttpGet("{id:int}", Name = "obtenerProvincia")]
        public async Task<ActionResult<ProvinciaDTO>> Get(int id) {
            return await Get<Provincia, ProvinciaDTO>(id);
        }

        //Metodo Post
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] ProvinciaCreacionDTO provinciaCreacionDTO) {
            return await Post<ProvinciaCreacionDTO, Provincia, ProvinciaDTO>(provinciaCreacionDTO, "obtenerProvincia");
        }

        //Metodo Put
        [HttpPut("{id:int}")]
        public async Task<ActionResult> Put(int id, [FromBody] ProvinciaCreacionDTO provinciaCreacionDTO) {
            return await Put<ProvinciaCreacionDTO, Provincia>(id, provinciaCreacionDTO);
        }

        //Metodo Patch
        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Patch(int id) {
            return await Patch<Provincia, ProvinciaDTO>(id);
        }


    }
}
