using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestfulAPI.Models
{
    public class Transaction
    {
        private static Transaction _Transaction;
        private Transaction()
        {
            LoadTransaction();
        }

        public static Transaction GetInstance()
        {
            if (_Transaction == null)
            {
                _Transaction = new Transaction();
            }
            return _Transaction;
        }
        public List<Account> TransactionDetails { get; set; }

        private void LoadTransaction()
        {
            TransactionDetails = new List<Account>();

            //The Sample data.json file can be serialized
            //System.Runtime.Serialization.Json.DataContractJsonSerializer ser = new System.Runtime.Serialization.Json.DataContractJsonSerializer(Account);
            //ser.


            TransactionDetails.Add(new Account()
            {
                Id = new Guid("194f0d46-2a06-45b4-b057-45949279b4e5"),
                ApplicationId = 197104,
                Type = "Debit",
                Summary = "Payment",
                Amount = 58.26,
                PostingDate = Convert.ToDateTime("2016-07-01"),
                IsCleared = true,
                ClearedDate = Convert.ToDateTime("2016-07-02")
            });
            TransactionDetails.Add(new Account()
            {
                Id = new Guid("3f2b12b8-2a06-45b4-b057-45949279b4e5"),
                ApplicationId = 197104,
                Type = "Debit",
                Summary = "Payment1",
                Amount = 58.26,
                PostingDate = Convert.ToDateTime("2016-07-01"),
                IsCleared = true,
                ClearedDate = Convert.ToDateTime("2016-07-02")
            });
            TransactionDetails.Add(new Account()
            {
                Id = new Guid("3f2b12b8-2a06-45b4-b057-45949279b4e5"),
                ApplicationId = 197104,
                Type = "Debit",
                Summary = "Payment2",
                Amount = 58.26,
                PostingDate = Convert.ToDateTime("2016-07-01"),
                IsCleared = true,
                ClearedDate = Convert.ToDateTime("2016-07-02")
            });
            TransactionDetails.Add(new Account()
            {
                Id = new Guid("f37dd903-2a06-45b4-b057-45949279b4e5"),
                ApplicationId = 197104,
                Type = "Debit",
                Summary = "Payment3",
                Amount = 58.26,
                PostingDate = Convert.ToDateTime("2016-07-01"),
                IsCleared = true,
                ClearedDate = Convert.ToDateTime("2016-07-02")
            });
            TransactionDetails.Add(new Account()
            {
                Id = new Guid("3f2b12b8-2a06-45b4-b057-45949279b4e5"),
                ApplicationId = 197104,
                Type = "Credit",
                Summary = "Refund",
                Amount = 58.26,
                PostingDate = Convert.ToDateTime("2016-07-01"),
                IsCleared = true,
                ClearedDate = Convert.ToDateTime("2016-07-02")
            });
        }
    }
}