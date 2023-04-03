using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SampleProject.Domain.Mahasiswa
{
    public interface IMahasiswaRepository
    {
        Task<Mahasiswas> GetByIdAsync(MahasiswaId id);

        Task AddAsync(Mahasiswas mahasiswas);
        Task DeleteAsync(Mahasiswas mahasiswas);
    }
}
