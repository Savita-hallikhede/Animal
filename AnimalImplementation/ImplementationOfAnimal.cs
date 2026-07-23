using Animal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalImplementation
{
    public class ImplementationOfAnimal:AnimalsInterface
    {
        private List<string> _GetAnimalsList;
        private List<string> _GetAnimalSounds;
        private string _ObjectCallingTime;

        public ImplementationOfAnimal()
        {
           _GetAnimalsList = new List<string> { "Dog", "Cat","lion","tiger" };
           var data = new List<string> { "Bark", "Meow","roar","roar" };
           _GetAnimalSounds = data;
            Thread.Sleep(1000);
            _ObjectCallingTime = DateTime.Now.ToString();
        }

        public void Dog()
        {
            Console.WriteLine("Dog will bark");
        }

        public void Cat()
        {
            Console.WriteLine("Cat will meow");
        }

        public List<string> GetAnimalsList()
        {
            _GetAnimalsList.Add("elephant");
            return _GetAnimalsList;
        }

        public string timetaken
        {
            get { return _ObjectCallingTime; }
        }
        
        public List<string> GetAnimalSounds()
        {
            return _GetAnimalSounds;
        }

    }
    
    
}
