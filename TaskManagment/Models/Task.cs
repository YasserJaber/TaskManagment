using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TaskManagment.Models
{
    public class Task
    {
        [Required]
        [Display(Name = "Task ID")]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Task Name")]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Due Date")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", NullDisplayText = "", ConvertEmptyStringToNull = true, ApplyFormatInEditMode = true, HtmlEncode = true)]
        public DateTime? DueDate { get; set; }
    }
}