using AppVacunas.Server.DTOs;
using AppVacunas.Server.DTOs.Persona;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppVacunas.Server.Controllers {
    [ApiController]
    [Route("api/personas")]
    public class PersonaController : CustomBaseController {
        private readonly dfd2guu5v5usvlContext context;
        private readonly IMapper mapper;
        public PersonaController(dfd2guu5v5usvlContext context, IMapper mapper) : base(context, mapper) {
            this.context = context;
            this.mapper = mapper;
        }
        //Metodo Get
        [HttpGet]
        public async Task<ActionResult<List<PersonaDTO>>> GetVacunados() {
            var vacunados = await context.Personas
                .Where(x => x.EstatusVacuna == 1)
                .Include(x => x.Vacuna)
                .Include(x => x.Direccion)
                .ThenInclude(x=> x.Provincia)
                .ThenInclude(x => x.Pais)
                .ToListAsync();
            return mapper.Map<List<PersonaDTO>>(vacunados);      
        }
     
        //Metodo Get(id)
        [HttpGet("{id:int}", Name = "obtenerPersona")]
        public async Task<ActionResult<PersonaDTO>> Get(int id) {
            var vacunados = await context.Personas
                 .Where(x => x.EstatusVacuna == 1)
                 .Include(x => x.Vacuna)
                 .Include(x => x.Direccion)
                 .ThenInclude(x => x.Provincia)
                 .ThenInclude(x => x.Pais)
                 .FirstOrDefaultAsync(x=>x.Id == id);
            return mapper.Map<PersonaDTO>(vacunados);
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
        [HttpPatch("{id:int}")]
        public async Task<ActionResult> Patch(int id) {
            return await Patch<Persona, PersonaDTO>(id);
        }




    }
}
