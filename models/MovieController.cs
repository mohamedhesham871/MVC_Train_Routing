using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace MVC_Train_Routing.models
{
    public class MovieController:Controller
    {
        public string? name { get; set; }
        public int ID  { get; set; }
        public  string ?Title { get; set; }
        public int Code  { get; set; }


        //First Action 
        
        //public ContentResult  GETMovie(int id,string name)
        //{
        //    //return $"Movie ****** {id} and name is {name}";
        //    //   ContentResult result = new ContentResult();
        //    // result.Content = $"Movie ****** {id} and name is {name}";
        //    // result.StatusCode = 900;
        //    return Content($"Movie ****** {id} and name is {name}");
        //   // return result;
        //}

        public IActionResult GETMovie(int id, string name)
        {
            // if id  =0 =>Bad Request
            // if id <10 =>Not Found 
            //if id >=10 =>return content
            if (id == 0)
                return  BadRequest();
            else if (id < 10)
                return  NotFound();
                return  Content($"Movie ****** {id} and name is {name}");
        }

        public IActionResult testRedirectAction()
        {
            return Redirect("https://www.youtube.com/");
        }
        public IActionResult testRedirectToGETmovie()
        {
            return RedirectToAction("GETMovie");
            //return RedirectToRoute("default");
        }
        //To excute Any action =>> http://{Base URL }/{Controller name}/{Action Name}/
    }
}
