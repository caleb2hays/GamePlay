using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GamePlay.Models
{
    public class RentalModel
    {
        public int Id { get; set; }

        [Required]
        public CustomerModel Customer { get; set; }

        [Required]
        public GameModel Game { get; set; }

        public DateTime DateRented { get; set; }

        public DateTime? DateReturned { get; set; }
    }
}