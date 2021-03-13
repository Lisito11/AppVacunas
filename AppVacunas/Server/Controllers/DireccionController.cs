using AppVacunas.Server.DTOs.Direccion;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppVacunas.Server.Controllers {
    [ApiController]
    [Route("api/direcciones")]
    public class DireccionController : CustomBaseController {
        private readonly dfd2guu5v5usvlContext context;
        private readonly IMapper mapper;
        public DireccionController(dfd2guu5v5usvlContext context, IMapper mapper) : base(context, mapper) {
            this.context = context;
            this.mapper = mapper;
        }

        //Metodo Get
        [HttpGet]
        public async Task<ActionResult<List<DireccionDTO>>> Get() {
            var direcciones = await context.Direcciones.Include(x => x.Pais).Include(x => x.Provincia).Include(x=> x.Personas).ToListAsync();
            return mapper.Map<List<DireccionDTO>>(direcciones);
        }


        [HttpGet("provincias")]
        public async Task<ActionResult<List<DireccionDTO>>> GetProvincias() {
            var direcciones = await context.Direcciones.Include(x => x.Provincia).Include(x => x.Personas).ToListAsync();

            dynamic provincias() => context.Direcciones.GroupBy(p => p.Provincia).Select(group => new {
                NombreCategoria = group.Key,
                CantidadProducto = group.Count()
            });

            return mapper.Map<List<DireccionDTO>>(direcciones);
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
