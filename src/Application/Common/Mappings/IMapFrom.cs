using AutoMapper;

namespace se22m060_swe_ca.Application.Common.Mappings;

public interface IMapFrom<T>
{
    void Mapping(Profile profile) => profile.CreateMap(typeof(T), GetType());
}
