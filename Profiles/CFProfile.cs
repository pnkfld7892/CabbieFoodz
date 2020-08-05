using AutoMapper;
using CabbieFoodz.ViewModels;
using CabbieFoodz.Models;

namespace CabbieFoodz.Profiles
{
    public class CFProfile : Profile
    {
        public CFProfile()
        {
            CreateMap<Food, FoodzViewModel>();
            CreateMap<FoodzViewModel, Food>();
        }
    }
}