using Social_Manager.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;

namespace Social_Manager.Core.Domain
{
    public class ApplicationUser : IdentityUser<int>, IBaseEntity
    {
    }
}
