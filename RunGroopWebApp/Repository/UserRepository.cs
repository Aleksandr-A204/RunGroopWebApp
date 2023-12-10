using Microsoft.EntityFrameworkCore;
using RunGroopWebApp.Data;
using RunGroopWebApp.Interfaces;
using RunGroopWebApp.Models;

namespace RunGroopWebApp.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;
        public UserRepository(ApplicationDbContext context) 
        {
            _context = context;
        }
        public bool Add(AppUser user)
        {
            throw new NotImplementedException();
        }

        public bool Delete(AppUser user)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<AppUser>> GetAllUser() => await _context.Users.ToListAsync();

        public async Task<AppUser> GetUserById(string id) => await _context.Users.FirstAsync(x => x.Id == id);

        public bool Save() => _context.SaveChanges() > 0 ? true : false;

        public bool Update(AppUser user)
        {
            _context.Update(user);
            return Save();
        }
    }
}
