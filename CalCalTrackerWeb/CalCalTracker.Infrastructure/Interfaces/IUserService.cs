using System.Collections.Generic;
using CalCalTracker.Infrastructure.Dtos;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalCalTracker.Infrastructure.Services.Interfaces
{
    public interface IUserService
    {
        Task AddUser(AddUserDto addUserDto);

        Task<GetUserDto> GetUser(long id);

        Task<IQueryable<GetUserDto>> GetUsers();
    
        Task<GetUserDto> UpdateUser(UpdateUserDto addUserDto);

        Task DeleteUser(long id);
    }
}
