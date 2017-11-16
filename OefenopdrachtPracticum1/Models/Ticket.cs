using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OefenopdrachtPracticum1.Models
{
    public class Ticket
    {
        public int ID { get; set; }

        [Required]
        [Display(Name = "Klant")]
        public ApplicationUser Customer { get; set; }

        [Required]
        [Display(Name = "Applicatie")]
        public string Application { get; set; }

        [Required]
        [Display(Name = "Onderwerp")]
        public string Subject { get; set; }

        [Required]
        [Display(Name = "Beschrijving")]
        public string Description { get; set; }

        [Required]
        [Display(Name = "Datum")]
        public DateTime Date { get; set; }

        [Required]
        [Display(Name = "Status")]
        public StatusEnum Status { get; set; }

        public Ticket()
        {
            Date = DateTime.Now;
            Status = StatusEnum.New;
        }
    }

    public enum StatusEnum
    {
        New,
        Processing,
        Resolved
    }
}