using System.ComponentModel.DataAnnotations;

namespace ToDoList.Models
{
    public class ToDo
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(300)]
        [StringLength(300)]
        public string Task { get; set; }
        [Display(Name ="Due Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? DueDate { get; set; }
        [MaxLength(10)]
        [StringLength(10)]
        public string? priority { get; set; }
    }
}
