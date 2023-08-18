using DevFreela.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Infrastructure.Persistence
{
    public class DevFreelaDbContext
    {
        public DevFreelaDbContext()
        {
            Projects = new List<Project>
            {
                new Project("Projeto .Net Core 1", "Descrição proj. 1", 1, 1, 10000),
                new Project("Projeto .Net Core 2", "Descrição proj. 2", 1, 1, 20000),
                new Project("Projeto .Net Core 3", "Descrição proj. 3", 1, 1, 30000),
            };

            Users = new List<User>
            {
                new User("Willian", "willian@dev.com", new DateTime(1992,1,1)),
                new User("Maria", "maria@dev.com", new DateTime(1992,1,1)),
                new User("Joana", "joana@dev.com", new DateTime(1992,1,1)),
            };

            Skills = new List<Skill>
            {
                new Skill("Html" ),
                new Skill("Sql" ),
                new Skill(".Net Core" ),
            };

        }
        public List<Project> Projects { get; set; }
        public List<User> Users { get; set; }
        public List<Skill> Skills { get; set; }
    }
}
