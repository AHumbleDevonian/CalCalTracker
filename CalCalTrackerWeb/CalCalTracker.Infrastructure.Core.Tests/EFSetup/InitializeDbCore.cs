using CalCalTracker.Infrastructure.Core.Tests.CommonSteps;
using CalCalTracker.Persistence.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace CalCalTracker.Infrastructure.Core.Tests.EFSetup
{
    [Binding]
    public class InitializeDbCore
    {
        [Given(@"I have a valid database connection")]
        public void GivenIHaveAValidDatabaseConnection()
        {
            if(CommonData.db == null)
            {
                var optionsBuilder = new DbContextOptionsBuilder<CalCalTrackerContext>();
                var options = optionsBuilder.UseInMemoryDatabase("temp_db").Options;
                CommonData.db = new CalCalTrackerContext(options);
            }
        }
    }
}
