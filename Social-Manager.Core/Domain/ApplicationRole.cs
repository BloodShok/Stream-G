using Microsoft.AspNetCore.Identity;
using Social_Manager.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Social_Manager.Core.Domain
{
    public class ApplicationRole : IdentityRole<int>, IBaseEntity
    {
    }
}
