using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace bit285_lucky_number_viewmodel.Models
{
    public class Player
    {
        //TODO: Add the properties neededby the Player entity (including Data Annotations)
       


        [Key]
        public int PlayerId { get; set;}

        public string Name { get; set; }
        [Required]
        [Display(Name = "Lucky Number")]
        [Range(1, 9, ErrorMessage = "The Lucky Number must be a number from 1 to 9")]
        public int Number { get; set; }

        [Required]
        public decimal Balance { get; set; }
      


    }
}