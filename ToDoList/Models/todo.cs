using System.ComponentModel.DataAnnotations;

namespace ToDoList.Models
{
    public class ToDo
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Task { get; set; }
        [Display(Name ="Due Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? DueDate { get; set; }
        public string? priority { get; set; }
    }
}
