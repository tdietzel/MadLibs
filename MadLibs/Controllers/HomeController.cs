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
    public ActionResult RoadTripLib(string emotionOne, string adjectiveOne, string placeOne, string thingOne, string thingTwo, string placeTwo, string foodOne, string thingThree, string thingFour, string treatOne, string placeThree, string adjectiveTwo) {
      MadLibVariables newMadLib = new MadLibVariables();
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
  }
}