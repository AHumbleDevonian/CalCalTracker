using CalCalTracker.Infrastructure.Core.Tests.CommonSteps;
using CalCalTracker.Infrastructure.Dtos;
using NUnit.Framework;
using System;
using System.Linq;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace CalCalTracker.Infrastructure.Core.Tests.UserService
{
    [Binding]
    public class UserServiceAddUserSteps
    {
        [Given(@"I have created a user for AddUser")]
        public void GivenIHaveCreatedAUserForAddUser()
        {
            var user = new AddUserDto()
            {
                FirstName = "UserForAddUserTestAFirstName",
                LastName = "UserForAddUserTestALastName",
                DateOfBirth = DateTime.Now.AddYears(-20),
                Gender = Domain.Enums.Gender.Female,
                Weight = 60
            };
            UserServiceData.addUserDto = user;
        }
        
        [When(@"I use the AddUser function")]
        public async Task WhenIUseTheAddUserFunction()
        {
            await CommonData.userService.AddUser(UserServiceData.addUserDto);
        }
        
        [Then(@"I should be added as a new user")]
        public void ThenIShouldBeAddedAsANewUser()
        {
            var savedUser = CommonData.db.Users
                .Where(user => user.FirstName == UserServiceData.addUserDto.FirstName).FirstOrDefault();

            Assert.IsNotNull(savedUser);
            Assert.AreEqual(UserServiceData.addUserDto.FirstName, savedUser.FirstName);
            Assert.AreEqual(UserServiceData.addUserDto.LastName, savedUser.LastName);
            Assert.AreEqual(UserServiceData.addUserDto.DateOfBirth, savedUser.DateOfBirth);
            Assert.AreEqual(UserServiceData.addUserDto.Gender, savedUser.Gender);
            Assert.AreEqual(UserServiceData.addUserDto.Weight, savedUser.Weight);
        }
    }
}
