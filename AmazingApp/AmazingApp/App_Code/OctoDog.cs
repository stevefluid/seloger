using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazingApp
{
    class OctoDog : IAmazingAnimals
    {
        string _name;

        public OctoDog(string name)
        {
            _name = name;
        }

        public override Types getAnimal()
        {
            return Types.Dog;
        }

        public override string says()
        {
            return "Wouf wouf!";
        }
    }
}
