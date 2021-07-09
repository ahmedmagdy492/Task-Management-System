using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task_Management_Lib.Data;
using Task_Management_Lib.Models;
using Task_Management_System.Repository;

namespace Task_Management_System.Services
{
    public class UserService : Repository<User, string>, IUserService
    {
        public UserService(AppDbContext context) : base(context)
        {
        }

        public User Update(User user)
        {
            _context.Entry(user).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            return user;
        }
    }
}
