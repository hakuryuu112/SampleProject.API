using MediatR;
using SampleProject.Application.Configuration.Commands;
using SampleProject.Application.Configuration.Data;
using SampleProject.Domain.Mahasiswa;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SampleProject.Application.Mahasiswa.ChangeMahasiswa
{
    public class ChangeMahasiswaCommandHandler : ICommandHandler<ChangeMahasiswaCommand, Unit>
    {
        private readonly IMahasiswaRepository _mahasiswaRepository;

        private readonly ISqlConnectionFactory _sqlConnectionFactory;

        internal ChangeMahasiswaCommandHandler(IMahasiswaRepository mahasiswaRepository, ISqlConnectionFactory sqlConnectionFactory)
        {
            this._mahasiswaRepository = mahasiswaRepository;
            _sqlConnectionFactory = sqlConnectionFactory;
        }

        public async Task<Unit> Handle (ChangeMahasiswaCommand request, CancellationToken cancellationToken)
        {
            var mahasiswaId = new MahasiswaId(request.id);
            var mahasiswa = await this._mahasiswaRepository.GetByIdAsync(new MahasiswaId(request.id));

            mahasiswa.ChangeMahasiswa(
                mahasiswaId,
                request.name,
                request.nim,
                request.sex,
                request.city,
                request.country,
                request.date,
                request.address);

            return Unit.Value;
        }

    }
}
