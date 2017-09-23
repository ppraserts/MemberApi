using MemberApi.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MemberApi.Models
{
    public class Member : EntityBase
    {
        public string Username { get; set; }
        public string Name { get; set; }
        public DateTime ExpireDate { get; set; }
        public bool IsActive { get; set; }
        public TypeOfMember TypeOfMember { get; set; }
        public ContactInfo ContactInfo { get; set; }
        public Application Application { get; set; }
        public List<PaymentHistory> PaymentHistorys { get; set; }
    }
}