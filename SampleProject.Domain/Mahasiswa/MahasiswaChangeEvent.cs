using SampleProject.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampleProject.Domain.Mahasiswa
{
    public class MahasiswaChangeEvent : DomainEventBase
    {
        public MahasiswaId id { get; }

        public MahasiswaChangeEvent(MahasiswaId id)
        {
            this.id = id;
        }
    }
}
