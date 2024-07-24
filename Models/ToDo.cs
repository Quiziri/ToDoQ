using System.ComponentModel.DataAnnotations;
using ToDoQ.Validators;

namespace ToDoQ.Models;

public class ToDo
{
    public int Id { get; set; }

    [Display(Name = "Título")]
    [Required(ErrorMessage = "O campo {0} é obrigatório")]
    [StringLength(100, MinimumLength = 3, ErrorMessage = "O campo {0} deve ter entre {2} e {1} caracteres")]
    public string Title { get; set; } = string.Empty;
    public DateTime CreateAt { get; set; }
    
    [Display(Name = "Título")]
    [Required(ErrorMessage = "O campo {0} é obrigatório")]
    [FutureOrPresent]
    public DateOnly Deadline { get; set; }
    public DateOnly? FinishedAt { get; set; }
}