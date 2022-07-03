using System.Collections.Generic;
using commander.Models;

namespace commander.Data
{
public interface IUserRegistrationRepo
{
    bool SaveChanges();
    IEnumerable<MasterUser> GetAllUsers();
    MasterUser GetUserById(int id);

    void CreateUser(MasterUser usr);
    void UpdateUser(MasterUser usr);
    void DeleteUser(MasterUser usr);
    
}
}
