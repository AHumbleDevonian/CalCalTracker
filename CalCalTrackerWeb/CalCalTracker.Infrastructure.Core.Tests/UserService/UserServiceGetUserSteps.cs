using CalCalTracker.Infrastructure.Core.Tests.CommonSteps;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace CalCalTracker.Infrastructure.Core.Tests.UserService
{
    [Binding]
    public class UserServiceGetUserSteps
    {
        [Given(@"I have created a user for GetUser and added it")]
        public void GivenIHaveCreatedAUserForGetUserAndAddedIt()
        {
            var userForGetUser = new Domain.EFCore.User() {
                FirstName = "UserForGetUserTestAFirstName",
                LastName = "UserForGetUserTestALastName",
                DateOfBirth = DateTime.Now.AddYears(-22),
                Gender = Domain.Enums.Gender.Male,
                Weight = 81
            };
            CommonData.db.Users.Add(userForGetUser);
            CommonData.db.SaveChanges();
            UserServiceData.userForGetUser = userForGetUser;
        }

        [When(@"I use the GetUser function")]
        public async Task WhenIUseTheGetUserFunction()
        {
            UserServiceData.getUserDto = await CommonData.userService.GetUser(UserServiceData.userForGetUser.Id);
        }

        [Then(@"the returned user should match the GetUser original")]
        public void ThenTheReturnedUserShouldMatchTheGetUserOriginal()
        {
            Assert.IsNotNull(UserServiceData.getUserDto);
            Assert.AreEqual(UserServiceData.userForGetUser.FirstName, UserServiceData.getUserDto.FirstName);
            Assert.AreEqual(UserServiceData.userForGetUser.LastName, UserServiceData.getUserDto.LastName);
            Assert.AreEqual(UserServiceData.userForGetUser.DateOfBirth, UserServiceData.getUserDto.DateOfBirth);
            Assert.AreEqual(UserServiceData.userForGetUser.Gender, UserServiceData.getUserDto.Gender);
            Assert.AreEqual(UserServiceData.userForGetUser.Weight, UserServiceData.getUserDto.Weight);
        }
    }
}
