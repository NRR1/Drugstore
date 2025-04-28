using System.ComponentModel.DataAnnotations;

namespace Drugstore_Task.Models
{
    public class medicine_Product
    {
        [Display(Name = " Назовите название лекарства.")]
        [Required(ErrorMessage = "Такого лекарства нет.")]
        public string Name_Product { get; set; }

        [Display(Name = "Производитель лекарства")]
        [Required(ErrorMessage = "Такого производителя нет")]
        public string manufacturer { get; set; }

        [Display(Name = " Год выпуска")]
        [Required(ErrorMessage = "Год выпуска не найден.")]
        public string Year { get; set; }
    }
}
