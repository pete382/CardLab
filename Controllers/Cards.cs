using Microsoft.AspNetCore.Mvc;
using CardLab.Models;

namespace CardLab.Controllers
{
    public class Cards : Controller
    {
        
        public IActionResult Index(int remaining)
        { 
        
            DrawModel result = DrawDAL.GetCard();
                 
            return View(result);
        }
      

        public IActionResult Shuffle()
        {
            ShuffleModel result = ShuffleDAL.GetShuffle();
            return RedirectToAction("Index");
        }
       

    }
}
