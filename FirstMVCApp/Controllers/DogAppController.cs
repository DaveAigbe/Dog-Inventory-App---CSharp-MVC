using Microsoft.AspNetCore.Mvc;
using FirstMVCApp.Models; // Add the models to this controller

namespace FirstMVCApp.Controllers
{
    public class DogAppController : Controller // will link to the view that says DogApp
    {
        // Use static so that after page is redirected to index, list will not be empty
        private static List<DogViewModel> dogs = new List<DogViewModel>();  // List<T> demonstrates a list of objects

        public IActionResult Index() // looks for method name inside of linked view
        {

            // DogViewModel and its information is being passed to the "Index" View, to decide how it will be presented 
            return View(dogs);
        }

        public IActionResult Create() // This will return the view with the form
        {
         
            DogViewModel dogVm = new DogViewModel(); // when Create tab is clicked, none of the information will be filled out, creates a new object each time

            return View(dogVm); // return the view with the new dog information
        }

        // The information from the form will automatically get created as a new object 
        public IActionResult CreateDog(DogViewModel newDog) // When user clicks "add" on form this interface will be called
        {
            // return View("Index"); 
            dogs.Add(newDog);  // After user has entered dog object, add it to the list

            // the previous return will not work because the DogViewModel will have no information, so the fields in the view will be null
            // RedirectToAction returns the action listed as "Index" instead with all the information so the fields will not be empty
            return RedirectToAction(nameof(Index)); 
        }
    }
}

