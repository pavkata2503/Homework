using System;
using Microsoft.AspNetCore.Identity;

namespace CleanArchitecture1.Infrastructure.Identity.Models
{
    public class ApplicationRole(string name) : IdentityRole<Guid>(name)
    {
    }
}
