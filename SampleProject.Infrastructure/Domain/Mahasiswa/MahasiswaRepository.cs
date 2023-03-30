using Microsoft.EntityFrameworkCore;
using SampleProject.Domain.Mahasiswa;
using SampleProject.Infrastructure.Database;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SampleProject.Infrastructure.Domain.Mahasiswa
{
    public class MahasiswaRepository : IMahasiswaRepository
    {
        private readonly OrdersContext _context;

        public MahasiswaRepository(OrdersContext context)
        {
            this._context = context ?? throw new ArgumentException(nameof(context));
        }

        public async Task AddAsync(Mahasiswas mahasiswas)
        {
            await this._context.Mahasiswa.AddAsync(mahasiswas);
        }

        public async Task<Mahasiswas> GetByIdAsync(MahasiswaId id)
        {
            return await this._context.Mahasiswa.SingleAsync(x => x.Id == id);
        }
    }
}
