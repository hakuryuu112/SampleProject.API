using Dapper;
using SampleProject.Application.Configuration.Data;
using SampleProject.Domain.Mahasiswa;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampleProject.Application.Mahasiswa.DomainServices
{
    public class MahasiswaUniquenessChecker : IMahasiswaUniquenessChecker
    {
        private readonly ISqlConnectionFactory _sqlConnectionFactory;

        public MahasiswaUniquenessChecker(ISqlConnectionFactory sqlConnectionFactory)
        {
            _sqlConnectionFactory = sqlConnectionFactory;
        }

        public bool IsUnique(int mahasiswaNim)
        {
            var connection = this._sqlConnectionFactory.GetOpenConnection();

            const string sql = "SELECT TOP 1 1 FROM [dbo].[Mahasiswa] WHERE nim = @nim";

            var mahasiswaNumber = connection.QuerySingleOrDefault<int?>(sql, 
                new
                {
                    nim = mahasiswaNim
                });

            return !mahasiswaNumber.HasValue;
        }
    }
}
