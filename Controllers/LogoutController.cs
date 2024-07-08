using FluentResults;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using UsuariosAPI.Services;
using RouteAttribute = Microsoft.AspNetCore.Components.RouteAttribute;

namespace UsuariosAPI.Controllers
{

    [Route("[controller]")]
    [ApiController]
    public class LogoutController : ControllerBase
    {

        private LogoutService _logoutService;

        public LogoutController()
        {

        }

        public LogoutController(LogoutService logoutService)
        {
            _logoutService = logoutService;
        }

        [HttpPost]
        public IActionResult DeslogarUsuario()
        {
            Result resultado = _logoutService.DeslogaUsuario();
            if (resultado.IsFailed) return Unauthorized(resultado.Errors);
            return Ok(resultado.Successes);
        }

    }
}