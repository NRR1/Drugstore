using System.ComponentModel.DataAnnotations;

namespace Drugstore_Task.Models
{
    public class medicine_Product
    {
        [Display(Name = " Назовите название лекарства.")]
        [Required(ErrorMessage = "Такого лекарства нет.")]
        public string Name_Product { get; set; }
    }
}
