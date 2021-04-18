using AutoMapper;

using Supermarket.Domain.Models;
using Supermarket.Resources;

namespace Supermarket.Mapping
{
    public class ModelToResourceProfile : Profile
    {
        public ModelToResourceProfile()
        {
            CreateMap<Category, CategoryResource>();
        }
    }   
}