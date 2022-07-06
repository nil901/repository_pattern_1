using DTOModel;
using Model;
using repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo.Service1
{
    public interface IAccountService
    {
        Task<IEnumerable<Account>> GetAllAccount();   
        Task<Account> AddAccount(AccountAddDTO accountAddDTO);
        Task<bool> UpdateAccount( AccountUpdateDTO accountUpdate);
        Task<Account> GetAccountById(int Id);
        Task<bool> DeleteAccount(int id); 
        
      




    }


    public class AccountService : IAccountService
    {
        
        private readonly IAccountRepository _accountrepository; 
        public AccountService(IAccountRepository  accountrepository)
        {

            _accountrepository = accountrepository;
        }

        public async Task<Account> AddAccount(AccountAddDTO accountAddDTO)
        {
            try
            {
                var account = new Account();
                account.BankName = accountAddDTO.BankName;
                account.AccountType = accountAddDTO.AccountType;
                await _accountrepository.Add(account);

                return account;

            }

            catch(Exception ex) 
            {
                throw ex;
            }
        }

        public async Task<Account> GetAccountById(int Id)
        {
            return await _accountrepository.GetById(Id);
    
        }

       

     public async Task<bool> UpdateAccount(AccountUpdateDTO accountUpdate)
        {
            try
            {
                var account = new Account();
                account.AccountNo = accountUpdate.AccountNo;
                account.BankName = accountUpdate.BankName.Trim();
                account.AccountType = accountUpdate.AccountType.Trim();

                Account _account = await GetAccountById(account.AccountNo);
                if (_account != null)
                {
                    _account.BankName = account.BankName;
                    _account.AccountType = account.AccountType;

                    await _accountrepository.Update(_account);


                }
                return true;

            } 
            catch
            {

                return false;
            }  


        } 

        public async Task<bool> DeleteAccount (int id)
        {
            Account account = await GetAccountById(id);
            if (account != null)
            {
                await _accountrepository.Delete(account);
                return true;
            }
            return false;

        }

        public async Task<IEnumerable<Account>> GetAllAccount()
        {
            return await _accountrepository.Get(); 
        }

        




    }









}


   

