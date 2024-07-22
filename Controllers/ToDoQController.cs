using Microsoft.AspNetCore.Mvc;
using ToDoQ.Contexts;
using ToDoQ.Models;

namespace ToDoQ.Controllers;

public class ToDoQController : Controller
{
    private readonly ToDoQContext _context;

    public ToDoQController(ToDoQContext context) {
        _context = context;
    }

    public IActionResult Index()
    {
        var toDos = _context.ToDos.ToList();
        return View(toDos);
    }
}
