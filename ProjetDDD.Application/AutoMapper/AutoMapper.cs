using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ProjetDDD.Domain.Entites;
using ProjetDDD.Application.Entites;

using AutoMapper;
using ProjetDDD.Application.Services;

namespace ProjetDDD.Application.AutoMapper
{
    public static class AutoMapperWebConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.AddProfile(new AuthorProfile());
            });
        }
    }

    public class AuthorProfile : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<Author, Author_DTO>();
            Mapper.CreateMap<Author_DTO, Author>();
            
                //.ForMember(x=>x.AuthorId, o=>o.MapFrom(s=>s.AuthorId))
                //.ForMember(x => x.Forenames, o => o.MapFrom(s => s.Forenames))
                //.ForMember(x => x.Surname, o => o.MapFrom(s => s.Surname));
        }
    }
    
}
