using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using SampleProject.Application.Mahasiswa;
using SampleProject.Application.Mahasiswa.GetMahasiswa;
using SampleProject.Application.Mahasiswa.RegisterMahasiswa;

namespace SampleProject.API.Mahasiswa
{
    //Percobaan 1
    [Route("api/mahasiswa")]
    [ApiController]
    public class MahasiswaController : Controller
    {
        private readonly IMediator _mediator;

        public MahasiswaController(IMediator mediator)
        {
            this._mediator = mediator;
        }

        [Route("{id}")]
        [HttpGet]
        [ProducesResponseType(typeof(List<MahasiswaDTO>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetMahasiswa(Guid id)
        {
            var getMahasiswa = await _mediator.Send(new GetMahasiswaQuery(id));

            return Ok(getMahasiswa);
        }

        // Add Create in Table dbo.Mahasiswa
        [Route("")]
        [HttpPost]
        [ProducesResponseType(typeof(MahasiswaDTO), (int)HttpStatusCode.Created)]
        public async Task<IActionResult> RegisterMahasiswa([FromBody]RegisterMahasiswaRequest request)
        {
            var mahasiswa = await _mediator.Send(new RegisterMahasiswaCommand(
                request.name, 
                request.nim, 
                request.sex, 
                request.city,
                request.country, 
                request.date, 
                request.address
                ));

            return Created(string.Empty, mahasiswa);
        }
    }
}
