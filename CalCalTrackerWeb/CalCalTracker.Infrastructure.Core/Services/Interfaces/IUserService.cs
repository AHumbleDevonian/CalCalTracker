using CalCalTracker.Infrastructure.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CalCalTracker.Infrastructure.Core.Services.Interfaces
{
    public interface IUserService
    {
        Task AddUser(AddUserDto addUserDto);
    }
}
