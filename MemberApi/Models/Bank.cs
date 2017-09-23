using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MemberApi.Models
{
    public class Bank : EntityBase
    {
        public string BankName { get; set; }
        public string Branch { get; set; }
        public string Account { get; set; }
        public string AccountNumber { get; set; }
    }
}