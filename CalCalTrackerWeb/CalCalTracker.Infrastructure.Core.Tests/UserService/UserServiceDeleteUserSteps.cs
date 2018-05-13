using CalCalTracker.Infrastructure.Core.Tests.CommonSteps;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace CalCalTracker.Infrastructure.Core.Tests.UserService
{
    [Binding]
    public class UserServiceDeleteUserSteps
    {
        [Given(@"I have created a user for DeleteUser and added it")]
        public void GivenIHaveCreatedAUserForDeleteUserAndAddedIt()
        {
            var userForDeleteUser = new Domain.EFCore.User()
            {
                FirstName = "UserForGetUserTestAFirstName",
                LastName = "UserForGetUserTestALastName",
                DateOfBirth = DateTime.Now.AddYears(-22),
                Gender = Domain.Enums.Gender.Male,
                Weight = 81
            };
            CommonData.db.Users.Add(userForDeleteUser);
            CommonData.db.SaveChanges();
            UserServiceData.userForDeleteUser = userForDeleteUser;
        }

        [When(@"I use the DeleteUser function")]
        public async Task WhenIUseTheDeleteUserFunction()
        {
            await CommonData.userService.DeleteUser(UserServiceData.userForDeleteUser.Id);
        }

        [Then(@"the returned user should match the DeleteUser original")]
        public void ThenTheReturnedUserShouldMatchTheDeleteUserOriginal()
        {
            var deletedUser = CommonData.db.Users
                .Where(user => user.Id == UserServiceData.userForDeleteUser.Id).FirstOrDefault();

            Assert.IsNull(deletedUser);
        }
    }
}
