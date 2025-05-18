using System.Threading.Tasks;
using CleanArchitecture1.Application.DTOs.Account.Requests;
using CleanArchitecture1.Application.DTOs.Account.Responses;
using CleanArchitecture1.Application.Wrappers;

namespace CleanArchitecture1.Application.Interfaces.UserInterfaces
{
    public interface IAccountServices
    {
        Task<BaseResult<string>> RegisterGhostAccount();
        Task<BaseResult> ChangePassword(ChangePasswordRequest model);
        Task<BaseResult> ChangeUserName(ChangeUserNameRequest model);
        Task<BaseResult<AuthenticationResponse>> Authenticate(AuthenticationRequest request);
        Task<BaseResult<AuthenticationResponse>> AuthenticateByUserName(string username);

    }
}
