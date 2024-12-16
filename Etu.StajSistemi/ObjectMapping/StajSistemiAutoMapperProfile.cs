using Etu.StajSistemi.OgrenciStajBasvurusus;
using AutoMapper;
using Etu.StajSistemi.Pages.Kurum;
using Etu.StajSistemi.Pages.OgrenciStajBasvurusus;
using Volo.Abp.Content;

namespace Etu.StajSistemi.ObjectMapping;

public class StajSistemiAutoMapperProfile : Profile
{
    public StajSistemiAutoMapperProfile()
    {
        /* Create your AutoMapper object mappings here */

        CreateMap<IFormFile, IRemoteStreamContent>()
            .ConvertUsing<FormFileToRemoteStreamContentConverter>();

        CreateMap<OgrenciStajBasvurusu, OgrenciStajBasvurusuDto>();

        CreateMap<Create.CreateOgrenciStajBasvurusuModel, OgrenciStajBasvurusuCreateDto>();

        CreateMap<Onayla.KurumOnayViewModel, KurumOnayDto>();
    }

    public class FormFileToRemoteStreamContentConverter : ITypeConverter<IFormFile, IRemoteStreamContent>
    {
        public IRemoteStreamContent Convert(IFormFile source, IRemoteStreamContent destination, ResolutionContext context)
        {
            return new RemoteStreamContent(source.OpenReadStream(), source.FileName, source.ContentType);
        }
    }
}