using SampleProject.Application.Configuration.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampleProject.Application.Mahasiswa.RemoveMahasiswa
{
    public class DeleteMahasiswaCommand : CommandBase
    {
        public Guid id { get; }

        public DeleteMahasiswaCommand(Guid id)
        {
            this.id = id;
        }
    }
}
