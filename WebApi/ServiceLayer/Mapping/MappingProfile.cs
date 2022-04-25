using AutoMapper;
using DomainLayer.Entities;
using ServiceLayer.DTOs.Book;
using ServiceLayer.DTOs.Customer;



namespace ServiceLayer.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Customer, CustomerListDTO>();
            CreateMap<Book, BookListDTO>().ReverseMap();
            CreateMap<Book, BookEditDTO>().ReverseMap().ForAllMembers(m => m.Condition((dest, src, obj) => obj != null));
            CreateMap<Book, BookSearchDTO>().ReverseMap();


        }
    }
}
