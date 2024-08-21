using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;
using Business.PlayArena.Interface;
using Models;

namespace PlayArena.Pages.Conta
{
    public class LoginModel : PageModel
    {
        private readonly IClienteBusiness _clienteBusiness;

        public LoginModel(IClienteBusiness clienteBusiness)
        {
            _clienteBusiness = clienteBusiness;
        }

        [BindProperty]
        public ClienteModel ClienteModel { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            var cliente = await _clienteBusiness.Login(ClienteModel.Email, ClienteModel.Senha);

            if (cliente != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, cliente.Nome),
                    new Claim(ClaimTypes.Email, cliente.Email),
                    new Claim(ClaimTypes.NameIdentifier, cliente.Id.ToString())
                };

                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);

                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, claimsPrincipal);

                return RedirectToPage("/Catalogo");
            }

            return Page();
        }
    }
}
