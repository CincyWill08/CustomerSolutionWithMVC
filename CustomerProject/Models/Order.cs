using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CustomerProject.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public decimal Total { get; set; }
        [StringLength(80, ErrorMessage = "Maximum length is 80")]
        public string Description { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }

        public Order() { }

        public Order(DateTime date, decimal total, string description, int customerId)
        {
            this.Id = 0;
            this.Date = date;
            this.Total = total;
            this.Description = description;
            this.CustomerId = customerId;
        }

    }
}
