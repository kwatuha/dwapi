﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using Dwapi.Domain;
using Dwapi.ExtractsManagement.Core.Commands;
using Dwapi.ExtractsManagement.Core.Services;
using Dwapi.SettingsManagement.Core.Model;
using Dwapi.SharedKernel.Model;
using NPoco;

namespace Dwapi.ExtractsManagement.Core.Extractors
{
    public class PatientArtExtractor : IExtractor
    {
        private readonly IExtractUnitOfWork _unitOfWork;
        private Func<IDatabase> _databaseFactory;

        public PatientArtExtractor(IExtractUnitOfWork unitOfWork)
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

                IList<TempPatientArtExtract> tempPatientArtExtracts;
                using (var database = _databaseFactory())
                    tempPatientArtExtracts = await database.FetchAsync<TempPatientArtExtract>(extract.SqlQuery);

                await _unitOfWork.Repository<TempPatientArtExtract>().AddRangeAsync(tempPatientArtExtracts);
                await _unitOfWork.SaveAsync();

            }

            catch (Exception ex)
            {
                throw;
            }
        }
    }
}