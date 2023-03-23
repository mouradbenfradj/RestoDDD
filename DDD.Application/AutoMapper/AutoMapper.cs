using AutoMapper;
using DDD.Application.Entites;
using DDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Application.AutoMapper
{
    public static class AutoMapperWebConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.AddProfile(new AdminProfile());
                cfg.AddProfile(new AffectationProfile());
                cfg.AddProfile(new ConducteurProfile());
                cfg.AddProfile(new PassagerProfile());
                cfg.AddProfile(new ReclamationProfile());

            });
        }
    }

    public class AdminProfile : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<Admin, Admin_DTO>();
            Mapper.CreateMap<Admin_DTO, Admin>();


        }
    }

    public class AffectationProfile : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<Affectation, Affectation_DTO>();
            Mapper.CreateMap<Affectation_DTO, Affectation>();


        }
    }

    public class ConducteurProfile : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<Conducteur, Conducteur_DTO>();
            Mapper.CreateMap<Conducteur_DTO, Conducteur>();


        }
    }


    public class PassagerProfile : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<Passager, Passager_DTO>();
            Mapper.CreateMap<Passager_DTO, Passager>();


        }
    }


    public class ReclamationProfile : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<Reclamation, Reclamation_DTO>();
            Mapper.CreateMap<Reclamation_DTO, Reclamation>();


        }
    }
}
