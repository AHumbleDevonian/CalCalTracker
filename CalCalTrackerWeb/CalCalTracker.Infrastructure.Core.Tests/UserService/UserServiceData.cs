using CalCalTracker.Domain.EFCore;
using CalCalTracker.Infrastructure.Dtos;
using CalCalTracker.Infrastructure.Services.Interfaces;
using CalCalTracker.Persistence.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalCalTracker.Infrastructure.Core.Tests.UserService
{
    public static class UserServiceData
    {
        public static AddUserDto addUserDto;

        public static GetUserDto getUserDto;
        public static User userForGetUser;

        public static UpdateUserDto updateUserDto;
        public static GetUserDto updateUserGetUserDto;
        public static User originalUserForUpdateUser;

        public static List<GetUserDto> getUserDtoList;
        public static List<User> usersForGetUsers;

        public static User userForDeleteUser;

    }
}
