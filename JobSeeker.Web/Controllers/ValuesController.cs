using JobSeeker.Web.Models;
using JobSeeker.Web.Repo;
using System.Collections.Generic;
using System.Web.Http;

namespace JobSeeker.Web.Controllers
{
    [Authorize]
    public class ValuesController : ApiController
    {
        public UserRepository Repo { get; }

        public ValuesController()
        {
            Repo = new UserRepository();
        }
        // GET api/values
        public IEnumerable<ApplicationUser> Get()
        {
            return Repo.GetUsers();
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
