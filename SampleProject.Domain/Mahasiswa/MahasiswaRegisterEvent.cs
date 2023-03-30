using SampleProject.Domain.SeedWork;

namespace SampleProject.Domain.Mahasiswa
{
    public class MahasiswaRegisterEvent : DomainEventBase
    {
        public MahasiswaId MahasiswaId { get; }

        public MahasiswaRegisterEvent(MahasiswaId mahasiswaId)
        {
            this.MahasiswaId = mahasiswaId;
        }
    }
}
