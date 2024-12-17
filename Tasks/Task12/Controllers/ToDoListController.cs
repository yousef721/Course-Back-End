using Microsoft.AspNetCore.Mvc;
using Task12.Data;
using Task12.Models;

namespace Task12.Controllers
{
    public class ToDoListController : Controller
    {
        private ApplicationDbContext _context = new ApplicationDbContext();
        public IActionResult Index()
        {
            var list = _context.ToDoLists.ToList();
            return View(list);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ToDoList toDoList)
        {
            if (toDoList != null)
            {
                _context.ToDoLists.Add(toDoList);
                _context.SaveChanges();
                TempData["success"] = "Created Task Successfully";
                return RedirectToAction("Index");
            }
            return RedirectToAction("NotFoundPage", "Index");
        }
        public IActionResult Edit(int itemId)
        {
            var item = _context.ToDoLists.Find(itemId);
            if (item != null)
            {
                return View(item);
            }
            return RedirectToAction("NotFoundPage", "Home");
        }

        [HttpPost]
        public IActionResult Edit(ToDoList toDoList)
        {
            if (toDoList != null)
            {
                _context.ToDoLists.Update(new ToDoList
                {
                    Id = toDoList.Id,
                    Title = toDoList.Title,
                    Description = toDoList.Description,
                    Deadline = toDoList.Deadline
                });
                _context.SaveChanges();
                TempData["success"] = "Edit Task Successfully";
                return RedirectToAction("Index");
            }
            return RedirectToAction("NotFoundPage", "Index");
        }
        public IActionResult Delete(int itemId)
        {
            var item = _context.ToDoLists.Find(itemId);
            if (item != null)
            {
                _context.ToDoLists.Remove(item);
                _context.SaveChanges();
                TempData["success"] = "Deleted Task Successfully";
                return RedirectToAction("Index");
            }
            return RedirectToAction("NotFoundPage", "Home");
        }
    }
}
