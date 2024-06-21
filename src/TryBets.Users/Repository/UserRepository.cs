using TryBets.Users.Models;
using TryBets.Users.DTO;

namespace TryBets.Users.Repository;

public class UserRepository : IUserRepository
{
    protected readonly ITryBetsContext _context;
    public UserRepository(ITryBetsContext context)
    {
        _context = context;
    }

    public User Post(User user)
    {
var existingUser = _context.Users.Where(u => u.Email == user.Email);
if (existingUser.Any())
{
    throw new Exception("E-mail already used");
}

_context.Users.Add(user);
_context.SaveChanges();
return user;

    }
    public User Login(AuthDTORequest login)
    {
var foundUser = _context.Users.Where(user => user.Email == login.Email);
if (!foundUser.Any())
{
    throw new Exception("Authentication failed");
}

var authenticatedUser = foundUser.First();
if (authenticatedUser.Password != login.Password)
{
    throw new Exception("Authentication failed");
}

return authenticatedUser;
    }
}