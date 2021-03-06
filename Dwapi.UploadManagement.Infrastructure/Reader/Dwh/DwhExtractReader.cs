﻿using System;
using System.Collections.Generic;
using System.Linq;
using Dwapi.SharedKernel.Model;
using Dwapi.UploadManagement.Core.Interfaces.Reader.Dwh;
using Dwapi.UploadManagement.Core.Model.Dwh;
using Dwapi.UploadManagement.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Dwapi.UploadManagement.Infrastructure.Reader.Dwh
{
    public class DwhExtractReader:IDwhExtractReader
    {
        private readonly UploadContext _context;

        public DwhExtractReader(UploadContext context)
        {
            _context = context;
        }

        public IEnumerable<SitePatientProfile> ReadProfiles()
        {
            return
                _context.ClientPatientExtracts.AsNoTracking()
                .Select(x =>
                    new SitePatientProfile(x.SiteCode, x.FacilityName, x.PatientPK)
                );
        }

        public IEnumerable<Guid> ReadAllIds()
        {
            return _context.ClientPatientExtracts.Where(x=>!x.IsSent).AsNoTracking().Select(x=>x.Id);
        }

        public PatientExtractView Read(Guid id)
        {
            var p = _context.ClientPatientExtracts.SingleOrDefault(x => x.Id == id);
            if (null != p)
            {
                p.PatientArtExtracts =
                    _context.ClientPatientArtExtracts.Where(x =>
                        x.PatientPK == p.PatientPK && x.SiteCode == p.SiteCode && !x.IsSent);

                p.PatientBaselinesExtracts =
                    _context.ClientPatientBaselinesExtracts.Where(x =>
                        x.PatientPK == p.PatientPK && x.SiteCode == p.SiteCode && !x.IsSent);

                p.PatientLaboratoryExtracts =
                    _context.ClientPatientLaboratoryExtracts.Where(x =>
                        x.PatientPK == p.PatientPK && x.SiteCode == p.SiteCode && !x.IsSent);

                p.PatientPharmacyExtracts =
                    _context.ClientPatientPharmacyExtracts.Where(x =>
                        x.PatientPK == p.PatientPK && x.SiteCode == p.SiteCode && !x.IsSent);

                p.PatientStatusExtracts =
                    _context.ClientPatientStatusExtracts.Where(x =>
                        x.PatientPK == p.PatientPK && x.SiteCode == p.SiteCode && !x.IsSent);

                p.PatientVisitExtracts =
                    _context.ClientPatientVisitExtracts.Where(x =>
                        x.PatientPK == p.PatientPK && x.SiteCode == p.SiteCode && !x.IsSent);
            }

            return p;
        }
    }
}