using System.Threading.Tasks;

namespace Pri.Oe.Identity.Intro.Mvc.Services.Users
{
    public interface IUserService
    {
        Task LoginAsync(string userName, string password);
        Task LogoutAsync();
    }
}
