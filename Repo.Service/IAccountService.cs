using DTOModel;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo.Service
{ 

    public interface IAccountService
    {
        //Task<IEnumerable<Account>> GetAllAccount();
        //Task<Account> GetAccountId(int id);
        Task<Account> AddAccount(AccountAddDTO accountAddDTO);
        //Task<bool> UpdateAccount(AccountUpdateDTO accountUpdate);
        //Task<bool> DeleteCategory(int id); 
    }

    public class AccountService : IAccountService
    {
        private readonly IAccountService _AccountRepository;

        public AccountService(IAccountService AccountService)
        {
            _AccountRepository = AccountService;

        }

        public async Task<Account> AddAccount(AccountAddDTO addDTO)
        {
            try
            {
                var account = new Account();
                account.BankName = addDTO.AccountName;
                account.AccountType = addDTO.AccountType;
                await _AccountRepository.Add(account);
                return account;

            }
            catch
            {
                Exception ex; 
            } 
        }

        public Task<bool> DeleteCategory(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Account> GetAccountId(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Account>> GetAllAccount()
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAccount(AccountUpdateDTO accountUpdate)
        {
            throw new NotImplementedException();
        }
    }


    


    


}
