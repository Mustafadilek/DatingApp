using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Controllers
{
    
    public class UsersController : BaseApiController
    {
        private readonly DataContext _context;

        public UsersController(DataContext context)
        {
            _context = context;
        }
        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers(){
            
            return await _context.Users.ToListAsync();
        }
        [Authorize]
            // api/users/3
        [HttpGet("{id}")]
        public ActionResult<AppUser> GetUsers(int id){
           
            return  _context.Users.Find(id);
        }
    }
}