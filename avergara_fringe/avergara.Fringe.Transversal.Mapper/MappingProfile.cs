using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using avergara.Fringe.Domain.Entity;
using avergara.Fringe.Application.DTO;
using avergara.Fringe.Domain.Entity.entities;


namespace avergara.Fringe.Transversal.Mapper
{

    //heredamos de profile para usar autoMapper
    public class MappingProfile : Profile
    {

        public MappingProfile()
        {
            //cuando el el mapeo entre el origen y el destino son identicos solo ponemo esto.
            CreateMap<Domain.Entity.Fringe, FringeDto>().ReverseMap();
            CreateMap<SpecialFringe, FringeDto>().ReverseMap();
            CreateMap<CategoryFringe,CategoryFringeDto>().ReverseMap();
            CreateMap<TypeFringe, TypeFringeDto>().ReverseMap();
            CreateMap<Comment, CommentDto>().ReverseMap();
            CreateMap<Media, MediaDto>().ReverseMap();
            CreateMap<TypeComment, TypeCommentDto>().ReverseMap();
            CreateMap < TypeMedia, TypeMediaDto>().ReverseMap();
            CreateMap<Login,LoginDto>().ReverseMap();

            //para el caso que tengamos que hacer el mapeo campo a campo...

            //CreateMap<Customers, CustomersDto>().ReverseMap()
            //    .ForMember(destination => destination.CustomerId, source => source.MapFrom(src => src.CustomerId))
            //    .ForMember(destination => destination.CompanyName, source => source.MapFrom(src => src.CompanyName))
            //    .ForMember(destination => destination.ContactName, source => source.MapFrom(src => src.ContactName))
            //    .ForMember(destination => destination.ContactTitle, source => source.MapFrom(src => src.ContactTitle))
            //    .ForMember(destination => destination.Address, source => source.MapFrom(src => src.Address))
            //    .ForMember(destination => destination.City, source => source.MapFrom(src => src.City))
            //    .ForMember(destination => destination.Region, source => source.MapFrom(src => src.Region))
            //    .ForMember(destination => destination.PostalCode, source => source.MapFrom(src => src.PostalCode))
            //    .ForMember(destination => destination.Country, source => source.MapFrom(src => src.Country))
            //    .ForMember(destination => destination.Phone, source => source.MapFrom(src => src.Phone))

            //    .ForMember(destination => destination.Fax, source => source.MapFrom(src => src.Fax)).ReverseMap();

        }



    }
}
