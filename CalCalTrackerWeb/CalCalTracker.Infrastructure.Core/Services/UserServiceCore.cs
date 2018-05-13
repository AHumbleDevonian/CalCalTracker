using CalCalTracker.Infrastructure.Core.Services.Base;
using CalCalTracker.Infrastructure.Dtos;
using CalCalTracker.Infrastructure.Services.Interfaces;
using CalCalTracker.Persistence.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalCalTracker.Infrastructure.Core.Services
{
    public class UserServiceCore : CalCalService, IUserService
    {
        public UserServiceCore(CalCalTrackerContext db) : base(db) { }

        public async Task AddUser(AddUserDto addUserDto)
        {
            _db.Users.Add(new Domain.EFCore.User()
            {
                FirstName = addUserDto.FirstName,
                LastName = addUserDto.LastName,
                DateOfBirth = addUserDto.DateOfBirth,
                Weight = addUserDto.Weight,
                Gender = addUserDto.Gender
            });
            await _db.SaveChangesAsync();
        }

        public async Task DeleteUser(long id)
        {
            throw new NotImplementedException();
        }

        public async Task<GetUserDto> GetUser(long id)
        {
            throw new NotImplementedException();
        }

        public async Task<IQueryable<GetUserDto>> GetUsers()
        {
            throw new NotImplementedException();
        }

        public async Task<GetUserDto> UpdateUser(UpdateUserDto addUserDto)
        {
            throw new NotImplementedException();
        }
    }
}
