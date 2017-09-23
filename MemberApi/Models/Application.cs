using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MemberApi.Models
{
    public class Application : EntityBase
    {
        public string ApplicaionName { get; set; }
        public string ApplicationKey { get; set; }
    }
}