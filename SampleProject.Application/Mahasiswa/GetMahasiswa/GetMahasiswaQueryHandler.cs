using Dapper;
using SampleProject.Application.Configuration.Data;
using SampleProject.Application.Configuration.Queries;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SampleProject.Application.Mahasiswa.GetMahasiswa
{
    internal sealed class GetMahasiswaQueryHandler : IQueryHandler<GetMahasiswaQuery, List<MahasiswaDTO>>
    {
        private readonly ISqlConnectionFactory _sqlConnectionFactory;

        internal GetMahasiswaQueryHandler(ISqlConnectionFactory sqlConnectionFactory)
        {
            this._sqlConnectionFactory = sqlConnectionFactory;
        }

        public async Task<List<MahasiswaDTO>> Handle (GetMahasiswaQuery request, CancellationToken cancellationToken)
        {
            var connection = this._sqlConnectionFactory.GetOpenConnection();
            const string sql = "SELECT * " +
                               "FROM dbo.Mahasiswa WHERE id = @id";

            var mahasiswa = await connection.QueryAsync<MahasiswaDTO>(sql, new { request.id });

            return mahasiswa.AsList();
        }
    }
}
