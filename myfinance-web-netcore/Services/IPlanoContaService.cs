using myfinance_web_netcore.Domain;

namespace myfinance_web_netcore.Services;

public interface IPlanoContaService
{
  IEnumerable<PlanoConta> ListarPlanoContas();
}