using Microsoft.EntityFrameworkCore;
using ToDoQ.Models;

namespace ToDoQ.Contexts;

public class ToDoQContext : DbContext
{
    public DbSet<ToDo> ToDos => Set<ToDo>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=todo.sqlite3");
    }
}