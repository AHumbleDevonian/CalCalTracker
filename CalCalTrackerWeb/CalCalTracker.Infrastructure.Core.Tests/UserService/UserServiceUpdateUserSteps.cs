using CalCalTracker.Infrastructure.Core.Tests.CommonSteps;
using CalCalTracker.Infrastructure.Dtos;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace CalCalTracker.Infrastructure.Core.Tests.UserService
{
    [Binding]
    public class UserServiceUpdateUserSteps
    {
        [Given(@"I have created a user for UpdateUser and added it")]
        public void GivenIHaveCreatedAUserForUpdateUserAndAddedIt()
        {
            var originalUserForUpdateUser = new Domain.EFCore.User()
            {
                FirstName = "UserForUpdateUserTestAFirstName",
                LastName = "UserForUpdateUserTestALastName",
                DateOfBirth = DateTime.Now.AddYears(-24),
                Gender = Domain.Enums.Gender.Male,
                Weight = 73
            };
            var changesForUserForUpdateUser = new UpdateUserDto()
            {
                FirstName = "UserForUpdateUserTestBFirstName",
                LastName = "UserForUpdateUserTestBLastName",
                DateOfBirth = DateTime.Now.AddYears(-26),
                Gender = Domain.Enums.Gender.Female,
                Weight = 65
            };
            CommonData.db.Users.Add(originalUserForUpdateUser);
            CommonData.db.SaveChanges();
            UserServiceData.originalUserForUpdateUser = originalUserForUpdateUser;
            UserServiceData.updateUserDto = changesForUserForUpdateUser;
        }

        [When(@"I use the UpdateUser function")]
        public async Task WhenIUseTheUpdateUserFunction()
        {
            UserServiceData.updateUserGetUserDto = await CommonData.userService.UpdateUser(UserServiceData.updateUserDto);
        }

        [Then(@"the returned user should match the UpdateUser original")]
        public void ThenTheReturnedUserShouldMatchTheUpdateUserOriginal()
        {
            Assert.IsNotNull(UserServiceData.updateUserGetUserDto);

            Assert.AreNotEqual(UserServiceData.originalUserForUpdateUser.FirstName, UserServiceData.updateUserGetUserDto.FirstName);
            Assert.AreNotEqual(UserServiceData.originalUserForUpdateUser.LastName, UserServiceData.updateUserGetUserDto.LastName);
            Assert.AreNotEqual(UserServiceData.originalUserForUpdateUser.DateOfBirth, UserServiceData.updateUserGetUserDto.DateOfBirth);
            Assert.AreNotEqual(UserServiceData.originalUserForUpdateUser.Gender, UserServiceData.updateUserGetUserDto.Gender);
            Assert.AreNotEqual(UserServiceData.originalUserForUpdateUser.Weight, UserServiceData.updateUserGetUserDto.Weight);

            Assert.AreEqual(UserServiceData.updateUserDto.FirstName, UserServiceData.updateUserGetUserDto.FirstName);
            Assert.AreEqual(UserServiceData.updateUserDto.LastName, UserServiceData.updateUserGetUserDto.LastName);
            Assert.AreEqual(UserServiceData.updateUserDto.DateOfBirth, UserServiceData.updateUserGetUserDto.DateOfBirth);
            Assert.AreEqual(UserServiceData.updateUserDto.Gender, UserServiceData.updateUserGetUserDto.Gender);
            Assert.AreEqual(UserServiceData.updateUserDto.Weight, UserServiceData.updateUserGetUserDto.Weight);
        }
    }
}
