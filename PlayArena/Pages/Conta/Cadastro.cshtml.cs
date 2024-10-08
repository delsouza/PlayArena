using Business.PlayArena.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Identity.Client;
using Models;

namespace PlayArena.Pages.Conta
{
    public class CadastroModel : PageModel
    {
        private readonly IClienteBusiness _clienteBusiness;

        [BindProperty]
        public ClienteModel ClienteModel { get; set; }

        public CadastroModel(IClienteBusiness clienteBusiness)
        {
            _clienteBusiness = clienteBusiness;
        }

        public async Task<IActionResult> OnPostAsync()
        {
            //if (!ModelState.IsValid)
            //{
            //    return Page();
            //}

            var cliente = ClienteModel;

            await _clienteBusiness.Cadastro(cliente);

            return RedirectToPage("/Conta/Login");
        }
    }
}
