using AutoMapper;

using CourseHub.Resources;
using CourseHub.Domain.Model;

namespace CourseHub.Mapping
{
    public class ResourceToModelProfile : Profile
    {
        public ResourceToModelProfile()
        {
            CreateMap<SaveCompanyResource, Company>();
        }
    }
}