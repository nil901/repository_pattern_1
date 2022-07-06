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
    public interface IUserService
    {
        Task<IEnumerable<User>> GetAllUser();

        Task<User> GetUserById(int id);

        Task<User> AddUser(UserAddDTO userAdd);

        Task<bool> UpdateUser(UserUpdateDTO userUpdate);

        Task<bool> DeleteUser(int id);



        public class UserService : IUserService
        {
            private readonly IUserRepository _userrepository;

            public UserService(IUserRepository userRepository)
            {

                _userrepository = userRepository;
            }

            public async Task<User> AddUser(UserAddDTO userAdd)
            {
                try
                {
                    var user = new User();
                    user.UserName = userAdd.UserName;
                    user.City = userAdd.City;
                    user.Address = userAdd.Address;
                    user.AccountNumber = userAdd.Accountnumber;
                    user.AccountType = userAdd.AccountType;
                    user.Amount = userAdd.Amount;
                    await _userrepository.Add(user);

                    return user;


                }
                catch (Exception ex)
                {
                    throw ex;
                }

            }

           
            public async Task<IEnumerable<User>> GetAllUser()
            {
                return await _userrepository.Get();
            }

            public async Task<User> GetUserById(int id)
            {
                return await _userrepository.GetById(id);

            }

            public async Task<bool> UpdateUser(UserUpdateDTO userUpdate)
            {
                try
                {
                    var user = new User();
                    user.UserId = userUpdate.UserId;
                    user.UserName = userUpdate.UserName.Trim();
                    user.City = userUpdate.City.Trim();
                    user.Address = userUpdate.Address.Trim();
                    user.AccountNumber = userUpdate.Accountnumber;
                    user.AccountType = userUpdate.AccountType.Trim();
                    user.Amount = userUpdate.Amount;

                    User _user = await GetUserById(user.UserId);
                    if (_user != null)
                    {
                        _user.UserName = user.UserName;
                        _user.City = user.City;
                        _user.Address = user.Address;
                        _user.AccountNumber = user.AccountNumber;
                        _user.AccountType = user.AccountType;
                        _user.Amount = user.Amount;
               

                        await _userrepository.Update(_user);
                    }
                    return true;

                }
                catch
                {
                    return false;
                }
            }


            public async Task<bool> DeleteUser(int id)
            {
                User user = await GetUserById(id);
                if (user != null)
                {
                    await _userrepository.Delete(user);
                    return true;
                }
                return false;
            }


           
        }


    }
}
