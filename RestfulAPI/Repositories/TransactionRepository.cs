using RestfulAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestfulAPI.Repositories
{
    public class TransactionRepository
    {
        private Transaction _Transaction = Transaction.GetInstance();
        public List<Account> GetAll()
        {
            return _Transaction.TransactionDetails;
        }

        public Account GetByApplicationId(int applicationId)
        {
            return _Transaction.TransactionDetails.Where(item => item.ApplicationId == applicationId).FirstOrDefault();
        }

        public void Create(Account accountDetails)
        {
            accountDetails.ApplicationId = Convert.ToInt32(new Random());
            accountDetails.Id = Guid.NewGuid();
            _Transaction.TransactionDetails.Add(accountDetails);
        }

        public void Update(Account accountDetails)
        {
            var recordIndex= _Transaction.TransactionDetails.FindIndex(item => item.ApplicationId == accountDetails.ApplicationId);
            _Transaction.TransactionDetails[recordIndex] = accountDetails;
        }

        public void Delete(int applicationId)
        {
            _Transaction.TransactionDetails.RemoveAll(item => item.ApplicationId == applicationId);
        }
    }
}