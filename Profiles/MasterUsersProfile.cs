using AutoMapper;
using commander.Dtos;
using commander.Models;

namespace commander.Profiles
{
    public class MasterUsersProfile:Profile
    {
        public MasterUsersProfile()
        {
            CreateMap<MasterUser, MasterUsersReadDto>();
            // CreateMap<CommandCreateDto, Command>();
            // CreateMap<CommandUpdateDto, Command>();
            // CreateMap<Command, CommandUpdateDto>();
            // CreateMap<CommandDeleteDto,Command>();
        }
    }
}