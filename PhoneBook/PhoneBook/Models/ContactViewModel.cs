using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PhoneBook.Models
{
    public class ContactViewModel
    {
        [Required]
        [Display(Name = "Contact Id")]
        public int ContactId { get; set; }
        [Display(Name = "ContactNumber")]
        public string ContactNumber { get; set; }
        [Display(Name = "Type")]
        public string Type { get; set; }
        [Display(Name = "Person Id")]
        public int PersonId { get; set; }
        [Display(Name = "Person")]

        public virtual Person Person { get; set; }
    }
}