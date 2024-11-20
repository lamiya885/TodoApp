using Microsoft.AspNetCore.Mvc;


namespace TodoApp.Controllers
{
    public class HomeController :Controller 
    {
        //public string Hi(string name,int age)
        //{
        //    return "Salam"+" "+name+"-"+age;
        //}

        // public string Vay(int id)
        //{
        //    return id;
        //}




        //public JsonResult Hi(string name,int age)
        //{
        //    JsonResult json=new JsonResult(new

        //    {
        //        name = name,
        //        age = age
        //    });
        //    return json;

        //}

        //public ContentResult Hi(string name, int age)
        //{
        //    ContentResult content = new ContentResult();
        //    content.Content ="<h1>Salam<h1>";
        //    content.ContentType="text/html";


        //    return content;

        //}

        //public ViewResult Hi (string name,int age)
        //{
        //    ViewResult view = new ViewResult();

        //    view.ViewName = "BDU";
        //    return view;
        //}

        public IActionResult Hi()
        {
            //return View();
            //return Json();

            //ViewData["name"]= "Lamiya";

            return View();
        }

    }
}
