using MemberApi.Helper;
using MemberApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MemberApi.MockData
{
    public class BankMockData
    {
        public static Bank Get()
        {
            return Create(1);
        }

        public static IList<Bank> Gets(int maxsize = 1)
        {
            var list = new List<Bank>();
            for (int i = 0; i < maxsize; i++)
            {
                list.Add(Create(i + 1));
            }

            return list;
        }

        private static Bank Create(int id)
        {
            return new Bank()
            {
                Id = id,
                BankName = MockGenerator.GetString(50),
                Branch = MockGenerator.GetString(50),
                Account = MockGenerator.GetString(50),
                AccountNumber = MockGenerator.GetString(13)
            };
        }
    }
}