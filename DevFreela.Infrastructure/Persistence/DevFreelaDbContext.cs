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
                new Project("Meu projeto ASPNET Core 1", "Minha Descricao de Projeto 1", 1, 1, 10000),
                new Project("Meu projeto ASPNET Core 2", "Minha Descricao de Projeto 2", 1, 1, 20000),
                new Project("Meu projeto ASPNET Core 3", "Minha Descricao de Projeto 3", 1, 1, 30000)
            };

            Users = new List<User>
            {
                new User("Ana Maria", "anamaria@dev.com.br", new DateTime(1990,1,1)),
                new User("Barbara Bejin", "barbarabejin@dev.com.br", new DateTime(1992,3,2)),
                new User("Carlos Filin", "carlosfilin@dev.com.br", new DateTime(1991,4,6))
            };

            Skills = new List<Skill>
            {
                new Skill(".Net Core"),
                new Skill(".C#"),
                new Skill("F#"),
            };
        }
        public List<Project> Projects { get; private set; }
        public List<User> Users { get; private set; }
        public List<Skill> Skills { get; private set; }
        public List<ProjectComment> ProjectComments { get; private set; }
    }
}
