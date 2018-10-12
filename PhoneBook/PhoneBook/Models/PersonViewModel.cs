using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PhoneBook.Models
{
    public class PersonViewModel

    {
        [Required]
            [Display(Name ="Person Id")]
            public int PersonId { get; set; }
            [Display(Name ="First Name")] 
            public string FirstName { get; set; }
            [Display(Name ="Middle Name")]
            public string MiddleName { get; set; }
            [Display(Name = "Last Name")]
            public string LastName { get; set; } 
            [DataType(DataType.DateTime)]
            public Nullable<System.DateTime> DateOfBirth { get; set; }
            [DataType(DataType.DateTime)]
            public System.DateTime AddedOn { get; set; }
            [Display(Name = "Added By")]
            public string AddedBy { get; set; }
            [Display(Name = "Home Address")]
            public string HomeAddress { get; set; }
            [Display(Name = "Home City")]
            public string HomeCity { get; set; }
            [Display(Name = "Facebook AccountId")]
            public string FaceBookAccountId { get; set; }
            [Display(Name = "LinkedIn Id")]
            public string LinkedInId { get; set; }
            [DataType(DataType.DateTime)] 
            public Nullable<System.DateTime> UpdateOn { get; set; }
            [Display(Name = "Image Path")]
            public string ImagePath { get; set; }
            [Display(Name = "Twitter Id")]
            public string TwitterId { get; set; }
            [Display(Name = "Email Id")]
            public string EmailId { get; set; }
            [Display(Name = "Asp.Net User")]
            public virtual AspNetUser AspNetUser { get; set; }
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
            [Display(Name = "Contact")]
            public virtual ICollection<Contact> Contacts { get; set; }
        }
    }