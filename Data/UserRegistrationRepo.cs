using System;
using System.Collections.Generic;
using System.Linq;
using commander.Models;

namespace commander.Data
{
    public class UserRegistrationRepo : IUserRegistrationRepo
    {
        private readonly CommanderContext _context;

        public UserRegistrationRepo(CommanderContext context)
        {
            _context = context;
        }
        public void CreateUser(MasterUser usr)
        {
            throw new NotImplementedException();
        }

        public void DeleteUser(MasterUser usr)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<MasterUser> GetAllUsers()
        {
            return _context.MasterUsers.ToList();
        }

        public MasterUser GetUserById(int id)
        {
            return _context.MasterUsers.FirstOrDefault(p =>p.Id == id);
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void UpdateUser(MasterUser usr)
        {
            throw new NotImplementedException();
        }
    }

}