using Application.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class AccountController : Controller
    {

        [HttpPost("Register")]
        [AllowAnonymous] //Permite acesso sem autenticação
        public async Task<IActionResult> Register(UserVM userVM)
        {
            try
            {
                //if (await _accountService.UserExists(userVM.UserName))
                //    return BadRequest("Usuário já existe");

                //var user = await _accountService.CreateAccountAsync(userVM);
                //if (user != null)
                //    return Ok(user);

                return BadRequest("Usuário não criado, tente novamente mais tarde!");
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError,
                    $"Erro ao tentar Registrar Usuário. Erro: {ex.Message}");
            }
        }
    }
}
