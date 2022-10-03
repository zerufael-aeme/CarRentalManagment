using System.Collections.Generic;

namespace CarRentalManagment.Models.Services
{
    public interface IAccountServices
    {
        public void AddAccount(Account account);
        public int CheckCredentials(int id, string password);
        public Account GetAccount(int id);
        public List<Account> GetAllAccounts();
        public int DeleteById(int id);
    }
}
