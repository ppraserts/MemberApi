using MemberApi.MockData;
using MemberApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MemberApi.Controllers
{
    public class BankController : ApiController
    {
        // GET: api/Bank
        public IEnumerable<Bank> Get()
        {
            var banks = BankMockData.Gets(10);
            return banks;
        }

        // GET: api/Bank/5
        public Bank Get(int id)
        {
            var bank = BankMockData.Get();
            return bank;
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
