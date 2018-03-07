using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CustomerProject.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [StringLength(50, ErrorMessage = "Maximum length is 50")]
        public string Name { get; set; }
        public decimal Sales { get; set; }
        public bool Active { get; set; }
        public DateTime DateCreated { get; set; }

        public Customer() {

        } 
    }
}