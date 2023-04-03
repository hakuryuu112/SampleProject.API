using MediatR;
using SampleProject.Application.Configuration.Commands;
using SampleProject.Domain.Mahasiswa;
using SampleProject.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SampleProject.Application.Mahasiswa.RemoveMahasiswa
{
    public class DeleteMahasiswaCommandHandler : ICommandHandler<DeleteMahasiswaCommand>
    {
        private readonly IMahasiswaRepository _mahasiswaRepository;
        private readonly IUnitOfWork _unitOfWork;

        public DeleteMahasiswaCommandHandler(IMahasiswaRepository mahasiswaRepository)
        {
            this._mahasiswaRepository = mahasiswaRepository;
        }

        public async Task<Unit> Handle (DeleteMahasiswaCommand request, CancellationToken cancellationToken)
        {
            var mahasiswa = await this._mahasiswaRepository.GetByIdAsync(new MahasiswaId(request.id));

            await this._mahasiswaRepository.DeleteAsync(mahasiswa);

            mahasiswa.DeleteMahasiswa(new MahasiswaId(request.id));

            return Unit.Value;
        }
    }
}
