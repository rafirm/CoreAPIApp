using AutoMapper;
using commander.Dtos;
using commander.Models;

namespace commander.Profiles
{
    public class CommandProfile:Profile
    {
        public CommandProfile()
        {
            CreateMap<Command, CommandReadDto>();
            CreateMap<CommandCreateDto, Command>();
            CreateMap<CommandUpdateDto, Command>();
            CreateMap<Command, CommandUpdateDto>();
            CreateMap<CommandDeleteDto,Command>();
        }
    }
}