using Business;
using Business.Interface;
using DAO.Interface;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace PlayArenaWAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JogoController : ControllerBase
    {
        private readonly IJogoBusiness _jogoBusiness;
		private readonly IRequisitoSistemaBusiness _requisitoSistemaBusiness;
		private readonly IImagemJogoBusiness _imagemJogoBusiness;
		public JogoController(IJogoBusiness jogoBusiness, IRequisitoSistemaBusiness requisitoSistemaBusiness, IImagemJogoBusiness imagemJogoBusiness) 
        {
            _jogoBusiness = jogoBusiness;
			_requisitoSistemaBusiness = requisitoSistemaBusiness;
			_imagemJogoBusiness = imagemJogoBusiness;
		}

        [HttpGet]
        [Route("api/jogo/listar")]
        public ActionResult ListarJogo() 
        {
            List<JogoModel> jogos =  _jogoBusiness.ListarJogo();
            return Ok(jogos);
        }

        [HttpGet]
        [Route("api/jogo/listar/{Id}")]
        public ActionResult ListarUmJogo(int Id)
        {
            var jogo = _jogoBusiness.ObterJogoPorId(Id);
            return Ok(jogo);
        }

        //[HttpGet]
		//[Route("api/jogo/{Id}/RequisitoSistema")]
		//public ActionResult ListarRequisitoSistema(int Id)
		//{
		//	List<RequisitoModel> Requisito = _requisitoSistemaBusiness.ListarRequisitoSistema(Id);
		//	return Ok(Requisito);
		//}

		[HttpGet]
		[Route("api/jogo/RequisitoSistema/{Id}")]
		public ActionResult ObterRequisitoPorId(int Id)
		{
			RequisitoModel Requisito = _requisitoSistemaBusiness.ObterRequisitoPorIdJogo(Id);
			return Ok(Requisito);
		}

		[HttpGet]
		[Route("api/imagem/ImagemJogo/{Id}")]
		public ActionResult ObterImagemPorId(int Id)
		{
			ImagemJogoModel Imagem = _imagemJogoBusiness.ObterImagemJogoPorId(Id);
			return Ok(Imagem);
		}

	} 
}
