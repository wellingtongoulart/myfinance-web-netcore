using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using myfinance_web_netcore.Services;
using myfinance_web_netcore.Models;
using AutoMapper;

namespace myfinance_web_netcore.Controllers;

[Route("[controller]")]
public class PlanoContaController : Controller
{
  private readonly ILogger<PlanoContaController> _logger;
  private readonly IMapper _mapper;
  private readonly IPlanoContaService _planoContaService;

  public PlanoContaController(
    ILogger<PlanoContaController> logger, 
    IMapper mapper,
    IPlanoContaService planoContaService)
  {
    _logger = logger;
    _mapper = mapper;
    _planoContaService = planoContaService;
  }

[HttpGet]
[Route("Index")]
  public IActionResult Index()
  {
    var listaPlanoConta = _planoContaService.ListarPlanoContas();
    var lista = _mapper.Map<IEnumerable<PlanoContaModel>>(listaPlanoConta);
    ViewBag.ListaPlanoConta = lista;

    return View();
  }

[HttpGet]
[Route("Cadastro")]
[Route("Cadastro/{id}")]
  public IActionResult Cadastro(int? id)
  {
    // if (id != null)
    // {
    //   var registro = _planoContaService.RetornarRegistro((int)id);
    //   return View(registro);
    // }

    return View();
  }

  [HttpPost]
  [Route("Cadastro")]
  [Route("Cadastro/{id}")]
  public IActionResult Cadastro(PlanoContaModel model)
  {
    return View();
  }

  [HttpGet]
  [Route("Excluir/{id}")]
  public IActionResult Excluir(int id)
  {
    // _planoContaService.Excluir(id);
    return RedirectToAction("Index");
  }

  [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
  public IActionResult Error()
  {
    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
  }
}
