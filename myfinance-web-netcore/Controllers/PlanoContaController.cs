using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using myfinance_web_netcore.Services;
using myfinance_web_netcore.Models;

namespace myfinance_web_netcore.Controllers;

public class PlanoContaController : Controller
{
  private readonly ILogger<HomeController> _logger;
  private readonly IPlanoContaService _planoContaService;

  public PlanoContaController(ILogger<HomeController> logger, IPlanoContaService planoContaService)
  {
    _logger = logger;
    _planoContaService = planoContaService;
  }

  public IActionResult Index()
  {
    ViewBag.ListaPlanoConta = _planoContaService.ListarPlanoContas();
    return View();
  }

  [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
  public IActionResult Error()
  {
    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
  }
}
