using Microsoft.AspNetCore.Mvc;
using MadLib.Models;

namespace MadLib.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult HomePage() { return View(); }

    [Route("/road-trip-form")]
    public ActionResult RoadTripForm() { return View(); }
    
    [Route("/road-trip")]
    public ActionResult RoadTripLib(string emotionOne, string adjectiveOne, string placeOne, string thingOne, string thingTwo, string placeTwo, string foodOne, string thingThree, string thingFour, string treatOne, string placeThree, string adjectiveTwo)
    {
      MadLibVariablesRoadTrip newMadLib = new MadLibVariablesRoadTrip();
      newMadLib.EmotionOne = emotionOne;
      newMadLib.AdjectiveOne = adjectiveOne;
      newMadLib.PlaceOne = placeOne;
      newMadLib.ThingOne = thingOne;
      newMadLib.ThingTwo = thingTwo;
      newMadLib.PlaceTwo = placeTwo;
      newMadLib.FoodOne = foodOne;
      newMadLib.ThingThree = thingThree;
      newMadLib.ThingFour = thingFour;
      newMadLib.TreatOne = treatOne;
      newMadLib.PlaceThree = placeThree;
      newMadLib.AdjectiveTwo = adjectiveTwo;
      return View(newMadLib);
    }

    [Route("/christmas-form")]
    public ActionResult ChristmasForm() { return View(); }

    [Route("/christmas")]
    public ActionResult ChristmasLib(string nounOne, string placeOne, string nounTwo, string verbOne, string animalOne, string adverbOne, string adjectiveOne, string onomatopoedicOne, string foodOne, string foodTwo, string adjectiveTwo, string clothingOne, string adjectiveThree, string exclamationOne, string numberOne)
    {
      MadLibVariablesChristmas newMadLib = new MadLibVariablesChristmas();
      newMadLib.NounOne = nounOne;
      newMadLib.PlaceOne = placeOne;
      newMadLib.NounTwo = nounTwo;
      newMadLib.VerbOne = verbOne;
      newMadLib.AnimalOne = animalOne;
      newMadLib.AdverbOne = adverbOne;
      newMadLib.AdjectiveOne = adjectiveOne;
      newMadLib.OnomatopoedicOne = onomatopoedicOne;
      newMadLib.FoodOne = foodOne;
      newMadLib.FoodTwo = foodTwo;
      newMadLib.AdjectiveTwo = adjectiveTwo;
      newMadLib.ClothingOne = clothingOne;
      newMadLib.AdjectiveThree = adjectiveThree;
      newMadLib.ExclamationOne = exclamationOne;
      newMadLib.NumberOne = numberOne;
      return View(newMadLib);
    }
  }
}