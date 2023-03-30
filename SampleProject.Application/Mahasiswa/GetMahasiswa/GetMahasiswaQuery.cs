using SampleProject.Application.Configuration.Queries;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampleProject.Application.Mahasiswa.GetMahasiswa
{
    public class GetMahasiswaQuery : IQuery<List<MahasiswaDTO>>
    {
        public Guid id { get; }

        public GetMahasiswaQuery(Guid id)
        {
            this.id = id;
        }
    }
}
