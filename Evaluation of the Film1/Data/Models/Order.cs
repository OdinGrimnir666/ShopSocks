using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;

namespace Evaluation_of_the_Film1.Data.Models
{
    public class Order
    {
        [BindNever]
        public int id { get; set; } 
        [Display(Name ="Ведите Имя")]
        [StringLength(25)]
        [Required(ErrorMessage="Длина символом  25 символов")]
        public string name { get; set; }
        [Display(Name = "Фамилия")]
        [StringLength(25)]
        [Required(ErrorMessage = "Длина символом меньше265 символов")]
        public string surname { get; set; }
        [Display(Name = "Ведите Адрес")]
        [StringLength(30)]
        [Required(ErrorMessage = "Длина символом меньше 15 символов")]

        public string adress { get; set; }
        [Display(Name = "Ведите Номер")]
        [StringLength(25)]
        //[DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Длина символом меньше 10 символов")]

        public string phone { get; set; }

        [Display(Name = "Ведите Email")]
        //[DataType(DataType.EmailAddress)]
        [StringLength(30)]
        [Required(ErrorMessage = "Длина символом меньше 15 символов")]

        public string email { get; set; }
        [BindNever]
        [ScaffoldColumn(false)]
        public  DateTime orderTime { get; set; }


        [BindNever]
        public List<OrderDeteil> OrderDetails { get; set; }



    }
}
