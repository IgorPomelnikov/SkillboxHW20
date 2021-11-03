using SkillboxHW20.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkillboxHW20.Interfaces
{
    public interface IPersonCollection
    {
        public IEnumerable<Person> Persons { get; }
    }
}
