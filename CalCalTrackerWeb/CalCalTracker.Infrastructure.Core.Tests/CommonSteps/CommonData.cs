using CalCalTracker.Infrastructure.Services.Interfaces;
using CalCalTracker.Persistence.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalCalTracker.Infrastructure.Core.Tests.CommonSteps
{
    public static class CommonData
    {
        public static CalCalTrackerContext db;

        public static IUserService userService;
    }
}
