using StreamG.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace StreamG.Services.Interfaces
{
    public interface IUserService
    {
        UserDto GetUserById(int id);
        UserDto GetUserByName(string Name);
    }
}
