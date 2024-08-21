using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace PlayArena.Components
{
    [ViewComponent(Name = "HeaderViewComponent")]
    public class HeaderViewComponent : ViewComponent
    {
        public HeaderViewComponent() { }

        public async Task<IViewComponentResult> InvokeAsync() 
        {
            var nome = HttpContext.User.Identity.Name;
            
            return View("Default", nome); 
        }
    }
}
