using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;
using ToDoList.Repositories;

namespace ToDoList.Controllers
{
    public class TodoController : Controller
    {
        private readonly ITodoRepository _todoRepository;

        public TodoController(ITodoRepository todoRepository)
        {
            //inject depedency through constructor
            _todoRepository = todoRepository;            
        }

        public IActionResult Index()//get:/todo/ >display list of todo items
        {
            var todos = _todoRepository.GetAll();
            return View(todos);
        }

        public IActionResult Create()//get:/todo/create >show form to create new todo items
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ToDoItem todo)//post:/todo/create >handles form submission to create todo item
        {
            if (string.IsNullOrWhiteSpace(todo.Title))
            {
                ModelState.AddModelError("Title", "Title is required");
            }

            if (ModelState.IsValid)
            {
                _todoRepository.Add(todo);
                TempData["SuccessMessage"] = "Todo item created sucessfully";
                return RedirectToAction(nameof(Index));//redirect to Index()
            }
            return View(todo);
        }

        public IActionResult Edit(string id)// get: todo/edit/ >show a form to edit todo item
        {
            var todo = _todoRepository.GetById(id);
            if (todo == null)
            {
                return NotFound();
            }
            return View(todo);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(ToDoItem todo)//post: todo/edit >handles form submission to update todo item
        {
            if (string.IsNullOrWhiteSpace(todo.Title))
            {
                ModelState.AddModelError("Title", "Title is required");
            }

            if (ModelState.IsValid)
            {
                _todoRepository.Update(todo);
                TempData["SuccessMessage"] = "Todo item Updated sucessfully";
                return RedirectToAction(nameof(Index));//redirect to Index()
            }
            return View(todo);
        }

        public IActionResult Delete(string id)// get: todo/delete/ >show a form to delete todo item
        {
            var todo = _todoRepository.GetById(id);
            if (todo == null)
            {
                return NotFound();
            }
            return View(todo);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(string id)//post: todo/deleteConfirmation/ >handle deleteion of todo item
        {
            var todo =_todoRepository.GetById(id);
            if (todo==null)
            {
                return NotFound();   
            }
            _todoRepository.Delete(id);
            TempData["SuccessMessage"] = "Todo item deleted sucessfully";
            return RedirectToAction(nameof(Index));
        }
    }
}
