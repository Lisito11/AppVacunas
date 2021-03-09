using AppVacunas.Server.DTOs;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppVacunas.Server.Controllers {
    [ApiController]
    [Route("api/personas")]
    public class PersonaController : CustomBaseController {
        public PersonaController(dfd2guu5v5usvlContext context, IMapper mapper) : base(context, mapper) {}

        //Metodo Get
        [HttpGet]
        public async Task<ActionResult<List<PersonaDTO>>> Get() {
            return await Get<Persona, PersonaDTO>();
        }

        //Metodo Get(id)
        [HttpGet("{id:int}", Name = "obtenerPersona")]
        public async Task<ActionResult<PersonaDTO>> Get(int id) {
            return await Get<Persona, PersonaDTO>(id);
        }

        //Metodo Post
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] PersonaCreacionDTO personaCreacionDTO) {
            return await Post<PersonaCreacionDTO, Persona, PersonaDTO>(personaCreacionDTO, "obtenerPersona");
        }

        //Metodo Put
        [HttpPut("{id:int}")]
        public async Task<ActionResult> Put(int id, [FromBody] PersonaCreacionDTO personaCreacionDTO) {
            return await Put<PersonaCreacionDTO, Persona>(id, personaCreacionDTO);
        }

        //Metodo Patch
        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Patch(int id) {
            return await Patch<Persona, PersonaDTO>(id);
        }


    }
}
