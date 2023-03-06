using ExercicePokemon.Models;
using Microsoft.AspNetCore.Mvc;

namespace Exercise_1.Contollers
{
    public class PokemonController : Controller
    {
        public IActionResult Index()
        {
            var baseDeDonnees = new FausseBaseDeDonnees();
            var donnees = baseDeDonnees.ObtenirListePokemons();
            return View(donnees);
        }

        public IActionResult Consulter(int id)
        {
            var baseDeDonnees = new FausseBaseDeDonnees();
            var donnees = baseDeDonnees.ObtenirListePokemons();
            foreach (var element in donnees)
            {
                if (element.Id == id)
                {
                    return View(element);
                }
            }
            return NotFound();
        }
    }
}
