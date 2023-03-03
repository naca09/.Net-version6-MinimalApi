using AutoMapper;

namespace SixMinApi.Profiles
{
    public class CommandProfile : Profile{
        public CommandProfile()
        {
            //Souce -> Target 
            CreateMap<Command, CommandReadDto>();
            CreateMap<CommandCreateDto, Command>();
            CreateMap<CommandUpdateDto, Command>();
        }
    }
}