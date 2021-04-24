using AutoMapper;

using CourseHub.Domain.Model;
using CourseHub.Resources;

namespace CourseHub.Mapping
{
    public class ModelToResourceProfile : Profile
    {
        public ModelToResourceProfile()
        {
            CreateMap<Company, CompanyResource>();
        }
    }
}