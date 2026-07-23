using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    public interface AnimalsInterface
    {
        public void Dog();
        public void Cat();

        public List<string> GetAnimalsList();

        public string timetaken { get; }

        public List<string> GetAnimalSounds();

    }
}
