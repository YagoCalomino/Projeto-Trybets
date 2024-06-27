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
        var existingUser = _context.Users.Any(u => u.Email == user.Email);
        if (existingUser) throw new Exception("E-mail already used");

        _context.Users.Add(user);
        _context.SaveChanges();

        return user;
    }
    public User Login(AuthDTORequest login)
    {
        var foundUser = _context.Users.SingleOrDefault(u => u.Email == login.Email);
        if (foundUser == null) throw new Exception("Authentication failed");
        if (foundUser.Password != login.Password) throw new Exception("Authentication failed");

        return foundUser;
    }
}