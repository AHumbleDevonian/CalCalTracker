using CalCalTracker.Infrastructure.Core.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace CalCalTracker.Infrastructure.Core.Tests.CommonSteps
{
    [Binding]
    public class Steps
    {
        [Given(@"I have an instance of UserService")]
        public void GivenIHaveAnInstanceOfUserService()
        {
            if(CommonData.userService == null)
            {
                CommonData.userService = new UserServiceCore(CommonData.db);
            }            
        }
    }
}
