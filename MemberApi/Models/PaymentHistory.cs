using MemberApi.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MemberApi.Models
{
    public class PaymentHistory : EntityBase
    {
        public PaymentType PaymentType { get; set; }
        public string SlipFile { get; set; }
        public decimal Amount { get; set; }
        public DateTime TransferDateTime { get; set; }
        public Bank TransferBank { get; set; }
    }
}