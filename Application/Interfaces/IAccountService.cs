using Application.ViewModels;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IAccountService
    {
        Task<bool> UserExists(string username);
        Task<UserVM> GetUserByUserNameAsync(string username);
        Task<SignInResult> CheckUserPasswordAsync(UserVM userVM, string password);
        Task<UserVM> CreateAccountAsync(UserVM userVM);
        Task<UserUpdateDto> UpdateAccount(UserUpdateDto userUpdateDto);
    }
}
