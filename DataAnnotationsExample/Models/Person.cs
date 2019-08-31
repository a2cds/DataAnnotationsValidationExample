using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace DataAnnotationsExample.Models
{
    public class Person
    {
        public int PersonId { get; set; }
        [DataType(DataType.Text)]
        [Display(Name = "First Name: ")]
        [Required(ErrorMessage = "Entre com o nome")]
        public string FirstName { get; set; }
        [DataType(DataType.Text)]
        [Display(Name = "Last Name: ")]
        [Required(ErrorMessage = "Entre com o sobrenome")]
        public string LastName { get; set; }
        [Range(15,50)]
        [Display(Name = "Age: ")]
        [Required(ErrorMessage = "Entre com o nome")]
        public int Age { get; set; }
        [StringLength(10)]
        [Display(Name = "Description: ")]
        public string Description { get; set; }
    }
}
