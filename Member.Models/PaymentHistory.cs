using System;

namespace Member.Models
{
    public class PaymentHistory : EntityBase
    {
        public Application Application { get; set; }
        public PaymentType PaymentType { get; set; }
        public string SlipFile { get; set; }
        public decimal Amount { get; set; }
        public DateTime TransferDateTime { get; set; }
        public Bank TransferBank { get; set; }
    }
}
