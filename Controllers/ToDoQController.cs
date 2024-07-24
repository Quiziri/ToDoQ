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
        ViewData["Title"] = "Lista de Tarefas";
        var toDos = _context.ToDos.ToList();
        return View(toDos);
    }

    public IActionResult Create()
    {
        ViewData["Title"] = "Nova Tarefa";
        return View("Form");
    }
    [HttpPost]
    public IActionResult Create(ToDo toDo)
    {
        toDo.CreateAt = DateTime.Now;
        _context.ToDos.Add(toDo);
        _context.SaveChanges();
        return RedirectToAction(nameof(Index));
    }

    public IActionResult Edit(int id)
    {
        var toDo = _context.ToDos.Find(id);
        ViewData["Title"] = "Editar Tarefa";
        return View("Form", toDo);
    }

    [HttpPost]
    public IActionResult Edit(ToDo toDo)
    {
        _context.ToDos.Update(toDo);
        _context.SaveChanges();
        return RedirectToAction(nameof(Index));
    }
}
