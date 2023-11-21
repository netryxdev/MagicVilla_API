using AutoMapper;
using MagicVilla_Web.Models;
using MagicVilla_Web.Models.Dto;

namespace MagicVilla_Web
{
    public class MappingConfig : Profile
    {
        public MappingConfig() 
        {
            // Villa Map

            CreateMap<VillaDTO, VillaCreateDTO>();
            CreateMap<VillaDTO, VillaUpdateDTO>();

            // VillaNumber Map

            CreateMap<VillaNumberDTO, VillaNumberCreateDTO>();
            CreateMap<VillaNumberDTO, VillaNumberUpdateDTO>();
        }
    }
}
