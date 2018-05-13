using CalCalTracker.Infrastructure.Core.Tests.CommonSteps;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace CalCalTracker.Infrastructure.Core.Tests.UserService
{
    [Binding]
    public class UserServiceGetUsersSteps
    {
        [Given(@"I have created users for GetUsers and added it")]
        public void GivenIHaveCreatedUsersForGetUsersAndAddedIt()
        {
            var userForGetUsersA = new Domain.EFCore.User()
            {
                FirstName = "UserForGetUsersTestAFirstName",
                LastName = "UserForGetUsersTestALastName",
                DateOfBirth = DateTime.Now.AddYears(-27),
                Gender = Domain.Enums.Gender.Male,
                Weight = 73
            };
            var userForGetUsersB = new Domain.EFCore.User()
            {
                FirstName = "UserForGetUsersTestBFirstName",
                LastName = "UserForGetUsersTestBLastName",
                DateOfBirth = DateTime.Now.AddYears(-32),
                Gender = Domain.Enums.Gender.Female,
                Weight = 75
            };
            CommonData.db.Users.Add(userForGetUsersA);
            CommonData.db.Users.Add(userForGetUsersB);
            CommonData.db.SaveChanges();
            UserServiceData.usersForGetUsers = new List<Domain.EFCore.User>()
            {
                userForGetUsersA,
                userForGetUsersB
            };
        }

        [When(@"I use the GetUsers function")]
        public async Task WhenIUseTheGetUsersFunction()
        {
            var getUsersResult = await CommonData.userService.GetUsers();
            UserServiceData.getUserDtoList = getUsersResult.ToList();
        }

        [Then(@"the returned users should match the GetUsers original")]
        public void ThenTheReturnedUsersShouldMatchTheGetUsersOriginal()
        {
            Assert.IsNotNull(UserServiceData.getUserDtoList);

            var userForGetUsersAExpected = UserServiceData.usersForGetUsers
                .Where(user => user.FirstName == "UserForGetUsersTestAFirstName").FirstOrDefault();
            var userForGetUsersBExpected = UserServiceData.usersForGetUsers
                .Where(user => user.FirstName == "UserForGetUsersTestBFirstName").FirstOrDefault();

            Assert.IsNotNull(userForGetUsersAExpected);
            Assert.IsNotNull(userForGetUsersBExpected);

            var userForGetUsersAResult = UserServiceData.getUserDtoList
                .Where(user => user.FirstName == "UserForGetUsersTestAFirstName").FirstOrDefault();
            var userForGetUsersBResult = UserServiceData.getUserDtoList
                .Where(user => user.FirstName == "UserForGetUsersTestBFirstName").FirstOrDefault();

            Assert.IsNotNull(userForGetUsersAResult);
            Assert.IsNotNull(userForGetUsersBResult);

            Assert.AreEqual(userForGetUsersAExpected.FirstName, userForGetUsersAResult.FirstName);
            Assert.AreEqual(userForGetUsersAExpected.LastName, userForGetUsersAResult.LastName);
            Assert.AreEqual(userForGetUsersAExpected.DateOfBirth, userForGetUsersAResult.DateOfBirth);
            Assert.AreEqual(userForGetUsersAExpected.Gender, userForGetUsersAResult.Gender);
            Assert.AreEqual(userForGetUsersAExpected.Weight, userForGetUsersAResult.Weight);

            Assert.AreEqual(userForGetUsersBExpected.FirstName, userForGetUsersBResult.FirstName);
            Assert.AreEqual(userForGetUsersBExpected.LastName, userForGetUsersBResult.LastName);
            Assert.AreEqual(userForGetUsersBExpected.DateOfBirth, userForGetUsersBResult.DateOfBirth);
            Assert.AreEqual(userForGetUsersBExpected.Gender, userForGetUsersBResult.Gender);
            Assert.AreEqual(userForGetUsersBExpected.Weight, userForGetUsersBResult.Weight);
        }
    }
}
