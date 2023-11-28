namespace myfinance_web_netcore.Mappers;
using AutoMapper;
using myfinance_web_netcore.Models;
using myfinance_web_netcore.Domain;

public class PlanoContaMap : Profile
{
  public PlanoContaMap()
  {
    CreateMap<PlanoConta, PlanoContaModel>().ReverseMap();
  }
}