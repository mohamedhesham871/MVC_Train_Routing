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
        
        public ContentResult  GETMovie(int id,string name)
        {
            //return $"Movie ****** {id} and name is {name}";
            //   ContentResult result = new ContentResult();
            // result.Content = $"Movie ****** {id} and name is {name}";
            // result.StatusCode = 900;
            return Content($"Movie ****** {id} and name is {name}");
           // return result;
        }
        //To excute Any action =>> http://{Base URL }/{Controller name}/{Action Name}/
    }
}
