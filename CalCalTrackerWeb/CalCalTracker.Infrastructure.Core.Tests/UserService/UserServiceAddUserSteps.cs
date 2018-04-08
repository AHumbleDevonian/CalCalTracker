using CalCalTracker.Infrastructure.Core.Dtos;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace CalCalTracker.Infrastructure.Core.Tests.UserService
{
    [Binding]
    public class UserServiceAddUserSteps
    {
        [Given(@"I have created a basic user")]
        public void GivenIHaveCreatedABasicUser()
        {
            var basicUser = new AddUserDto()
            {
                FirstName = "Bob",
            };
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I use the AddUser function")]
        public void WhenIUseTheAddUserFunction()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should be added as a new user")]
        public void ThenIShouldBeAddedAsANewUser()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
