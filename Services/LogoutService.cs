using FluentResults;
using Microsoft.AspNetCore.Identity;
using UsuariosAPI.Models;

namespace UsuariosAPI.Services
{
    public class LogoutService
    {
        private SignInManager<CustomIdentityUser> _singinManager;

        public LogoutService(SignInManager<CustomIdentityUser> singinManager)
        {
            _singinManager = singinManager;
        }

        public Result DeslogaUsuario()
        {
            var resultadoIdentity = _singinManager.SignOutAsync();
            if (resultadoIdentity.IsCompletedSuccessfully) return Result.Ok();
            return Result.Fail("logout falhou");
        }
    }
}
