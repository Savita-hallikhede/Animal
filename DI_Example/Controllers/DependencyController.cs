
using Animal;
using AnimalImplementation;
using Microsoft.AspNetCore.Mvc;

namespace DI_Example.Controllers
{
    public class DependencyController : Controller
    {
        //Constructor Injection

        //private AnimalsInterface ianimal;
        //public DependencyController(AnimalsInterface animal)
        //{
        //    this.ianimal = animal;
        //}



        ////Method Injection
        //[Route("Soumya")]
        //public List<string> AnimalData([FromServices] AnimalsInterface animalService)
        //{
        //    //AnimalsInterface ianimal;
        //    //ianimal = animalService;
        //    //return ianimal.GetAnimalSounds();

        //    //animalService.GetAnimalSounds();

        //    List<string>animalSounds1 = animalService.GetAnimalSounds();
        //    List<string>animalSounds2 = animalService.GetAnimalsList();

        //    List<string> animalSounds = new List<string>();
        //    animalSounds.AddRange(animalSounds1);
        //    animalSounds.AddRange(animalSounds2);


        //    return animalSounds;


        //}


        [HttpGet]
        public List<string> data()
        {
            ImplementationOfAnimal ianimal = new ImplementationOfAnimal();
            List<string> animalsList = ianimal.GetAnimalsList();
            return (animalsList);
        }



        public IActionResult Index()
        {
            return View();
        }

        public IActionResult RazorDependencyInjection()
        {
            return View();
        }
    }
}
