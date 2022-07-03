using System.Collections.Generic;
using AutoMapper;
using commander.Data;
using commander.Dtos;
using commander.Models;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace commander.Controller
{
    [Route("api/users")]
    [ApiController]
    public class UsersController:ControllerBase
    {
        private readonly IUserRegistrationRepo _repository;
        private readonly IMapper _mapper;

        public UsersController(IUserRegistrationRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        [HttpGet]
        public ActionResult <IEnumerable<MasterUsersReadDto>>GetAllUsers()
        {
            var userItems = _repository.GetAllUsers();
            return Ok(_mapper.Map<IEnumerable<MasterUsersReadDto>>(userItems));

        }

        [HttpGet("{id}",Name = "GetUserById")]
        public ActionResult<IEnumerable<MasterUsersReadDto>>GetUserById(int id)
        {
            var userItem = _repository.GetUserById(id);
            if(userItem != null)
            {
            return Ok(_mapper.Map<MasterUsersReadDto>(userItem));

            }
            return NotFound();
        }

        // [HttpPost]
        // public ActionResult <CommandReadDto>CreateCommand(CommandCreateDto commandCreateDto)
        // {
        //     var commandModel = _mapper.Map<Command>(commandCreateDto);
        //     _repository.CreateCommand(commandModel);
        //     _repository.SaveChanges();

        //     var commandReadDto = _mapper.Map<CommandReadDto>(commandModel);
            
        //     return(CreatedAtRoute(nameof(GetCommandById),new{Id = commandReadDto.Id},commandReadDto));

        // }

        // [HttpPut("{id}")]
        // public ActionResult<CommandReadDto>UpdateCommand(int id,CommandUpdateDto commandUpdateDto)
        // {
        //     var commandModelFromRepo = _repository.GetCommandById(id);

        //     if(commandModelFromRepo == null)
        //     {
        //         return NotFound();
        //     }
        //     _mapper.Map(commandUpdateDto,commandModelFromRepo);
        //     _repository.UpdateCommand(commandModelFromRepo);
        //     _repository.SaveChanges();
        //     return NoContent();

        // }

        // [HttpPatch("{id}")]
        // public ActionResult PartialCommandUpdate(int id,JsonPatchDocument<CommandUpdateDto>patchDoc)
        // {
        //      var commandModelFromRepo = _repository.GetCommandById(id);

        //     if(commandModelFromRepo == null)
        //     {
        //         return NotFound();
        //     }
        //     var commandToPatch = _mapper.Map<CommandUpdateDto>(commandModelFromRepo);
        //     patchDoc.ApplyTo(commandToPatch,ModelState);

        //     if(!TryValidateModel(commandToPatch))
        //     {
        //         return ValidationProblem(ModelState);
        //     }

        //     _mapper.Map(commandToPatch,commandModelFromRepo);
        //     _repository.UpdateCommand(commandModelFromRepo);
        //     _repository.SaveChanges();

        //     return NoContent();



        // }
        // [HttpDelete("{id}")]
        // public ActionResult DeleteCommand(int id)
        // {
        //      var commandModelFromRepo = _repository.GetCommandById(id);

        //     if(commandModelFromRepo == null)
        //     {
        //         return NotFound();
        //     }

            
        //     _repository.DeleteCommand(commandModelFromRepo);
        //     _repository.SaveChanges();

        //     return NoContent();
        // }

    }
}