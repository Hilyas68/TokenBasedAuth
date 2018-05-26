using JobSeeker.Web.Models;
using System.Collections.Generic;

namespace JobSeeker.Web.Repo
{
    public interface IUserRepository
    {
        IEnumerable<ApplicationUser> GetUsers();
    }
}