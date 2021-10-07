using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reflexion.Models.Reflection
{
    public class Maestros: Persona, IReflection
    {
        public string materia { get; set; }
        public string cedula { get; set; }
    }
}
