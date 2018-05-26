using JobSeeker.Web.Models;
using System.Collections.Generic;
using System.Linq;

namespace JobSeeker.Web.Repo
{
    public class UserRepository : IUserRepository
    {
        private ApplicationDbContext _context;

        public UserRepository()
        {
            _context = new ApplicationDbContext();
        }
        public IEnumerable<ApplicationUser> GetUsers()
        {
            return _context.Users.ToList();
        }
    }
}