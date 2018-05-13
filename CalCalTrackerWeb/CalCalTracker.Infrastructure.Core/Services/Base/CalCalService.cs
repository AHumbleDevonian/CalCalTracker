using CalCalTracker.Persistence.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalCalTracker.Infrastructure.Core.Services.Base
{
    public class CalCalService
    {
        protected CalCalTrackerContext _db;

        protected CalCalService(CalCalTrackerContext db)
        {
            _db = db;
        }
    }
}
