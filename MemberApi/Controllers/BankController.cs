using System.Collections.Generic;
using System.Web.Http;
using Member.Models;

namespace MemberApi.Controllers
{
    public class BankController : ApiController
    {
        // GET: api/Bank
        public IEnumerable<Bank> Get()
        {
            return new List<Bank>();
        }

        // GET: api/Bank/5
        public Bank Get(int id)
        {
            return new Bank();
        }

        // POST: api/Bank
        public void Post(Bank bank)
        {
        }

        // PUT: api/Bank/5
        public void Put(int id, Bank bank)
        {
        }

        // DELETE: api/Bank/5
        public void Delete(int id)
        {
        }
    }
}
