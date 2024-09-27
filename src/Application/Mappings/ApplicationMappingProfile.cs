using AutoMapper;
using Application.DTOs;
using Domain.Entities;
using Domain.Enums;
using Domain.ValueObjects;

namespace Application.Mappings
{
    public class ApplicationMappingProfile : Profile
    {
        public ApplicationMappingProfile()
        {
            CreateMap<Product, ProductDTO>()
                 .ForMember(dest => dest.Price, opt => opt.MapFrom(src => src.Price.Amount))
                 .ForMember(dest => dest.Currency, opt => opt.MapFrom(src => src.Price.Currency))
                 .ForMember(dest => dest.Category, opt => opt.MapFrom(src => src.Category.ToString()))
                 .ReverseMap()
                 .ForMember(dest => dest.Price, opt => opt.MapFrom(src => new Money(src.Price, src.Currency)))
                 .ForMember(dest => dest.Category, opt => opt.MapFrom(src => Enum.Parse<ProductCategory>(src.Category)));
        }
    }
}
