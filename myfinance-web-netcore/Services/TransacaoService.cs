using myfinance_web_netcore.Infrastructure;
using myfinance_web_netcore.Models;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using myfinance_web_netcore.Domain;

namespace myfinance_web_netcore.Services;

public class TransacaoService : ITransacaoService
{
  private readonly MyFinanceDbContext _myFinanceDbContext;
  private readonly IMapper _mapper;

  public TransacaoService(
    MyFinanceDbContext myFinanceDbContext, 
    IMapper mapper)
  {
    _myFinanceDbContext = myFinanceDbContext;
    _mapper = mapper;
  }

  public IEnumerable<TransacaoModel> ListarTransacoes()
  {
    var listaTransacao = _myFinanceDbContext.Transacao.ToList();
    var lista = _mapper.Map<IEnumerable<TransacaoModel>>(listaTransacao);
    return lista;
  }

  public TransacaoModel RetornarRegistro(int id)
  {
    var item = _myFinanceDbContext.Transacao.Where(x => x.Id == id).First();
    var lista = _mapper.Map<TransacaoModel>(item);
    return lista;
  }

  public void Salvar(TransacaoModel model, string tipoPlanoConta) 
  {

    var instancia = new Transacao() 
    {
      Id = model.Id,
      Historico = model.Historico,
      Tipo = tipoPlanoConta,
      Valor = model.Valor,
      PlanoContaId = model.PlanoContaId,
      Data = model.Data
    };

    if (instancia.Id == null)
    {
      _myFinanceDbContext.Transacao.Add(instancia);
    }
    else 
    {
      _myFinanceDbContext.Transacao.Attach(instancia);
      _myFinanceDbContext.Entry(instancia).State = EntityState.Modified;
    }

    _myFinanceDbContext.SaveChanges();
  }

  public void Excluir(int id)
  {
    var item = _myFinanceDbContext.Transacao.Where(x => x.Id == id).First();
    _myFinanceDbContext.Transacao.Attach(item);
    _myFinanceDbContext.Transacao.Remove(item);
    _myFinanceDbContext.SaveChanges();
  }
}
