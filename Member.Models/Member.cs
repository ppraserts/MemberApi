using System;
using System.Collections.Generic;

namespace Member.Models
{
    public class Member : EntityBase
    {
        public string Username { get; set; }
        public string Name { get; set; }
        public DateTime ExpireDate { get; set; }
        public TypeOfMember TypeOfMember { get; set; }
        public ContactInfo ContactInfo { get; set; }
        public List<Application> Applications { get; set; }
        public List<PaymentHistory> PaymentHistorys { get; set; }
    }
}
