using AutoMapper;
using back_usuarios_tg.DAL.DTO;
using back_usuarios_tg.DAL.Models;

namespace back_usuarios_tg
{
    public class AutoMapperProfileConfiguration : Profile
    {
        public AutoMapperProfileConfiguration()
        {
            // Mapeando a classe USUARIO
            CreateMap<UsuarioDTO, Usuario>().
                AfterMap((dto, model) => model.Id = dto.Id);
            CreateMap<Usuario, UsuarioDTO>()
                .AfterMap((model, dto) => dto.Id = model.Id);
        }
    }
}
