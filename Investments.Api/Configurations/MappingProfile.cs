using AutoMapper;
using Investments.Api.Models;
using Investments.Domain.Entities;

namespace Investments.Api.Configurations
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<TokenModel, Token>()
                .ReverseMap();
        }
    }
}
