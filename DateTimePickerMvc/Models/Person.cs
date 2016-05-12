using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DateTimePickerMvc.Models
{
    public class Person
    {
        public int Id { get; set; }

        [Required(ErrorMessage="Поле обязательно для заполнения")]
        [Display(Name = "Имя",Prompt="Имя пользователя")]
        public string Name { get; set; }          
    
        [Required(ErrorMessage = "Поле обязательно для заполнения")]
        [Display(Name = "Фамилия")]
        public string FName { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd'/'MM'/'yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Дата рождения")]
        public DateTime BirthDate { get; set; }

        [Display(Name = "Страна")]         

        [Remote("CheckCountry", "Persons",ErrorMessage = "Не допустимое значение для поля 'Страна'")]
       
        public string State { get; set; }
    }
}