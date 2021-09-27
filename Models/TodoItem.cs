using System.ComponentModel.DataAnnotations;

namespace BlazorTodo.Models
{
    public class TodoItem
    {
        public int Id { get; set; }

        public bool Done { get; set; }

        [Required(ErrorMessage = "Informe o Título da Tarefa")]
        public string Title { get; set; }
    }
}