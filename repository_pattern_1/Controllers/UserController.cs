using DTOModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;
using Repo.Service1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace repository_pattern_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserService _UserService;

        public UserController(IUserService userService)
        {

            _UserService = userService;
        }



        [HttpGet]
        [Route("UserGet")]
        [Produces(typeof(IEnumerable<User>))]
        public async Task<IActionResult> GetUser()
        {
            IEnumerable<User> user = await _UserService.GetAllUser();
            return Ok(user);
        }

        [HttpPost]
        [Route("Add")]
        [Produces(typeof(User))]
        public async Task<IActionResult> AddUser(UserAddDTO userAdd)
        {
            return Ok(await _UserService.AddUser(userAdd));

        }
        [HttpPut]
        [Route(("{id}"))]
        [Produces(typeof(User))]
        public async Task<IActionResult> UpdateUser(UserUpdateDTO userUpdateDTO)
        {
            return Ok(await _UserService.UpdateUser(userUpdateDTO));
        }
         
        [HttpDelete] 
        [Route("{Id}" )] 
        [Produces(typeof(bool))] 
        public async Task<bool> DeleteUser(int id)
        {
            return await _UserService.DeleteUser(id);
        }  

        
    }
}
