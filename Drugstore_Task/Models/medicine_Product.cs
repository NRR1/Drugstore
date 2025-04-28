using System.ComponentModel.DataAnnotations;

namespace Drugstore_Task.Models
{
    public class medicine_Product
    {
        [Display(Name = " Назовите название лекарства.")]
        [Required(ErrorMessage = "Такого лекарства нет.")]
        public string Name_Product { get; set; }

        [Display(Name = " Введите Фамилию")]
        [Required(ErrorMessage = "Вам нужно ввести  вашу фамилию")]
        public string Surname { get; set; }
    }
}
