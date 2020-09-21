using AutoMapper;
using vega.Controllers.Resources;
using vega.Domain;

namespace vega.Mapping
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            base.CreateMap<Make, MakeResource>();
            base.CreateMap<Model, ModelResource>();
            base.CreateMap<Feature, FeatureResource>();
        }       
    }
}