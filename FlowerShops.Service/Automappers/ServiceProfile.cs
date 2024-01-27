

using AutoMapper;
using AutoMapper.Extensions.EnumMapping;
using FlowerShops.Context.Contracts.Enums;
using FlowerShops.Context.Contracts.Models;
using FlowerShops.Service.Contracts.Enums;
using FlowerShops.Service.Contracts.Models;

namespace FlowerShops.Service.Automappers
{
    public class ServiceProfile : Profile 
    {
        public ServiceProfile()
        {
            CreateMap<AccessLevelTypes, AccessLevelTypesModel>()
                .ConvertUsingEnumMapping(opt => opt.MapByName())
                .ReverseMap();
            CreateMap<ProductTypes, ProductTypesModel>()
                .ConvertUsingEnumMapping(opt => opt.MapByName())
                .ReverseMap();
            

            CreateMap<Location, LocationModel>(MemberList.Destination);

            CreateMap<Order, OrderModel>(MemberList.Destination)
                .ForMember(opt => opt.Service, next => next.Ignore())
                .ForMember(opt => opt.Product, next => next.Ignore())
                .ForMember(opt => opt.Seller, next => next.Ignore())
                .ForMember(opt => opt.Client, next => next.Ignore());

            CreateMap<Person, PersonModel>(MemberList.Destination);

            CreateMap<Product, ProductModel>(MemberList.Destination);

            CreateMap<FlowerShops.Context.Contracts.Models.Service, ServiceModel>(MemberList.Destination);

            CreateMap<Worker, WorkerModel>(MemberList.Destination);
               
        }
    }
}
