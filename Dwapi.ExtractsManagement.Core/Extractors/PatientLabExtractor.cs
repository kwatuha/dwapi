﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using Dwapi.Domain;
using Dwapi.ExtractsManagement.Core.Commands;
using Dwapi.ExtractsManagement.Core.Services;
using Dwapi.SharedKernel.Model;
using NPoco;

namespace Dwapi.ExtractsManagement.Core.Extractors
{
    public class PatientLabExtractor : IExtractor
    {
        private readonly IExtractUnitOfWork _unitOfWork;
        private Func<IDatabase> _databaseFactory;

        public PatientLabExtractor(IExtractUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task Extract(DwhExtract extract, DbProtocol dbProtocol)
        {
            try
            {
                switch (dbProtocol.DatabaseType)
                {
                    case SharedKernel.Enum.DatabaseType.MicrosoftSQL:
                        _databaseFactory = ()
                            => new Database(dbProtocol.GetConnectionString(), NPoco.DatabaseType.SqlServer2012, SqlClientFactory.Instance);
                        break;

                    case SharedKernel.Enum.DatabaseType.MySQL:
                        _databaseFactory = ()
                            => new Database(dbProtocol.GetConnectionString(), NPoco.DatabaseType.MySQL, SqlClientFactory.Instance);
                        break;

                    default:
                        throw new InvalidOperationException();
                }

                IList<TempPatientLaboratoryExtract> tempPatientLabExtracts;
                using (var database = _databaseFactory())
                    tempPatientLabExtracts = await database.FetchAsync<TempPatientLaboratoryExtract>(extract.SqlQuery);
                await _unitOfWork.Repository<TempPatientLaboratoryExtract>().AddRangeAsync(tempPatientLabExtracts);
                await _unitOfWork.SaveAsync();
            }

            catch (Exception ex)
            {
                throw;
            }
        }
    }
}