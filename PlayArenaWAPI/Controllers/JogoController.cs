using Business.Interface;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace PlayArenaWAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JogoController : ControllerBase
    {
        private readonly IJogoBusiness _jogoBusiness;
        public JogoController(IJogoBusiness jogoBusiness) 
        {
            _jogoBusiness = jogoBusiness;
        }

        [HttpGet]
        public ActionResult ListarJogo() 
        {
            List<JogoModel> jogos =  _jogoBusiness.ListarJogo();
            return Ok(jogos);
        }

    } 
}
