namespace myfinance_web_netcore.Mappers;
using AutoMapper;
using myfinance_web_netcore.Models;
using myfinance_web_netcore.Domain;

public class TransacaoMap : Profile
{
  public TransacaoMap()
  {
    CreateMap<Transacao, TransacaoModel>().ReverseMap();
  }
}