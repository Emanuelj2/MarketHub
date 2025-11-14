using MarketHub_API.Data.MarketHub_API.Data;
using MarketHub_API.Models;

namespace MarketHub_API.Services
{
    public interface IAuthService
    {
        Task<User> RegisterAsync(string email, string password, string firstNaem, string lastNaem, string phone);
        Task<string> LoginAsync(string email, string password);
        string HashPassword(string password);
        bool VerifyPassword(string password, string passwordHash);
    }

    public class AuthService : IAuthService
    {

        private readonly ApplicationDbContext _context;

        public AuthService(ApplicationDbContext context)
        {
            _context = context;
        }



        public string HashPassword(string password)
        {
            throw new NotImplementedException();
        }

        public Task<string> LoginAsync(string email, string password)
        {
            throw new NotImplementedException();
        }

        public Task<User> RegisterAsync(string email, string password, string firstNaem, string lastNaem, string phone)
        {
            throw new NotImplementedException();
        }

        public bool VerifyPassword(string password, string passwordHash)
        {
            throw new NotImplementedException();
        }
    }
}
