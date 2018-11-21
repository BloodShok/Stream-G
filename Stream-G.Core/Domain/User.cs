using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;

namespace StreamG.Core.Domain
{
    public class User : IdentityUser<int>, IBaseEntity
    {
    }
}
