using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Identity.Client;
using Models;

namespace PlayArena.Pages
{
    public class CadastroModel : PageModel
    {
        [BindProperty]
        public ClienteModel ClienteModel { get; set; }

        public CadastroModel() 
        {
            
        }

        public void OnGet()
        {

        }
        public void OnPost() 
        {
            
        }
    }
}
