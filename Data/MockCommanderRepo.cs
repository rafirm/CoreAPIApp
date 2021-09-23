using System.Collections.Generic;
using commander.Models;

namespace commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public void CreateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command{Id=0,HowTo="Boil an egg",Line="Boil water",Platform="Kettle & pan"},
                new Command{Id=1,HowTo="Make a cup of tea",Line="Place tea bag in cup",Platform="Kettle & cup"},
                new Command{Id=2,HowTo="Cut bread",Line="Get a knife",Platform="Knife & chopping board"}

            };
            return commands;

        }

        public Command GetCommandById(int id)
        {
            return new Command{Id=0,HowTo="Boil an egg",Line="Boil water",Platform="Kettle & pan"};
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }
    }
}