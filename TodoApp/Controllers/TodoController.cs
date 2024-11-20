using System.Globalization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TodoApp.Contexts;
using TodoApp.Controllers.Models;

namespace TodoApp.Controllers
{
    public class TodoController : Controller
    {
        public async Task<IActionResult> Index()
        {
            using (TodoContext context = new TodoContext())
            {

                return View(await context.Todos.ToListAsync());

            }
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {

            return View();

        }
        [HttpPost]
        public async Task<IActionResult> Create(Todo data)
        {
            using (TodoContext context = new TodoContext())
            {
                await context.Todos.AddAsync(data);
            }
            return RedirectToAction(nameof(Index));
        }
      
        public async Task<IActionResult> Update (int? Id)
        {
            if (!Id.HasValue) return BadRequest();
            using(TodoContext context =new TodoContext())
            {
               var data= await context.Todos.FindAsync(Id.Value);
                if( data is null)  return NotFound();

                
            return View(data);
            }
        }
        [HttpPut]
        public async Task< IActionResult> Update(int? Id,Todo data)
        {
            if (!Id.HasValue) return BadRequest();
            using (TodoContext context = new TodoContext())
            {
                var entity = await context.Todos.FindAsync(Id.Value);
                if (entity is null) return NotFound();
                entity.Title = data.Title;
                entity.Description = data.Description;
                entity.DeadLine = data.DeadLine;
                await context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }


        }
        public async Task<IActionResult> Delete()
        {

            return View();

        }

        [HttpDelete]
        public async Task<IActionResult> Delete (int?  Id)
        {
            if(Id is null) return BadRequest();
            using ( TodoContext context= new TodoContext())
            {
              if( await  context.Todos.AnyAsync(x=>x.Id==Id))
                {
                    context.Todos.Remove(new Todo { Id = Id.Value });
                    await context.SaveChangesAsync();
                }
            }
            return RedirectToAction( nameof(Index));
        }

        public async Task<IActionResult> Look()
        {

            return View();

        }
        [HttpPost]
        public async Task<IActionResult> Look(int? Id, Todo data)
        {
         
            if (!Id.HasValue) return BadRequest();
            using (TodoContext context = new TodoContext())
            {
                var data1 = await context.Todos.FindAsync(Id.Value);
                if (data1 is null) return NotFound();


                return View(data);
            }


        }



    }
}
