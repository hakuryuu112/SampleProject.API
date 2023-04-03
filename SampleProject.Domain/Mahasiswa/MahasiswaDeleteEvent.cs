using SampleProject.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampleProject.Domain.Mahasiswa
{
    public class MahasiswaDeleteEvent : DomainEventBase
    {
        public MahasiswaId id { get; }

        public MahasiswaDeleteEvent(MahasiswaId id)
        {
            this.id = id;
        }
    }
}
