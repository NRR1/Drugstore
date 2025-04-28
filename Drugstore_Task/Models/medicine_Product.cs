using System.ComponentModel.DataAnnotations;

namespace Drugstore_Task.Models
{
    public class medicine_Product
    {
        [Display(Name = " Введите Имя")]
        [Required(ErrorMessage = "Вам нужно ввести  ваше имя")]
        public string Name { get; set; }
    }
}
