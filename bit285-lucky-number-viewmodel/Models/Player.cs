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
        public int PlayerId { get; set; }
        
        //Makes the name required and displays the word Name
        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }

        //display words Lucky Number, makes it required and makes the range to be between 1
        //and 9 and will display a error message if not
        [Required]
        [Display(Name = "Lucky Number")]
        [Range (1,9, ErrorMessage = "Number must be between 1 and 9.")]
        public int Number { get; set; }
       
        //Makes Balance a require field and displays the word Balance
        //makes the balance be a currency field
       // [Required]
        [Display(Name = "Balance")]
        [DataType(DataType.Currency)]
        public double Balance { get; set; }
       

    }
}