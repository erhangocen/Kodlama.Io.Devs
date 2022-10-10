using Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ProgrammingLanguage : Entity
    {
        public string Name { get; set; }
        public ICollection<Technology> Technologies { get; set; }
        public ProgrammingLanguage()
        {
        }

        public ProgrammingLanguage(int ıd, string name)
        {
            Id = ıd;
            Name = name;
        }
    }
}
