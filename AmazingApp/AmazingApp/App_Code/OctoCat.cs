using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazingApp
{
    class OctoCat : IAmazingAnimals
    {
        string _name;

        public OctoCat(string name)
        {
            _name = name;
        }

        public override Types getAnimal()
        {
            return Types.Cat;
        }

        public override string says()
        {
            return "Hello i'm a OctoCat";
        }
    }
}
