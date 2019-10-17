using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSSerialize
{
    public class PersonStartSerialize
    {
        public List<string> names = new List<string>();
        public List<string> types = new List<string>();

        public PersonStartSerialize() { }

        public PersonStartSerialize(List<string> newNames, List<string> newTypes)
        {
            names = newNames;
            types = newTypes;
        }
    }
}
