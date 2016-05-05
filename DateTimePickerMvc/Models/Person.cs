using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DateTimePickerMvc.Models
{
    public class Person
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Имя")]
        public string Name { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd'/'MM'/'yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Дата рождения")]
        public DateTime BirthDate { get; set; }

        [Display(Name = "Страна")]
        public string State { get; set; }
    }
}