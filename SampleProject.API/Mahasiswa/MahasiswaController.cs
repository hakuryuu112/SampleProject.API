using MediatR;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleProject.API.Mahasiswa
{
    //Percobaan 1
    [Route("api/mahasiswa")]
    [ApiController]
    public class MahasiswaController
    {
        private readonly IMediator mediator;
    }
}
