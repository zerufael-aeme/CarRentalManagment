using System;
using System.Collections.Generic;
using System.Linq;

namespace CarRentalManagment.Models.Services
{
    public class AccountServices : IAccountServices
    {
        CarManagementDbContext _context;
        public AccountServices(CarManagementDbContext context)
        {
            _context = context;
        }

        public void AddAccount(Account account)
        {
            account.activeOrder = false;
            account.email = null;
            _context.Accounts.Add(account);
            _context.SaveChanges();
        }
        public int CheckCredentials(int id, string password)
        {
            var checkAccount = _context.Accounts.Find(id);
            if (checkAccount == null)
            {
                return 0;
            }
            else
            {
                if (checkAccount.password == password)
                {
                    return 1;
                }
                else
                    return -1;
            }
        }
        public Account GetAccount(int id)
        {
            Account account = _context.Accounts.Find(id);
            return account;
        }
        public List<Account> GetAllAccounts()
        {
            return _context.Accounts.ToList();
        }
        public int DeleteById(int id)
        {
            Account account = _context.Accounts.Find(id);
            if (account.activeOrder == false)
            {
                _context.Accounts.Remove(account);
                _context.SaveChanges();
                return 1;
            }else
                return -1;

        }
    }
}
