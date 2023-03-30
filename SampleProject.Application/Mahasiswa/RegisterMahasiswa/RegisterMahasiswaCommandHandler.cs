using System.Threading;
using System.Threading.Tasks;
using SampleProject.Application.Configuration.Commands;
using SampleProject.Domain.Mahasiswa;
using SampleProject.Domain.SeedWork;

namespace SampleProject.Application.Mahasiswa.RegisterMahasiswa
{
    public class RegisterMahasiswaCommandHandler : ICommandHandler<RegisterMahasiswaCommand, MahasiswaDTO>
    {
        private readonly IMahasiswaRepository _mahasiswaRepository;
        private readonly IUnitOfWork _unitOfWork;
        public RegisterMahasiswaCommandHandler(IMahasiswaRepository mahasiswaRepository, IUnitOfWork unitOfWork)
        {
            this._mahasiswaRepository = mahasiswaRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<MahasiswaDTO> Handle(RegisterMahasiswaCommand request, CancellationToken cancellationToken)
        {
            var mahasiswa = Mahasiswas.CreateMahasiswa(request.name, request.nim, request.sex, request.city, request.country, request.date, request.address);

            await this._mahasiswaRepository.AddAsync(mahasiswa);

            await this._unitOfWork.CommitAsync(cancellationToken);

            return new MahasiswaDTO { Id = mahasiswa.Id.Value };
        }
    }
}
